using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;

        public OrderRepository( AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

       public void AddOrder(Order order)
        {
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
        }
    }
}
