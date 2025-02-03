using Exam_2modul.Entities;
using Exam_2modul.Repository;
using Exam_2modul.Services.Dto;

namespace Exam_2modul.Services;

public class CarService : ICarService
{
    private readonly ICarRepositiry _carRepositiry;
    public CarService()
    {
        _carRepositiry = new CarRepositiry();
    }

    public Guid Add(CarDto Id)
    {
        var car = ConvertToEntitiy(Id);
        var res = _carRepositiry.Add(car);
        return res.Id;
    }

    public void Delete(Guid Id)
    {
        _carRepositiry.Delete(Id);
    }

    public List<CarDto> GetAll()
    {
        var car = _carRepositiry.GetAll();
        var carDtos = car.Select(mu => ConvertToEntitiy(mu)).ToList();
        return carDtos;
    }

    public void Update(CarDto Id)
    {
        var car = ConvertToEntitiy(Id);
        _carRepositiry.Update(car);
    }

    private Car ConvertToEntitiy(CarDto dto)
    {
        return new Car()
        {
            Id = dto.Id,
            Brand = dto.Brand,
            Model = dto.Model,
            Year = dto.Year,
            EngineCapacity = dto.EngineCapacity,
            Price = dto.Price,
            Mileage = dto.Mileage,
            Color = dto.Color,
        };
    }

    private Car ConvertToEntitiy(Car dto)
    {
        return new Car()
        {
            Id = Guid.NewGuid(),
            Brand = dto.Brand,
            Model = dto.Model,
            Year = dto.Year,
            EngineCapacity = dto.EngineCapacity,
            Price = dto.Price,
            Mileage = dto.Mileage,
            Color = dto.Color,
        };
    }

    public List<CarDto> GetAllCarsByBrand(string brand)
    {
        var car = GetById(Id);

    }

    public CarDto GetById(Guid Id)
    {
        var car = _carRepositiry.GetById(Id);
        var carDtos = car.Select(mu => ConvertToEntitiy(mu)).ToList();
        return carDtos;
    }

    public List<CarDto> GetCarsByYearRange(int startYear, int endYear)
    {
        var car = GetById(Id);
        if (car > startYear && car < endYear)
        {

        }
    }

    public List<CarDto> GetCarsSortedBtPrice()
    {
        throw new NotImplementedException();
    }

    public List<CarDto> GetCarsWithinPriceRange(double minPrice, double maxPrice)
    {
        throw new NotImplementedException();
    }

    public CarDto GetLowestMileageCar()
    {
        throw new NotImplementedException();
    }

    public CarDto GetMostExpensiveCar()
    {
        throw new NotImplementedException();
    }

    public List<CarDto> GetRecentCars(int years)
    {
        throw new NotImplementedException();
    }

    public List<CarDto> SearchCarsByModel(string Keyword)
    {
        throw new NotImplementedException();
    }

    

    
}
