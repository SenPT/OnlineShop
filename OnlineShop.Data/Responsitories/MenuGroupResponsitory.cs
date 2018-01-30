using OnlineShop.Data.Infrustructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface IMenuGroupRepository: IRepository<MenuGroup>
    {

    }
    public class MenuGroupResponsitory: RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupResponsitory(IDbFactory dbFactory):base(dbFactory)
        {
            
        }
    }
}
