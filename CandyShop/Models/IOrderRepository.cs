﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        IEnumerable<OrderDetail> GetOrderDetails(Order order);

    }
}