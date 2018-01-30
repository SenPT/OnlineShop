using OnlineShop.Model.Models;
using OnlineShop.Data.Infrustructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface ISystemCongigRepository: IRepository<SystemConfig>
    {

    }
    public class SystemConfigResponsitory: RepositoryBase<SystemConfig>, ISystemCongigRepository
    {
        public SystemConfigResponsitory(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
