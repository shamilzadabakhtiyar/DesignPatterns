using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.DecoratorPattern.TestDbContext
{
    public class TestDbContext: DbContext
    {
        public override int SaveChanges()
        {
            // audit logging
            return base.SaveChanges();
        }
    }
}
