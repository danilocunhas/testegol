using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Teste.GOL.Domain.Entities;
using Teste.GOL.Domain.Servicos;

namespace Teste.GOL.Service.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/[controller]")]
    [ApiController]
    public class AirPlaneController : ControllerBase
    {

        private readonly IAirPlaneApplicationService _service;

        public AirPlaneController(IAirPlaneApplicationService service)
        {
            _service = service;
        }        
     
        [HttpGet]
        public ActionResult<IEnumerable<AirPlane>> Get()
        {
            return _service.Get();
        }
       
        [HttpGet("{id}")]
        public ActionResult<AirPlane> Get(int id)
        {
            return _service.Get(id);
        }
                
        [HttpPost]
        public void Post(AirPlane airplane)
        {
            _service.Insert(airplane);
        }
       
        [HttpPut]
        public void Put(AirPlane airplane)
        {
            _service.Update(airplane);
        }
       
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}