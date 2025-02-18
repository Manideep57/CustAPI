using DBlayer;
using Model;

namespace BussinessCust
{
    public class bussiness
    {
        public List<CustomerModel> GetCustomerByID(int iCustomerId)
        {
            CustomerDB obj = new CustomerDB();
            List<CustomerModel> lstCustmodels = new List<CustomerModel>();  
            lstCustmodels=obj.GetCustomerByID(iCustomerId);
            return lstCustmodels;


        }

    }
}
