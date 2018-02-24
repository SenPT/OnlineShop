using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Infrustructure
{
    public class DbFactory : Disposable,IDbFactory
    {
        private _OnlineShopDbContext dbContext;

        public _OnlineShopDbContext Init()
        {
            return dbContext ?? (dbContext = new _OnlineShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
