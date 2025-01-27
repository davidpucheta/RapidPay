using Data.Data;

namespace Data.Repository
{
    public class BaseRepository
    {
        protected readonly ApplicationDbContext _dbContext;
        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
