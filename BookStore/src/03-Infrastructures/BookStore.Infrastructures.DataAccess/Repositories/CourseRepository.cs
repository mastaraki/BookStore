
using BookStore.Core.Domain.Contracts;
using BookStore.Core.Domain.Entities;
using CourseStore.Infrastructures.DataAccess.DbContexts;

namespace BookStore.Infrastructures.DataAccess.Repositories
{
    public class CourseRepository : BaseRepository<Course, BookStoreContext>, ICourseRepository
    {
        public CourseRepository(BookStoreContext dbContext) : base(dbContext)
        {
        }
    }
}
