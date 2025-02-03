using Exam_2modul.Entities;
using System.Text.Json;

namespace Exam_2modul.Repository;

public class CarRepositiry : ICarRepositiry
{
    private List<Car> _cars;
    private string _path;

    public CarRepositiry()
    {
        _cars = new List<Car>();
        _path = "../../../DataAccess/Data/Music.json";
        if (File.Exists(_path))
        {
            File.WriteAllText(_path, "[]");
        }
        _cars = GetAll();
    }

    public Car Add(Guid Id)
    {
        var car = GetById(Id);
        _cars.Add(car);
        return car;
    }

    public void Delete(Guid Id)
    {
        var car = GetById(Id);
        _cars.Remove(car);
        SaveData();
    }

    public List<Car> GetAll()
    {
        var jsonCars = File.ReadAllText(_path);
        List<Car> cars = JsonSerializer.Deserialize<List<Car>>(jsonCars);
        return cars;
    }

    public Car GetById(Guid Id)
    {
        foreach (Car car in _cars)
        {
            if (car.Id == Id)
            {
                return car;
            }
        }
        throw new Exception($"Xatolik Bor Bunday Id topilmadi {Id}");
    }

    public void Update(Guid Id)
    {
        var musicFromDb = GetById(Id);
        var index = _cars.IndexOf(musicFromDb);
        _cars[index] = musicFromDb;
        SaveData();
    }
    private void SaveData()
    {
        var musicJson = JsonSerializer.Serialize(_cars);
        File.WriteAllText(_path, musicJson);
    }
}
