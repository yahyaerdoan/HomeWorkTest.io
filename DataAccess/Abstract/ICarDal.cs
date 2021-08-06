using AlphastellarHomeTest.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetByColorId(int carId);
        Boolean CloseTheCarLightById(int carId);
        Car DeleteCarById(int carId);
    }
}
