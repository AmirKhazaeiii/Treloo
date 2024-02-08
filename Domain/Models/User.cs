using Domain.Context;
using Service.Interfaces;

namespace Domain.Models
{
    public class User
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public UserRoleContext context { get; set; }

        public User(IRoleService role)
        {
            context = new UserRoleContext(role);
        }
        public void showInfo()
        {
            Console.WriteLine($"name: {fullName}, role: {context.getRoleName()}");
        }
    }
}
