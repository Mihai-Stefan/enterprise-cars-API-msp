using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cardata_api_v3.Models;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cardata_api_v3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendEmailsController : ControllerBase
    {

        private readonly CarContext _context;

        public SendEmailsController(CarContext context)
        {
            _context = context;
            foreach (var item in context.Employees)
            {
                if(item.AssignedCar == null)
                {
                    string email = "mihaiste@gmail.com";
                    SendMessages.SendMail(item.FirstName + " " + item.LastName, email).Wait();
                }
            }
        }

        public void Get()
        {
            Response.Redirect("https://localhost:44391/admin");
        }


    }
}
