using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASYNC_front1.Models.Interfaces
{
    public interface IHotelManager
    {
        Task<List<Hotel>> GetAllHotels();
        Task GetHotelByID();
    }
}
