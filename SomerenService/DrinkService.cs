using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinksDAO drinksdb;

        public DrinkService()
        {
            drinksdb = new DrinksDAO();
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = drinksdb.GetAllDrinks();
            return drinks;
        }

        public void UpdateDrink(Drink drink)
        {
            drinksdb.UpdateDrink(drink);
        }

        public void AddDrink(Drink drink)
        {
            drinksdb.AddDrink(drink);
        }
        
        public void DeleteDrink(Drink drink)
        {
            drinksdb.DeleteDrink(drink);
        }
    }
}
