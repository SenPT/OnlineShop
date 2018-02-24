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
    public class SystemConfigRepository: RepositoryBase<SystemConfig>, ISystemCongigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
