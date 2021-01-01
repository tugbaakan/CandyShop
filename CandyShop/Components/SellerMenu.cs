using CandyShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Components
{
    public class SellerMenu: ViewComponent
    {
        private readonly ISellerRepository _sellerrepository;

        public SellerMenu(ISellerRepository sellerrepository)
        {
            _sellerrepository = sellerrepository;
        }

        public IViewComponentResult Invoke()
        {
            var sellers = _sellerrepository.GetAllSellers();

            return View(sellers);
        }

    }
}
