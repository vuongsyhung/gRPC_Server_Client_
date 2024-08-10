using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using gRPCOnlineBankingClient.Protos;
using Grpc.Net.Client;
using gRPCOnlineBankingClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Grpc.Core;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Threading.Channels;
using System;
using Microsoft.EntityFrameworkCore;

namespace gRPCOnlineBankingClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ReadCustomer(int id = 0) 
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7128");
            var client = new OnlineBanking.OnlineBankingClient(channel);

            Customer customer = new()
            {
                CustomerId = 0000,
                FirstName = "Hung",
                LastName = "HungAngu",
                DateOfBirth = DateTime.Parse("1970-04-22"),
                Email = "hungangu@hotmail.com",
                StreesAddress = "TTO",
                City = "Hanoi",
                State = "So Republic",
                ZipCode = 10000,
                Country = "Vietnam",
                Sex = "Male"
            };
            
            try
            {                
                var reply = await client.ReadCustomerAsync(new ReadCustomerRequest { CustomerId = id });
                
                customer = new()
                {
                    CustomerId = reply.CustomerId,
                    FirstName = reply.FirstName,
                    LastName = reply.LastName,
                    DateOfBirth = DateTime.Parse(reply.DateOfBirth),
                    Email = reply.Email,
                    StreesAddress = reply.StreesAddress,
                    City = reply.City,
                    State = reply.State,
                    ZipCode = reply.ZipCode,
                    Country = reply.Country,
                    Sex = reply.Sex
                };
                return View(customer);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View(customer);
            }
        }

        public async Task<IActionResult> GetAllCustomers() 
        {
            List<Customer> customers = new List<Customer>();            
            using var channel = GrpcChannel.ForAddress("https://localhost:7128");
            var client = new OnlineBanking.OnlineBankingClient(channel);
            GetAllCustomerResponse abc = await client.GetAllCustomersAsync(request: new GetAllCustomerRequest { });
             
            if (abc == null)
                return NotFound();
            
            var reply = abc.Customers;
            for (int i = 0; i < reply.Count(); i++)
            {
                Customer customer = new Customer
                {
                    CustomerId = reply[i].CustomerId,
                    FirstName = reply[i].FirstName,
                    LastName = reply[i].LastName,
                    DateOfBirth = DateTime.Parse(reply[i].DateOfBirth),
                    Email = reply[i].Email,
                    StreesAddress = reply[i].StreesAddress,
                    City = reply[i].City,
                    State = reply[i].State,
                    ZipCode = reply[i].ZipCode,
                    Country = reply[i].Country,
                    Sex = reply[i].Sex
                };
                customers.Add(customer);
            }
            return View(customers);
        }

        
        // UpdateCustomer
        public async Task<IActionResult> UpdateCustomer(int id = 0)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7128");
            var client = new OnlineBanking.OnlineBankingClient(channel);

            Customer customer = new()
            {
                CustomerId = 0000,
                FirstName = "Hung",
                LastName = "HungAngu",
                DateOfBirth = DateTime.Parse("1970-04-22"),
                Email = "hungangu@hotmail.com",
                StreesAddress = "TTO",
                City = "Hanoi",
                State = "So Republic",
                ZipCode = 10000,
                Country = "Vietnam",
                Sex = "Male"
            };

            try
            {
                var reply = await client.ReadCustomerAsync(new ReadCustomerRequest { CustomerId = id });
                
                customer = new()
                {
                    CustomerId = reply.CustomerId,
                    FirstName = reply.FirstName,
                    LastName = reply.LastName,
                    DateOfBirth = DateTime.Parse(reply.DateOfBirth),
                    Email = reply.Email,
                    StreesAddress = reply.StreesAddress,
                    City = reply.City,
                    State = reply.State,
                    ZipCode = reply.ZipCode,
                    Country = reply.Country,
                    Sex = reply.Sex
                };
                return View(customer);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("GetAllCustomers");
            }            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateCustomer(int id, [Bind("CustomerId,FirstName,LastName,DateOfBirth,Email,StreesAddress,City,State,ZipCode,Country,Sex")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    using var channel = GrpcChannel.ForAddress("https://localhost:7128");
                    var client = new OnlineBanking.OnlineBankingClient(channel);
                    await client.UpdateCustomerAsync(request: new UpdateCustomerRequest
                    {
                        CustomerId = customer.CustomerId,
                        FirstName = customer.FirstName,
                        LastName = customer.LastName,
                        DateOfBirth = customer.DateOfBirth.ToString(),
                        Email = customer.Email,
                        StreesAddress = customer.StreesAddress,
                        City = customer.City,
                        State = customer.State,
                        ZipCode = customer.ZipCode,
                        Country = customer.Country,
                        Sex = customer.Sex
                    });                   
                }
                catch (DbUpdateConcurrencyException)
                {
                        return NotFound();                  
                }                
            }
            return RedirectToAction(nameof(GetAllCustomers));
        }        
        

        //CreateCustomer        
        public IActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCustomer([Bind("CustomerId,FirstName,LastName,DateOfBirth,Email,StreesAddress,City,State,ZipCode,Country,Sex")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                using var channel = GrpcChannel.ForAddress("https://localhost:7128");
                var client = new OnlineBanking.OnlineBankingClient(channel);
                await client.CreateCustomerAsync(request: new CreateCustomerRequest {
                    //CustomerId = customer.CustomerId,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    DateOfBirth = customer.DateOfBirth.ToString(),
                    Email = customer.Email,
                    StreesAddress = customer.StreesAddress,
                    City = customer.City,
                    State = customer.State,
                    ZipCode = customer.ZipCode,
                    Country = customer.Country,
                    Sex = customer.Sex
                });

                return RedirectToAction(nameof(GetAllCustomers));
            }
            return RedirectToAction(nameof(GetAllCustomers));
        }

        //Delete
        // GET
        public async Task<IActionResult> DeleteCustomer(int id) 
        {
            if (id <= 0)
            {
                return NotFound();
            }

            using var channel = GrpcChannel.ForAddress("https://localhost:7128");
            var client = new OnlineBanking.OnlineBankingClient(channel);
            try
            {
                var reply = await client.ReadCustomerAsync(new ReadCustomerRequest { CustomerId = id });

                Customer customer = new()
                {
                    CustomerId = reply.CustomerId,
                    FirstName = reply.FirstName,
                    LastName = reply.LastName,
                    DateOfBirth = DateTime.Parse(reply.DateOfBirth),
                    Email = reply.Email,
                    StreesAddress = reply.StreesAddress,
                    City = reply.City,
                    State = reply.State,
                    ZipCode = reply.ZipCode,
                    Country = reply.Country,
                    Sex = reply.Sex
                };
                if (customer == null)
                {
                    return NotFound();
                }

                return View(customer);                
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("GetAllCustomers");
            }            
        }
        //Delete
        // POST
        [HttpPost, ActionName("DeleteCustomer")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCustomerConfirmed(int id = 0)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            using var channel = GrpcChannel.ForAddress("https://localhost:7128");
            var client = new OnlineBanking.OnlineBankingClient(channel);
            var customerId = await client.DeleteCustomerAsync(request: new DeleteCustomerRequest
            { CustomerId = id });
            if (customerId == null)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(GetAllCustomers));
        }
    }
}

