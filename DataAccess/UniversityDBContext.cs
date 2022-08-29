using Microsoft.EntityFrameworkCore;
using web_asp.Models.DataModels;

namespace web_asp.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options)
        {

        }

        // TODO: Add DbSets (Tables of our data base)
        public DbSet<User>? Users { get; set; }
    }
}
