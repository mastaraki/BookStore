
using BookStore.Core.Domain.Contracts;
using BookStore.Core.Domain.Entities;
using CourseStore.Infrastructures.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BookStore.Infrastructures.DataAccess.Repositories
{
    public class CustomerRepository : BaseRepository<Customer, BookStoreContext>,ICustomerRepository
    {
        public CustomerRepository(BookStoreContext dbContext) : base(dbContext)
        {
        }

        public Customer GetByEmail(string email)
        {
            return _dbContext.Customers.Include(c=>c.PurchasedCourses).
                ThenInclude(c=>c.Course).FirstOrDefault(c => c.Email == email);
        }
        public override Customer GetById(long id)
        {
            return _dbContext.Customers.Include(c => c.PurchasedCourses).
               ThenInclude(c => c.Course).FirstOrDefault(c => c.Id == id);
        }
    }
}
