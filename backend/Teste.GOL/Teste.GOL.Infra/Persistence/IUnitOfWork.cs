using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.GOL.Infra.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
