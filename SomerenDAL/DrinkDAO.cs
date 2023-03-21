using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class DrinksDAO : BaseDao
    {
        public List<Drink> GetAllDrinks()  // getting data from database 
        {
            string query = "SELECT Name,Price,IsAlcoholic,AmountInStock FROM [Drinks] ORDER BY name ASC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable) // data from database into class
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    Name = dr["Name"].ToString(),
                    Price = (decimal)dr["Price"],
                    IsAlcoholic = dr["IsAlcoholic"].ToString(),
                    Amount = (int)dr["AmountInStock"],
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}