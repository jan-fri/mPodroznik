using mPodroznik.DAL;
using System.Data.Entity;

namespace mPodroznik.Models.User
{
    public class UserContext : DbContext
    {
        public UserContext() : base("UserContext")
        {
            Database.SetInitializer<UserContext>(new UserInitializer());
        }

        public DbSet<User> Users { get; set; }
    }
}
