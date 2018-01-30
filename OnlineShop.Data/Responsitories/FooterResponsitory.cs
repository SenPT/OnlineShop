using OnlineShop.Data.Infrustructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface IFooterRepository : IRepository<Footer>
    {

    }
   public class FooterResponsitory : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterResponsitory(IDbFactory dbFactory):base(dbFactory)
        {
        }
    }
}
