using System.ComponentModel.DataAnnotations;

namespace LoginMysql.Models
{
    public class UserModel
    {
        [Key]
        public int idUsuario { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
    }
}
