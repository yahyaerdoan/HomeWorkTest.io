using AlphastellarHomeTest.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfCarDal : Car, AlphastellarHomeTestDataContext, ICarDal
    {
        public bool CloseTheCarLightById(int carId)
        {
            throw new NotImplementedException();
        }

        public Car DeleteCarById(int carId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByColorId(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
