using BookStore.Core.Domain.Entities;
using BookStore.Core.Domain.ValueObjects;

namespace BookStore.Core.Domain.Contracts
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        Customer GetByEmail(Email email);
    }
}
