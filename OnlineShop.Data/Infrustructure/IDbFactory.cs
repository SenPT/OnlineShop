using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Infrustructure
{
   public interface IDbFactory : IDisposable
    {
        _OnlineShopDbContext Init();
    }
}
