using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ShoeCollectionLocalDB
{
    public static class ShoeDB
    {
        public static List<Shoe> GetAllShoes()
        {
            List<Shoe> shoeList = new List<Shoe>();
            SQLiteConnection connection = DBConnection.GetConnection();
            string selectString = "SELECT Brand, Model, Colorway, Size FROM Shoes ORDER BY Brand ASC, Model ASC, Colorway ASC, Size ASC;";
            SQLiteCommand selectCommand = new SQLiteCommand(selectString, connection);

            try
            {
                connection.Open();
                SQLiteDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Shoe tempShoe = new Shoe
                    {
                        Brand = reader["Brand"].ToString(),
                        Model = reader["Model"].ToString(),
                        Colorway = reader["Colorway"].ToString(),
                        Size = (double)reader["Size"],
                    };

                    shoeList.Add(tempShoe);
                }

                if(reader != null)
                {
                    reader.Dispose();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                connection.Close();
                GC.Collect();
            }

            return shoeList;
        }

        public static Shoe GetShoe(string brand, string model, string colorway, double size)
        {
            Shoe tempShoe = null;

            SQLiteConnection connection = DBConnection.GetConnection();
            string selectString = "SELECT Brand, Model, Colorway, Size FROM Shoes WHERE Brand=@brand AND Model=@model AND Colorway=@colorway AND Size=@size";
            SQLiteCommand selectCommand = new SQLiteCommand(selectString, connection);
            selectCommand.Parameters.Add(new SQLiteParameter("@brand", brand));
            selectCommand.Parameters.Add(new SQLiteParameter("@model", model));
            selectCommand.Parameters.Add(new SQLiteParameter("@colorway", colorway));
            selectCommand.Parameters.Add(new SQLiteParameter("@size", size));

            try
            {
                connection.Open();
                SQLiteDataReader reader = selectCommand.ExecuteReader();

                // If the grader is found, stores all information about the grader into an object
                if (reader.Read())
                {
                    tempShoe = new Shoe
                    {
                        Brand = reader["Brand"].ToString(),
                        Model = reader["Model"].ToString(),
                        Colorway = reader["Colorway"].ToString(),
                        Size = (double)reader["Size"],
                    };
                }

                if (reader != null)
                {
                    reader.Dispose();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                connection.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            return tempShoe;

        }

        public static void AddShoe(Shoe tempShoe)
        {
            SQLiteConnection connection = DBConnection.GetConnection();
            string insertString = @"INSERT INTO Shoes (Brand, Model, Colorway, Size)" +
                                  "VALUES (@brand, @model, @colorway, @size)";
            SQLiteCommand insertCommand = new SQLiteCommand(insertString, connection);

            insertCommand.Parameters.AddWithValue("@brand", tempShoe.Brand);
            insertCommand.Parameters.AddWithValue("@model", tempShoe.Model);
            insertCommand.Parameters.AddWithValue("@colorway", tempShoe.Colorway);
            insertCommand.Parameters.AddWithValue("@size", tempShoe.Size);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();

                if (insertCommand != null)
                {
                    insertCommand.Dispose();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                connection.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public static void DeleteShoe(Shoe tempShoe)
        {
            SQLiteConnection connection = DBConnection.GetConnection();
            string deleteString = "DELETE FROM Shoes WHERE Brand=@brand AND Model=@model AND Colorway=@colorway AND Size=@size";
            SQLiteCommand deleteCommand = new SQLiteCommand(deleteString, connection);
            deleteCommand.Parameters.Add("@brand", System.Data.DbType.AnsiString).Value = tempShoe.Brand;
            deleteCommand.Parameters.Add("@model", System.Data.DbType.AnsiString).Value = tempShoe.Model;
            deleteCommand.Parameters.Add("@colorway", System.Data.DbType.AnsiString).Value = tempShoe.Colorway;
            deleteCommand.Parameters.Add("@size", System.Data.DbType.Double).Value = tempShoe.Size;

            try
            {
                // Executes the query 
                connection.Open();
                deleteCommand.ExecuteNonQuery();

                if (deleteCommand != null)
                {
                    deleteCommand.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}
