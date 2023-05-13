using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.interfaces;
using WebApplication4.Models;

namespace WebApplication4.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car> { 
                    new Car{name = "BMW",shortDesc = "Стильный, мощный", longDesc="Изысканная элегантность в каждой детали.",img="/img/12.jpg",price=45000,isFavourite = true,available = true,Category = _categoryCars.AllCategories.First()},
                    new Car{name = "Tesla",shortDesc = "Инновационный, экологичный", longDesc="Электрическая мощь без выбросов.",img="/img/12.jpg",price=45000,isFavourite = true,available = true,Category = _categoryCars.AllCategories.First()},
                    new Car{name = "Mercedes-Benz",shortDesc = "Роскошный, надежный", longDesc="Изысканность и непревзойденное качество объединены.",img="/img/12.jpg",price=45000,isFavourite = true,available = true,Category = _categoryCars.AllCategories.First()},
                    new Car{name = "Audi",shortDesc = "Современный, динамичный", longDesc="Превосходство инженерии, элегантность в движении.",img="/img/12.jpg",price=45000,isFavourite = true,available = true,Category = _categoryCars.AllCategories.First()},
                    new Car{name = "Lamborghini",shortDesc = "Экстремальный, стильный", longDesc="Сверхскорость и роскошь воплощены вместе.",img="/img/foto-passat-2020_00.jpg",price=45000,isFavourite = true,available = true,Category = _categoryCars.AllCategories.First()},
                    new Car{name = "Ford",shortDesc = "Надежный, мощный", longDesc="Инновации для активного образа жизни.",img="/img/foto-passat-2020_00.jpg",price=45000,isFavourite = true,available = true,Category = _categoryCars.AllCategories.First()},
                    new Car{name = "Porsche",shortDesc = "Спортивный, элегантный", longDesc="Безупречная эстетика, скорость безгранична.",img="/img/foto-passat-2020_00.jpg",price=45000,isFavourite = true,available = true,Category = _categoryCars.AllCategories.First()},
                    new Car{name = "Volkswagen",shortDesc = "Компактный, надежный", longDesc="Комфорт и качество для каждого.",img="/img/bmw.jpg",price=45000,isFavourite = true,available = true,Category = _categoryCars.AllCategories.First()},
                    new Car{name = "Ferrari",shortDesc = "Стремительный, роскошный", longDesc="Итальянская страсть на асфальте.",img="/img/bmw.jpg",price=45000,isFavourite = true,available = true,Category = _categoryCars.AllCategories.First()},
                    new Car{name = "Jaguar",shortDesc = "Грациозный, элегантный", longDesc="Роскошь, сочетающая в себе стиль и мощь.",img="/img/La.jpg",price=45000,isFavourite = true,available = true,Category = _categoryCars.AllCategories.First()},
                };
            }
        }
        public IEnumerable<Car> getFavCars { get ; set ; }

        public Car getObjectCar(int carid)
        {
            throw new NotImplementedException();
        }
    }
}
