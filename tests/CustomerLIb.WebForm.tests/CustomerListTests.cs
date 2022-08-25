using CustomerLIbrary.Entities;
using CustomerLIbrary.Interfaces;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace CustomerLIb.WebForm.tests
{
    public class CustomerListTests
    {
        //[Fact]
        //public void ShouldBeAbleToLoadAllCustomersFromDB()
        //{
        //    var customersRepositoryMock = new Mock<IRepository<Customer>>();
        //    customersRepositoryMock.Setup(x => x.GetAll())
        //        .Returns(() => new List<Customer> { new Customer (), new Customer () } );

        //    var customersList = new CustomerList(customersRepositoryMock.Object);
        //    customersList.LoadCustomersFromDatabase();
        //    Assert.Equal(2, customersList.Customers.Count);
        //}
    }
}