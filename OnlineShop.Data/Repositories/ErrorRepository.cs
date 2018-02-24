using OnlineShop.Data.Infrustructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface IErrorRepository : IRepository<Error>
    {

    }
    public class ErrorResponsitory : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorResponsitory(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
