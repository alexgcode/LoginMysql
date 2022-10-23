using LoginMysql.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginMysql.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<StudentModel> alumno { get; set; } //its equalt to use uppercase or lowercase
        public DbSet<UserModel> usuarios { get; set; }
    }
}
