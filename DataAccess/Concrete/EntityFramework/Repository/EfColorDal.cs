using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarDBContext>, IColorDal
    {

    }
}