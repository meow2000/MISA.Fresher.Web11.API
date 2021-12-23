using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Fresher.Web11.API.Model;


namespace MISA.Fresher.Web11.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpPost]

        public Customer GetName (Customer customer)
        {
            return customer;
        }
    }
}
