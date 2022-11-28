using BookStore.Core.Domain.Entities;

namespace BookStore.Core.Domain.Contracts
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        Customer GetByEmail(string email);
    }
}
