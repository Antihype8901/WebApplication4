using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.interfaces;
using WebApplication4.Models;

namespace WebApplication4.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category>{
                    new Category { categoryName = "электромобиьи", desc = "современный вид транспорта" },
                    new Category { categoryName = "Классические автомобили", desc = "машины с двигателем внутреннего сгорания" } 
                };
            } 
                
        }
    }
}
