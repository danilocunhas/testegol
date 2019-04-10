using System;
using System.Collections.Generic;
using System.Text;
using Teste.GOL.Infra.Persistence.ORM.DataContexts;

namespace Teste.GOL.Infra.Persistence
{
    public sealed class UnitOfWork : IUnitOfWork
    {

        private TesteGOLContext _context;

        public UnitOfWork(TesteGOLContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                //Algum log, etc...
                throw ex;
            }
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }
        }
    }
}
