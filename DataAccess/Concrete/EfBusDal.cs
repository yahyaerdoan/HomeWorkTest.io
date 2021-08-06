using AlphastellarHomeTest.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfBusDal : Bus, AlphastellarHomeTestDataContext, IBusDal
    {
        public Bus GetByColorId(int busId)
        {
            throw new NotImplementedException();
        }
    }
}
