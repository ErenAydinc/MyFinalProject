using DataAccess.Abstract;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal: EfEntityRepositoryBase<Order, NorthwindContext>,IOrderDal
    {
    }
}
