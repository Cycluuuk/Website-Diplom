using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();


        public IEnumerable<Car> Cars {

            get {
                return new List<Car>{

                    new Car {
                        name = "Цветное фото",
                        shortDesc = "Цветная печать",
                        longDesc = "кросиво и приятно",
                        img = "/img/cph.jpg",
                        price = 5,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                },
                    new Car
                    {
                        name = "Цветные плакаты",
                        shortDesc = "Цвет это яркос...",
                        longDesc = "Удобный в использование",
                        img = "/img/Cppr.jpg",
                        price = 5,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                },
                    new Car
                    {
                        name = "Цветная печать",
                        shortDesc = "Красиво и натурально",
                        longDesc = "Удобный в использование",
                        img = "/img/cpch.jpg",
                        price = 4,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                },
                    new Car
                    {
                        name = "Чб фото",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/BwPh.jpg",
                        price = 15000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                },
                    new Car
                    {
                        name = "Чб плакат",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/Bwpr.jpg",
                        price = 50000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                },
                    new Car
                    {
                        name = "Чб печать",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/Bwpср.jpg",
                        price = 50000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                },
                };
                }
        
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }

}
