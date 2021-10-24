using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecureCoreAPI.Data;

namespace SecureCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailsController : ControllerBase
    {
        private readonly IEmployeeInfo employeeRepo;
        public EmployeeDetailsController(IEmployeeInfo employeeInfo)
        {
            this.employeeRepo = employeeInfo;
        }

        [Authorize]
        [HttpGet]
        public ActionResult GetEmployeeDetails()
        {
            var data = this.employeeRepo.GetEmployeeDetails();
            return Ok(data);
        }

    }
}