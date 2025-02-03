using Exam_2modul.Entities;

namespace Exam_2modul.Repository;

public interface ICarRepositiry
{
    Car Add(Guid Id);
    void Delete(Guid Id);
    void Update(Guid Id);
    List<Car> GetAll();
    Car GetById(Guid Id);
}