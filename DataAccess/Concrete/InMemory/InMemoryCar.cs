﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCar : ICarDal
    {
        List<Car> _cars;
        public InMemoryCar()
        {
            _cars = new List<Car>
                        {
                    
                    new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2016,Description="Boyalı", DailyPrice=200000},

                    new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2024,Description="Kazasız", DailyPrice=200000},

                    new Car{Id=3,BrandId=1,ColorId=3,ModelYear=2002,Description="Ağır Kazalı", DailyPrice=200000},

                    new Car{Id=4,BrandId=2,ColorId=3,ModelYear=2012,Description="Hafif Kazalı", DailyPrice=200000},

                    new Car{Id=5,BrandId=2,ColorId=4,ModelYear=2020,Description="Tertemiz", DailyPrice=200000}
                        
                        };

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
           _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car _car = null;
            _car = _cars.SingleOrDefault(c => c.Id ==  car.Id);
            if(_car != null)
                _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
           return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(car => car.Id == id);
        }

        public void Update(Car car)
        {
            Car _car = null;
            _car = _cars.SingleOrDefault(c => c.Id == car.Id);
            if (_car != null)
                _car = car;
        }
    }
}
