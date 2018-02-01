using OnlineShop.Data.Infrustructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface IPageRepository: IRepository<Page>
    {
    }
    public class PageResponsitory: RepositoryBase<Page>, IPageRepository
    {
        public PageResponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
