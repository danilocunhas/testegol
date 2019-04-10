using System;
using System.Collections.Generic;
using System.Text;
using Teste.GOL.Domain.Entities;
using Teste.GOL.Domain.Repository;
using Teste.GOL.Domain.Servicos;
using Teste.GOL.Domain.Specs;
using Teste.GOL.Infra.Persistence;

namespace Teste.GOL.ApplicationService
{
    public class AirPlaneApplicationService : ApplicationService, IAirPlaneApplicationService
    {
        private readonly IRepository<AirPlane> _repository;
        public AirPlaneApplicationService(IUnitOfWork unitOfWork, IRepository<AirPlane> repository) : base(unitOfWork)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(this.Get(id));
            Commit();
        }

        public List<AirPlane> Get()
        {
            return _repository.GetAll();
        }

        public AirPlane Get(int id)
        {
            return _repository.GetFirst(AirPlaneSpecs.GetById(id));
        }

        public void Insert(AirPlane airplane)
        {           
            _repository.Insert(airplane);
            Commit();
        }

        public void Update(AirPlane airplane)
        {
            _repository.Update(airplane);
            Commit();
        }
    }
}
