using OnlineShop.Data.Infrustructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface IPostTagRepository: IRepository<PostTag>
    {
    }
    public class PostTagResponsitory: RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagResponsitory(IDbFactory dbFactory): base(dbFactory)
        {
       
        }
    }
}
