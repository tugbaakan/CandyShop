using CandyShop.Models;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Controllers
{
    public class CandyController: Controller
    {
        private readonly ICandyRepository _candyRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ISellerRepository _sellerRepository;
        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository, ISellerRepository sellerRepository )
        {
            _candyRepository = candyRepository;
            _categoryRepository = categoryRepository;
            _sellerRepository = sellerRepository;
        }

        public IActionResult List(string categoryName) 
         {
             var candyListViewModel = new CandyListViewModel();

             if (string.IsNullOrEmpty(categoryName))
             {
                 candyListViewModel.Candies = _candyRepository.GetAllCandy;
                 candyListViewModel.CurrentCategory = "All candies";
             }
             else 
             {
                 candyListViewModel.Candies = _candyRepository.GetCandiesByCategory(categoryName).ToList();
                 candyListViewModel.CurrentCategory = _categoryRepository.GetCategoryByName(categoryName)?.CategoryName;
             }

             return View(candyListViewModel);

         }

        public IActionResult ListCandiesBySeller(string sellerName)
        {
            var sellerCandyListViewModel = new SellerCandyListViewModel();

            if (string.IsNullOrEmpty(sellerName))
            {
                sellerCandyListViewModel.Candies = _candyRepository.GetAllCandy;
                sellerCandyListViewModel.CurrentSeller = "All candies";
            }
            else
            {
                sellerCandyListViewModel.Candies = _candyRepository.GetCandiesBySeller(sellerName).ToList();
                sellerCandyListViewModel.CurrentSeller = _sellerRepository.GetSellerByName(sellerName)?.SellerName;
            }

            return View(sellerCandyListViewModel);

        }
        public IActionResult Details(int id)
        {
            var candy = _candyRepository.GetCandyById(id);
            if (candy == null) return NotFound();
            return View(candy);

        }

    }
}
