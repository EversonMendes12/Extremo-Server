using Microsoft.EntityFrameworkCore;

namespace Server.Factory
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) 
        {

        }
        
    }
}
