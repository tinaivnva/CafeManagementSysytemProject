﻿using CafeManagementSystemProject.DataFolder;
using CafeManagementSystemProject.Models;
using CafeManagementSystemProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CafeManagementSystemProject.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private MVCOrderDbContext context;
        public OrderRepository(MVCOrderDbContext context)
        {
            this.context = context;
        }
        public void AddOrder(Order order)
        {
            context.Add(order);
            context.SaveChanges();
        }

        public void AddProductToOrder(Product product)
        {
            context.Add(product);
            context.SaveChanges();
        }
        public void RemoveProductFromOrder(Product product)
        {
            context.Update(product);
            context.SaveChanges();
        }

    }
}
