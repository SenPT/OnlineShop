using OnlineShop.Data.Infrustructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface IPostRepository: IRepository<Post>
    {

    }
    public class PostRepository: RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory):base(dbFactory)
            {
        }
    }
}
