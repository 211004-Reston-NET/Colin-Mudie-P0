using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;
using Entity = Data_Access_Logic.Entities;

namespace Data_Access_Logic
{
    public class RepositoryCloud : IRepository
    {
        private Entity.MMDBContext _context;
        public RepositoryCloud(Entity.MMDBContext p_context)
        {
            _context = p_context;
        }

        public Models.Customer AddCustomer(Models.Customer p_customer)
        {
            _context.Customers.Add(
                new Entity.Customer()
                {
                    Name = p_customer.Name,
                    Email = p_customer.Email,
                    PhoneNumber = p_customer.PhoneNumber,
                    Address = p_customer.Address
                }
            );
            _context.SaveChanges();
            return p_customer;
        }

        public List<Models.Products> GetAllProducts()
        {
            return _context.Products.Select(prod => 
            new Models.Products()
            {
                Name = prod.Name,
                Price = prod.Price,
                Description = prod.Description,
                Brand = prod.Brand,
                Category = prod.Category,
                ProductId = prod.ProductId
            }
            ).ToList();
        }

        public List<Models.Customer> GetCustomerList()
        {
            return _context.Customers.Select(cust => 
            new Models.Customer()
            {
                Name = cust.Name,
                Email = cust.Email,
                Address = cust.Address,
                PhoneNumber = cust.PhoneNumber,
                CustomerId = cust.CustomerId
            }
            ).ToList();
        }

        public List<Models.LineItems> GetLineItemsList(int p_storeId)
        {
            return _context.LineItems
            .Where(item => item.Storefront.StorefrontId == p_storeId)
            .Select(item => 
                new Models.LineItems()
                {
                    Product = new Models.Products(){
                        Name = item.Product.Name,
                        Price = item.Product.Price,
                        Description = item.Product.Description,
                        Brand = item.Product.Brand,
                        Category = item.Product.Category,
                        ProductId = item.Product.ProductId
                    },
                    Quantity = item.Quantity,
                    LineItemId = item.LineItemId,
                    StoreFrontId = item.StorefrontId
                }
            ).ToList();
        }

        public Models.Products GetProductByProductId(int p_productId)
        {
            var result = _context.Products
                .FirstOrDefault<Entity.Product>(prod => prod.ProductId == p_productId);
            return new Models.Products()
                {
                    Name = result.Name,
                    Price = result.Price,
                    Description = result.Description,
                    Brand = result.Brand,
                    Category = result.Category,
                    ProductId = result.ProductId
                };
            
        }

        public List<Models.StoreFront> GetStoreFrontList()
        {
            return _context.Storefronts.Select(store => 
                new Models.StoreFront()
                {
                    Name = store.Name,
                    Address = store.Address,
                    LineItems = store.LineItems.Select(item => new Models.LineItems(){
                        Quantity = item.Quantity,
                        Product = new Models.Products(){
                            Name = item.Product.Name,
                            Price = item.Product.Price,
                            Description = item.Product.Description,
                            Brand = item.Product.Brand,
                            Category = item.Product.Category,
                            ProductId = item.Product.ProductId
                        }, 
                        LineItemId = item.LineItemId
                    }).ToList(),
                    Orders = store.Orders.Select(order => new Models.Orders(){
                        OrderId = order.OrderId,
                        Address = order.Address,
                        TotalPrice = order.TotalPrice
                    }).ToList(),
                    StoreFrontId = store.StorefrontId
                }
            ).ToList();
        }

        public Models.Orders PlaceOrder(Models.Customer p_customer, Models.Orders p_order)
        {
            Console.WriteLine(p_order);
            return p_order;
        }
    }
}