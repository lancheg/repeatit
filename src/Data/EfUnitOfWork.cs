using System;
using Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Core.Data.Ef
{
    public sealed class EfUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public EfUnitOfWork(DbContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            _context = context;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
      
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
