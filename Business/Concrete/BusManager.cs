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
    public class BusManager : IBusService
    {
        IBusDal _busdDal;
        public BusManager(IBusDal busDal)
        {
            _busDal = busDal;
        }
        public Bus GetByColorId(int busId)
        {
            throw new NotImplementedException();
        }
    }
}
