using CustomerLIb.MVC.Controllers;
using CustomerLIbrary.Entities;
using CustomerLIbrary.Interfaces;
using Moq;
using System.Collections.Generic;
using System.Web.Mvc;
using Xunit;

namespace CustomerLIb.MVC.tests
{
    public class CustomerControlerTests
    {
        [Fact]
        public void ShouldBeAbleToCreateCustomerController()
        {
            var controller = new CustomerController();
            Assert.NotNull(controller);
        }
        
        [Fact]
        public void ShouldBeAbleToReturnListOfCustomers()
        {
            var controller = new CustomerController();
            var customersResult = controller.Index();
            var customersView = customersResult as ViewResult;
            var customersModel = customersView.Model as List<Customer>;
            Assert.True(customersModel.Exists(x => x.FirstName == "Jhosh                                             "));
        }

        [Fact]
        public void ShouldBeAbleToCreateNewCustomer()
        {
            var custpmerControllerMock = new Mock<IRepository<Customer>>();
            var customerController = new CustomerController(custpmerControllerMock.Object);

            customerController.Create();
            var result = customerController.Create(new Customer
            {
                FirstName = "Ad",
                LastName = "Ge",
                PhoneNumber = "+12345678911",
                Email = "f@f.f",
                TotalPurchasesAmount = 7
            }) as RedirectToRouteResult;

            Assert.NotNull(result);
        }

        [Fact]
        public void ShouldBeAbleToDeletewCustomer()
        {
            var custpmerControllerMock = new Mock<IRepository<Customer>>();
            var customerController = new CustomerController(custpmerControllerMock.Object);

            customerController.Delete(912);
            var result = customerController.Delete(912, new Customer
            {
                FirstName = "Ad",
                LastName = "Ge",
                PhoneNumber = "+12345678911",
                Email = "f@f.f",
                TotalPurchasesAmount = 7
            }) as RedirectToRouteResult;

            Assert.NotNull(result);
        }

        [Fact]
        public void ShouldBeAbleToEditCustomer()
        {
            var custpmerControllerMock = new Mock<IRepository<Customer>>();
            var customerController = new CustomerController(custpmerControllerMock.Object);

            customerController.Edit(127);
            var result = customerController.Edit(127,new Customer
            {
                FirstName = "Ad",
                LastName = "Ge",
                PhoneNumber = "+12345678911",
                Email = "f@f.f",
                TotalPurchasesAmount = 7
            }) as RedirectToRouteResult;

            Assert.NotNull(result);
        }
    }
}