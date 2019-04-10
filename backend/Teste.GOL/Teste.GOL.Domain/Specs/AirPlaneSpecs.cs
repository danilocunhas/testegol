using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Teste.GOL.Domain.Entities;

namespace Teste.GOL.Domain.Specs
{
    public static class AirPlaneSpecs
    {
        public static Expression<Func<AirPlane, bool>> GetById(int id)
        {
            return x => (x.Id == id);
        }
    }
}
