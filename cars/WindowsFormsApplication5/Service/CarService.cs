using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5.Service
{
    public class CarService : ICarService
    {

        public Task<int> InsertAsync(Entity.Car car)
        {
            throw new NotImplementedException("No Data base");
        }


        public Task<List<Entity.Car>> selectAll()
        {
            throw new NotImplementedException();
        }
    }
}
