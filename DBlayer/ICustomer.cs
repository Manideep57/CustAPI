using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace DBlayer
{
    public interface ICustomer
    {
        public List<CustomerModel> GetCustomerByID(int iCustomerId);
    }
}
