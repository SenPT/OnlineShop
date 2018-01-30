using OnlineShop.Data.Infrustructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface ISupportOnlineRepository: IRepository<SupportOnline>
    {
    }
    public class SupportOnlineResponsotory
    {
        public SupportOnlineResponsotory(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
