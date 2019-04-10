using System;
using System.Collections.Generic;
using System.Text;
using Teste.GOL.Infra.Persistence;

namespace Teste.GOL.ApplicationService
{
    public class ApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApplicationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Commit()
        {          
            _unitOfWork.Commit();
            return true;
        }

    }
}
