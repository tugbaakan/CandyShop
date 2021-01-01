using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public IEnumerable<OrderDetail> GetOrderDetails(Order order)
        {
            return _appDbContext.OrderDetails.Where(o => o.OrderId == order.OrderId).ToList();
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();

            foreach (var item in shoppingCartItems)
            {
                var orderDetailItem = new OrderDetail
                {
                    CandyID = item.Candy.CandyId,
                    Price = item.Candy.Price,
                    Amount = item.Amount,
                    OrderId = order.OrderId
                };

                _appDbContext.OrderDetails.Add(orderDetailItem);
            }

            _appDbContext.SaveChanges();

        }
    }
}
