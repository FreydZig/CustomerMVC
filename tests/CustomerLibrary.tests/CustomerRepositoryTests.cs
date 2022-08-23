using CustomerLIbrary.Entities;
using CustomerLIbrary.Repositories;
using Xunit;

namespace CustomerLibrary.tests
{

    public class CustomerRepositoryTests
    {
        public CustomerRepositoryFixture Fixture => new CustomerRepositoryFixture();

        [Fact]
        public void ShouldBeAbleToCreateCustomerRepository()
        {
            var repository = new CustomerRepository();
            Assert.NotNull(repository);
        }

        [Fact]
        public void ShouldBeAbleToCreateCustomer()
        {
            Fixture.DeleteAll();
            var repository = new CustomerRepository();
            var customer = new Customer()
            {
                FirstName = "Evven",
                LastName = "Smith",
                PhoneNumber = "+12345678901",
                Email = "qwer@ty.uio",
                TotalPurchasesAmount = 13
            };
            repository.Create(customer);
        }

        [Fact]
        public void ShouldBeAbleToReadCustomer()
        {
            Fixture.DeleteAll();
            var createCustomer = Fixture.CreateCustomerRepository().Read("127");
            Assert.Equal(127,createCustomer.CustomerId);
        }

        [Fact]
        public void ShouldNotBeAbleToReadCustomer()
        {
            Fixture.DeleteAll();
            var createCustomer = Fixture.CreateCustomerRepository().Read("1");
            Assert.Null(createCustomer);
        }

        [Fact]
        public void ShouldBeAbleToUodateCustomer()
        {
            Fixture.DeleteAll();
            var customer = new Customer()
            {
                CustomerId = 127,
                FirstName = "Jhosh",
                LastName = "Smith",
                PhoneNumber = "+12345678901",
                Email = "qwer@ty.uio",
                TotalPurchasesAmount = 13
            };
            Fixture.CreateCustomerRepository().Update(customer);
        }

        [Fact]
        public void ShouldBeAbleToDeleteCustomer()
        {
            var customer = new Customer()
            {
                FirstName = "Uwu",
                LastName = "Iwi",
                PhoneNumber = "+00000000000",
                Email = "qwer@ty.uio",
                TotalPurchasesAmount = 123
            };
            Fixture.CreateCustomerRepository().Create(customer);
            Fixture.CreateCustomerRepository().Delete(customer.FirstName);
        }

    }
    public class CustomerRepositoryFixture
    {
        public void DeleteAll()
        {
            var repository = new CustomerRepository();
            repository.DeleteAll();
        }

        public CustomerRepository CreateCustomerRepository()
        {
            return new CustomerRepository();
        }
    }
}