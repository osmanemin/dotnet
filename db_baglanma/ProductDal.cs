using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace db_baglanma
{
    public class ProductDal
    {

        MySqlConnection _connection =  new MySqlConnection(@"server=localhost;port=3306;database=deneme;user=root;password=root123;");


        public void ConnectionControl(){
        if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Product product){
            ConnectionControl();
            MySqlCommand command = new MySqlCommand("Insert into Product (Name,UnitPrice,StockAmount) values(@name,@unitPrice,@stockAmount)",_connection);
            command.Parameters.AddWithValue("@name",product.Name);
            command.Parameters.AddWithValue("@unitPrice",product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount",product.StockAmount);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Product product, int id){
            ConnectionControl();
            MySqlCommand command = new MySqlCommand("Update Product set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id",_connection);
            command.Parameters.AddWithValue("@id",id);
            command.Parameters.AddWithValue("@name",product.Name);
            command.Parameters.AddWithValue("@unitPrice",product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount",product.StockAmount);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(int id){
            ConnectionControl();
            MySqlCommand command = new MySqlCommand("Delete from Product where Id=@id",_connection);
            command.Parameters.AddWithValue("@id",id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public List<Product> GetAll(){
            
            ConnectionControl();
            MySqlCommand command = new MySqlCommand("Select * from Product",_connection);

            MySqlDataReader reader = command.ExecuteReader(); 

            List<Product> products = new List<Product>();

            while(reader.Read()){
                Product product = new Product{
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }
            
            reader.Close();
            _connection.Close();
            return products;

        }

        public DataTable GetAll2(){
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            MySqlCommand command = new MySqlCommand("Select * from new_table",_connection);

            MySqlDataReader reader = command.ExecuteReader(); 

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;

        }

        
        public void GetMySqlConnection(){
        
            using (_connection)
            {
                try
                {
                    _connection.Open();
                    Console.WriteLine("Bağlantı Sağlandı");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally{
                    _connection.Close();
                }
            }
        }


        public void GetSqlConnection(){
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=SSPI;";
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Bağlantı Sağlandı");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally{
                    connection.Close();
                }
            }
        }}
}
