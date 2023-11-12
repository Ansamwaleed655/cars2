using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication5.Entity;

namespace WindowsFormsApplication5.Service
{
    public interface ICarService
    {
        Task<int> InsertAsync(Car car);
        Task<List<Car>> selectAll( );
    }
}
