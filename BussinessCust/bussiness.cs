using DBlayer;
using Model;

namespace BussinessCust
{
    public class bussiness
    {
        public List<CustomerModel> GetCustomerByID(int iCustomerId)
        {
            CustomerDB obj = new CustomerDB();
            List<CustomerModel> lstCustmodel = new List<CustomerModel>();  
            lstCustmodel=obj.GetCustomerByID(iCustomerId);
            return lstCustmodel;


        }

    }
}
