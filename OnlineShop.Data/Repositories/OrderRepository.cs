using OnlineShop.Data.Infrustructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface IOrderRespository: IRepository<Order>
    {

    }
    public class OrderRepository: RepositoryBase<Order>, IOrderRespository
    {
        public OrderRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }  
    }
}
