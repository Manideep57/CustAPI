using DBlayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Model;

namespace CustAPI.Model
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet("GetCustomerByID")]
        public List<CustomerModel> GetCustomerByID()
        {
            List<CustomerModel > lstcust = new List<CustomerModel>();
            CustomerDB obj1 = new CustomerDB();
            lstcust = obj1.GetCustomerByID(1);
            return lstcust;

        }
    }
}
