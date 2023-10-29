using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCarDal : ICarDal
{
    private readonly List<Car> _cars;

    public InMemoryCarDal()
    {
        _cars = new List<Car>
        {
            new Car{Id = 1,Brand = 1,Color = 1,ModelYear = 2018,DailyPrice = 545,Description = "Audi Q7"},
            new Car{Id = 2,Brand = 2,Color = 2,ModelYear = 2019,DailyPrice = 645,Description = "BMW SX1"},
            new Car{Id = 3,Brand = 3,Color = 3,ModelYear = 2020,DailyPrice = 745,Description = "Mercedes-Benz SL100"},
            new Car{Id = 4,Brand = 4,Color = 4,ModelYear = 2021,DailyPrice = 845,Description = "Tesla SX 250"},
            new Car{Id = 5,Brand = 5,Color = 5,ModelYear = 2022,DailyPrice = 945,Description = "TOGG XX10"},
            
        };
    }

    public List<Car> GetAll()
    {
        return _cars;
    }

    public Car Get(int id)
    {
        return _cars.SingleOrDefault(x => x.Id == id)!;
    }

    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Update(Car car)
    {
        var entityUpdateTo = _cars.SingleOrDefault(x => x.Id == car.Id)!;
        entityUpdateTo.Brand = car.Brand;
        entityUpdateTo.Color = car.Color;
        entityUpdateTo.ModelYear = car.ModelYear;
        entityUpdateTo.DailyPrice = car.DailyPrice;
        entityUpdateTo.Description = car.Description;
    }

    public void Delete(Car car)
    {
        var entityDeleteTo = _cars.SingleOrDefault(x => x.Id == car.Id)!;
        _cars.Remove(entityDeleteTo);
    }
}