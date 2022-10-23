using LoginMysql.Repositories;
using System;

namespace LoginMysql.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; }
        int Complete();
    }
}
