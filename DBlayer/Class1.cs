using System.Data;
using Microsoft.Data.SqlClient;
using Model;

namespace DBlayer
{
    public class CustomerDB:ICustomer
    {
        public List<CustomerModel> GetCustomer()
        {
            List<CustomerModel> lstCustmodels = new List<CustomerModel>();
            string strconnection = "Data Source=PC;Initial Catalog=mani;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection obj1 = new SqlConnection();
            obj1.ConnectionString = strconnection;
            obj1.Open();
            Console.WriteLine("1, 2,3");
            string strCommand = "Select * from Customer";
            SqlCommand cmd = new SqlCommand(strCommand, obj1);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CustomerModel model = new CustomerModel();
                    model.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                    model.CustomerName = Convert.ToString(reader["CustomerName"]);
                    model.ContactName = Convert.ToString(reader["ContactName"]);
                    model.Address = Convert.ToString(reader["Address"]);
                    model.City = Convert.ToString(reader["City"]);
                    model.Postalcode = Convert.ToString(reader["Postalcode"]);
                    model.Country = Convert.ToString(reader["Country"]);
                    lstCustmodels.Add(model);



                    //Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},", reader["CustomerID"], reader["CustomerName"], reader["ContactName"], reader["Address"], reader["City"], reader["Postalcode"], reader["Country"]);
                }
            }
            return lstCustmodels;
        }

        public List<CustomerModel> GetCustomerByID(int iCustomerId)
        {
            List<CustomerModel> lstCustmodels = new List<CustomerModel>();
            string strconnection = "Data Source=PC;Initial Catalog=mani;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection obj1 = new SqlConnection();
            obj1.ConnectionString = strconnection;
            obj1.Open();
            Console.WriteLine("1, 2,3");
            string strCommand = "SPGetAllCustomer";
            SqlCommand cmd = new SqlCommand(strCommand, obj1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerID", 1);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CustomerModel model = new CustomerModel();
                    model.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                    model.CustomerName = Convert.ToString(reader["CustomerName"]);
                    model.ContactName = Convert.ToString(reader["ContactName"]);
                    model.Address = Convert.ToString(reader["Address"]);
                    model.City = Convert.ToString(reader["City"]);
                    model.Postalcode = Convert.ToString(reader["Postalcode"]);
                    model.Country = Convert.ToString(reader["Country"]);
                    lstCustmodels.Add(model);



                    //Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},", reader["CustomerID"], reader["CustomerName"], reader["ContactName"], reader["Address"], reader["City"], reader["Postalcode"], reader["Country"]);
                }
            }
            return lstCustmodels;
        }
    }
    
}
