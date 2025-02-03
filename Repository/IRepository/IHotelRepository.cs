using System.Linq.Expressions;
using MagicVilla_VillaAPI.Models;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IHotelRepository: IRepository<Hotel>
    {
        Task<Hotel> UpdateAsync(Hotel entity);
    }
}
