using Exam_2modul.Entities;
using Exam_2modul.Services.Dto;

namespace Exam_2modul.Services;

public interface ICarService
{
    Guid Add(CarDto Id);
    void Delete(Guid Id);
    void Update(CarDto Id);
    List<CarDto> GetAll();
    CarDto GetById(Guid Id);
    List<CarDto> GetCarsSortedBtPrice();
    List<CarDto> GetRecentCars(int years);
    List<CarDto> GetAllCarsByBrand(string brand);
    CarDto GetMostExpensiveCar();
    List<CarDto> GetCarsByYearRange(int startYear, int endYear);
    CarDto GetLowestMileageCar();
    List<CarDto> SearchCarsByModel(string Keyword);
    List<CarDto> GetCarsWithinPriceRange(double minPrice, double maxPrice);
}