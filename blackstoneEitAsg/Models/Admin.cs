using System.ComponentModel.DataAnnotations;

namespace blackstoneEitAsg.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } = null;
        public string? Email { get; set; }
        public string Password { get; set; } = null;
    }
}
