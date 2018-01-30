using OnlineShop.Data.Infrustructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface IOrderDetailRepository: IRepository<OrderDetail>
    {
    }
   public class OrderDetailResponsitory: RepositoryBase<OrderDetail>,IOrderDetailRepository
    {
        public OrderDetailResponsitory(IDbFactory dbFactory):base(dbFactory)
        {
        }
    }
}
