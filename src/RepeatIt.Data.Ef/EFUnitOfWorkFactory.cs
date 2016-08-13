using System;
using System.Collections.Generic;
using System.Linq;
using Core.Data.Ef;
using Core.Domain;

namespace RepeatIt.Data.Ef
{
    public class EfUnitOfWorkFactory:IEfUnitOfWorkFactory { 
       
    /*    private readonly RepeatItEfDataContext _context;

        public EfUnitOfWorkFactory(RepeatItEfDataContext context)
        {
            _context = context;
        }*/

        public IUnitOfWork GetUoW()
        {
            throw new NotImplementedException();
           // return new EfUnitOfWork(_context);
        }
    }
}
