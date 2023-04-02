﻿using CafeManagementSystemProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CafeManagementSystemProject.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        public void AddOrder(Order order);
        public IEnumerable<Order> GetAll();
        public Order GetById(int table_id);
        public void AddProductToOrder(Product product);
        public void RemoveProductFromOrder(Product product);
        public string CheckOut();

    }
}

