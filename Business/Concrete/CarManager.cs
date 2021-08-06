using AlphastellarHomeTest.Entities.Concrete;
using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
       
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;           
        }
        public bool CloseTheCarLightById(int carId)
        {
            throw new NotImplementedException();
        }

        public Car DeleteCarById(int carId)
        {
            throw new NotImplementedException();
        }

        public Car GetByColorId(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
