using OnlineShop.Data.Infrustructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface ITagRepository : IRepository<Tag>
    {
    }
    public class TagRespository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRespository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
