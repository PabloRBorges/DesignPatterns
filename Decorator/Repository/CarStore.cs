﻿using Bogus;
namespace Decorator.Repository
{
    public class CarStore : ICarStore
    {
        public List<Car> CarStorage { get; set; }

        public CarStore()
        {
            var id = 0;
            var testOrders = new Faker<Car>()
                .RuleFor(o => o.Id, f => ++id)
                .RuleFor(o => o.Year, f => f.Random.Int(1950, 2020))
                .RuleFor(o => o.Name, f => f.Vehicle.Manufacturer())
                .RuleFor(o => o.Model, f => f.Vehicle.Type());

            CarStorage = testOrders.Generate(100);
        }

        public CarDto GetCarById(int id)
        {
            return new CarDto("DataBase", CarStorage.FirstOrDefault(x => x.Id == id));
        }
        public CarDto GetCars()
        {
            return new CarDto("FromDataBase", CarStorage.ToArray());
        }
    }
}
