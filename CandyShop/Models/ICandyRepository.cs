﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public interface ICandyRepository
    {
        IEnumerable<Candy> GetAllCandy { get; }
        IEnumerable<Candy> GetAllCandyOnSale { get; }
        IEnumerable<Candy> GetCandiesByCategory(string categoryName);
        IEnumerable<Candy> GetCandiesBySeller(string sellerName);
        Candy GetCandyById(int CandyId);
    }
}
