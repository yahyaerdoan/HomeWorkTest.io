using AlphastellarHomeTest.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfBoatDal : Boat, AlphastellarHomeTestDataContext, IBoatDal
    {
        public Boat GetByColorId(int boatId)
        {
            throw new NotImplementedException();
        }
    }
}
