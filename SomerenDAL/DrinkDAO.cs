using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

        public void AddSalesDrink(SalesDrinks salesDrinks)
        {
            string query = ("INSERT INTO SalesDrinks (StudentId, drinkName) VALUES (@StudentId, @drinkName);");
            SqlParameter[] sqlParameters = {
            new SqlParameter("@StudentId", salesDrinks.StudentId),
            new SqlParameter("@drinkName", salesDrinks.DrinksName),
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateAmountInStock(Drink drink)
        {

            //using (SqlConnection connection = new SqlConnection()) 
            //{
            //   conn.Open();

            string query = "UPDATE [Drinks] SET AmountInStock=@AmountInStock WHERE Name=@Name";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@AmountInStock", drink.Amount),
                new SqlParameter("@Name", drink.Name)
            };
            ExecuteEditQuery(query, sqlParameters);

            //                int nrOfRowsAffected = command.ExecuteNonQuery();
            //}
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

        public void UpdateDrink(Drink drink)
        {
            conn.Open();
            SqlCommand command = new SqlCommand(
                "UPDATE Drinks SET Price = @Price, AmountInStock = @Amount, IsAlcoholic = @IsAlcoholic WHERE Name = @Name", conn);


            // Preventing SQL injections
            command.Parameters.AddWithValue("@Price", drink.Price);
            command.Parameters.AddWithValue("@Amount", drink.Amount);
            command.Parameters.AddWithValue("@IsAlcoholic", drink.IsAlcoholic);
            command.Parameters.AddWithValue("@Name", drink.Name);

            int nrOfRowsAffected = command.ExecuteNonQuery(); // checking if anything was updated
            conn.Close();

            if (nrOfRowsAffected == 0)
                throw new Exception("Drink was not updated!");
        }

        public void AddDrink(Drink drink)
        {
            conn.Open();
            SqlCommand command = new SqlCommand(
                "INSERT INTO Drinks (Name, Price, AmountInStock, IsAlcoholic) VALUES (@Name, @Price, @Amount, @IsAlcoholic); SELECT SCOPE_IDENTITY();", conn);

            command.Parameters.AddWithValue("@Name", drink.Name);
            command.Parameters.AddWithValue("@Price", drink.Price);
            command.Parameters.AddWithValue("@Amount", drink.Amount);
            command.Parameters.AddWithValue("@IsAlcoholic", drink.IsAlcoholic);

            int nrOfRowsAffected = command.ExecuteNonQuery(); // checking if anything was added
            conn.Close();

            if (nrOfRowsAffected == 0)
                throw new Exception("Drink was not added!");
        }

        public void DeleteDrink(Drink drink)
        {
            conn.Open();
            SqlCommand command = new SqlCommand(
                "DELETE FROM Drinks WHERE Name = @Name", conn);

            command.Parameters.AddWithValue("@Name", drink.Name);

            int nrOfRowsAffected = command.ExecuteNonQuery(); // checking if anything was added
            conn.Close();

            if (nrOfRowsAffected == 0)
                throw new Exception("Drink was not removed!");
        } 

    }
}