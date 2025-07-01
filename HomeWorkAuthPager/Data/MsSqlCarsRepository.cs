using HomeWorkAuthPager.Abstract;
using HomeWorkAuthPager.Domains;
using Microsoft.EntityFrameworkCore;

namespace HomeWorkAuthPager.Data
{
	public class MsSqlCarsRepository : ICarsRepository
    {
        private readonly ApplicationDbContext _context;
        public MsSqlCarsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

		public async Task AddCar(Car car)
		{
			_context.Cars.Add(car);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteCar(int id)
		{
			var car = await _context.Cars.FindAsync(id);
			if(car != null)
			{
				_context.Cars.Remove(car);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<Car> GetCar(int id)
		{
			var car = await _context.Cars.FindAsync(id);
			if (car == null)
			{
				throw new Exception("club not found");
			}
			return car;
		}

		public async Task<List<Car>> GetCars()
		{
			return await _context.Cars.ToListAsync();
		}

		public async Task UpdateCar(Car car)
		{
			_context.Entry(car).State = EntityState.Modified;
			await _context.SaveChangesAsync();
		}
	}
}
