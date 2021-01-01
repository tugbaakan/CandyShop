using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly AppDbContext _appDbContext;

        public CandyRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Candy> GetAllCandy 
        {
            get {
                return _appDbContext.Candies.Include(c => c.Category).OrderBy(c => c.CandyId); ;
            }
        }
        public IEnumerable<Candy> GetAllCandyOnSale
        {
            get
            {
                return _appDbContext.Candies.Include(c => c.Category).Where(c => c.IsOnSale == true);
            }
        }

        public IEnumerable<Candy> GetCandiesByCategory(string categoryName)
        {
            return _appDbContext.Candies.Where(c => c.Category.CategoryName == categoryName)
                .Include(c => c.Category)
                .OrderBy(c => c.CandyId);
            
        }
        public Candy GetCandyById(int candyId)
        {
            return _appDbContext.Candies.Find(candyId);
        }
    }
}
