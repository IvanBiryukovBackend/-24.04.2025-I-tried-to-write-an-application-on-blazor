using HomeWorkAuthPager.Domains;
namespace HomeWorkAuthPager.Abstract
{
    public interface ICarsRepository
    {
		Task<List<Car>> GetCars();
		Task<Car> GetCar(int id);
		Task AddCar(Car car);
		Task UpdateCar(Car car);
		Task DeleteCar(int id);

	}
}
