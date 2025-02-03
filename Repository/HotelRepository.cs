using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;

namespace MagicVilla_VillaAPI.Repository
{
    public class HotelRepository: Repository<Hotel>, IHotelRepository
    {
        private readonly ApplicationDbContext _db;

        public HotelRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Hotel> UpdateAsync(Hotel entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Hotels.Update(entity);
            await _db.SaveChangesAsync();
            return entity;

        }
    }
}
