using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal: EfEntityRepositoryBase <Brand, ReCapContext>, IBrandDal
    {

    }
}