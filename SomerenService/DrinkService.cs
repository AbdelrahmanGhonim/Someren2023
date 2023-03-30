using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            return drinksdb.GetAllDrinks();
        }

        public void  UpdateAmountInStock(Drink drinkAmoiunt)
        {
             drinksdb.UpdateAmountInStock(drinkAmoiunt);
             
        }

        public void DrinksSold(SalesDrinks salesDrinks)
        {
            try
            {
                drinksdb.AddSalesDrink(salesDrinks);
            }
            catch (SqlException ex)
            {

                throw;
            }

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
