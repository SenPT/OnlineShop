using OnlineShop.Data.Infrustructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface IVisitorStaticRepository: IRepository<VisistorStatic>
    {

    }
    public class VisistorStaticRepository: RepositoryBase<VisistorStatic>, IVisitorStaticRepository
    {
        public VisistorStaticRepository(IDbFactory dbFactory): base(dbFactory)
        {
        }
    }
}
