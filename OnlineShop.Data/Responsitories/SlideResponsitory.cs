using OnlineShop.Data.Infrustructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Responsitories
{
    public interface ISlideRepository: IRepository<Slide>
    {

    }
    public class SlideResponsitory: RepositoryBase<Slide>, ISlideRepository
    {
        public SlideResponsitory(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
