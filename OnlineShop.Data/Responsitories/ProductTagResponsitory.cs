using OnlineShop.Data.Infrustructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface IProductTagRepository: IRepository<ProductTag>
    {
    }
    public class ProductTagResponsitory: RepositoryBase<ProductTag>, IProductTag
    {
        public ProductTagResponsitory(IDbFactory dbFactory):base(dbFactory)
        {
        }
    }
}
