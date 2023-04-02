﻿using CafeManagementSystemProject.Models;
using CafeManagementSystemProject.Repositories.Interfaces;
using CafeManagementSystemProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CafeManagementSystemProject.Services
{
    public class OrderService : IOrderRepository
    {
        private IOrderRepository orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public void AddOrder(Order order)
        {
            List<Order> orders = new List<Order>();
            orders.Add(order);
        }

        public void AddProductToOrder(Product product)
        {
            List<Product> products = new List<Product>();
            products.Add(product);
        }
        public void RemoveProductFromOrder(Product product)
        {
            var list = new List<Product>();
            list.Remove(product);
        }
    }
}