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
    public class VisistorStaticResponsitory: RepositoryBase<VisistorStatic>, IVisitorStaticRepository
    {
        public VisistorStaticResponsitory(IDbFactory dbFactory): base(dbFactory)
        {
        }
    }
}
