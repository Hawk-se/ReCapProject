using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class EfCarDal : ICarDal
    {
        List<Car> _cars;
        public EfCarDal()    // Contructor (ctor)
        {
            _cars = new List<Car> { 
            new Car{Id=1, BrandId=5, ColorId=101, ModelYear=2021, Description="Volvo XC90", DailyPrice=3000},
            new Car{Id=2, BrandId=4, ColorId=102, ModelYear=2020, Description="Mercedes AMG GLS", DailyPrice=2000},
            new Car{Id=3, BrandId=3, ColorId=103, ModelYear=2021, Description="BMW X7", DailyPrice=2500},
            new Car{Id=4, BrandId=2, ColorId=104, ModelYear=2018, Description="Audi Q7", DailyPrice=2250},
            new Car{Id=5, BrandId=1, ColorId=105, ModelYear=2019, Description="Volkswagen Toureg", DailyPrice=2750},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
