using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Teste.GOL.ApplicationService;
using Teste.GOL.Domain.Entities;
using Teste.GOL.Domain.Repository;
using Teste.GOL.Domain.Servicos;
using Teste.GOL.Infra.Persistence;
using Teste.GOL.Infra.Persistence.ORM.DataContexts;
using Teste.GOL.Infra.Repositories;

namespace Teste.GOL.Service
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors(o => o.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddEntityFrameworkSqlServer()
              .AddDbContext<TesteGOLContext>(
                  options => options.UseSqlServer(
                      Configuration.GetConnectionString("BaseAirPlane")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddTransient<IRepository<AirPlane>, Repository<AirPlane>>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IAirPlaneApplicationService, AirPlaneApplicationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("AllowAll");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
