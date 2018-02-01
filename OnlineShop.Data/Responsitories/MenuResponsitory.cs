using OnlineShop.Data.Infrustructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface IMenuRepository:IRepository<Menu>
    {

    }
    public class MenuResponsitory: RepositoryBase<Menu>,IMenuRepository
    {
        public MenuResponsitory(IDbFactory dbFactory):base(dbFactory)
        {
        }
    }
}
