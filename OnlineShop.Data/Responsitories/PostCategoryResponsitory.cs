using OnlineShop.Data.Infrustructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface IPostCategoryRepository: IRepository<PostCategory>
    {
    }
    public class PostCategoryResponsitory: RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryResponsitory(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
