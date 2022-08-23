using CustomerLIbrary.Entities;
using CustomerLIbrary.Repositories;
using Xunit;

namespace CustomerLibrary.tests
{
    public class AddressRepositoryTests
    {
        public AddresRepositoryFixture Fixture => new AddresRepositoryFixture();

        [Fact]
        public void ShouldBeAbleToCreateAddressRepository()
        {
            var repository = new AddresRepository();
            Assert.NotNull(repository);
        }

        [Fact]
        public void ShouldBeAbleToCreateAddress()
        {
            Fixture.DeleteAll();
            var repository = new AddresRepository();
            var address = new Address()
            {
                CustomerId = 127,
                AddressLine = "adasdsasasa",
                AddressLine2 = "adasdsasasa",
                AddressType = "Billing",
                City = "sds",
                PostalCode = "123456",
                State = "dadawd",
                Country = "USA"

            };
            repository.Create(address);
        }

        [Fact]
        public void ShouldBeAbleToReadAddress()
        {
            Fixture.DeleteAll();
            var addressCustomer = Fixture.CreateAddresRepository().Read("103");
            Assert.Equal(103, addressCustomer.AddressId);
            Assert.Equal("a", addressCustomer.AddressLine);
        }

        [Fact]
        public void ShouldNotBeAbleToReadAddress()
        {
            Fixture.DeleteAll();
            var addressCustomer = Fixture.CreateAddresRepository().Read("100");
            Assert.Null(addressCustomer);
        }

        [Fact]
        public void ShouldBeAbleToUodateAddress()
        {
            Fixture.DeleteAll();
            var address = new Address()
            {
                AddressId = 103,
                CustomerId = 127,
                AddressLine = "a",
                AddressLine2 = "b",
                AddressType = "Shipping",
                City = "sds",
                PostalCode = "123456",
                State = "dadawd",
                Country = "USA"

            };
            Fixture.CreateAddresRepository().Update(address);
        }

        [Fact]
        public void ShouldBeAbleToDeleteCustomer()
        {
            var address = new Address()
            {
                CustomerId = 127,
                AddressLine = "a",
                AddressLine2 = "a",
                AddressType = "Shipping",
                City = "sds",
                PostalCode = "123456",
                State = "dadawd",
                Country = "Canada"
            };
            Fixture.CreateAddresRepository().Create(address);
            Fixture.CreateAddresRepository().Delete(address.AddressLine2);
        }

    }

    public class AddresRepositoryFixture
    {
        public void DeleteAll()
        {
            var repository = new CustomerRepository();
            repository.DeleteAll();
        }

        public AddresRepository CreateAddresRepository()
        {
            return new AddresRepository();
        }
    }
}
