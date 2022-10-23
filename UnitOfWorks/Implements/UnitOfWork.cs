using LoginMysql.Data;
using LoginMysql.Repositories;
using LoginMysql.Repositories.Implements;

namespace LoginMysql.UnitOfWorks.Implements
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public IStudentRepository Students { get; private set; }

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Students = new StudentRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
