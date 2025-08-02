using Test.Data;
using Test.Models.Domain;

namespace Test.Repositories
{
    public class SQLWalkRepository : IWalkRepository
    {
        private readonly TestDbContext dbContext;

        public SQLWalkRepository(TestDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Walk> CreateAsync(Walk walk)
        {
            await dbContext.Walks.AddAsync(walk);
            await dbContext.SaveChangesAsync();
            return walk;
        }
    }
}