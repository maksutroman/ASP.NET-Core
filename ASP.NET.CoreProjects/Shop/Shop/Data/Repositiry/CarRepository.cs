﻿using FirstProjectASP.NET.Core.Shop.Data.Interfaces;
using FirstProjectASP.NET.Core.Shop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repositiry
{
    public class CarRepository : IAllCars
    {

        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);
        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getOjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.id == carId);
      

    }
}
