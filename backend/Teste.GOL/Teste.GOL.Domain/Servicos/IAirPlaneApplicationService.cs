using System;
using System.Collections.Generic;
using System.Text;
using Teste.GOL.Domain.Entities;

namespace Teste.GOL.Domain.Servicos
{
    public interface IAirPlaneApplicationService
    {
        List<AirPlane> Get();
        AirPlane Get(int id);
        void Update(AirPlane airplane);
        void Delete(int id);
        void Insert(AirPlane airplane);
    }
}
