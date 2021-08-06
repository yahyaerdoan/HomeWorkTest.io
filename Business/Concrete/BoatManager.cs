using AlphastellarHomeTest.Entities.Concrete;
using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BoatManager : IBoatService
    {
        IBoatDal _boatdDal;

        public BoatManager(IBoatDal boatdDal)
        {
            _boatdDal = boatdDal;
        }
        public Boat GetByColorId(int boatId)
        {
            throw new NotImplementedException();
        }
    }
}
