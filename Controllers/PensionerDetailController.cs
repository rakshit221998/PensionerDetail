using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PensionerDetailApi.Model;
using PensionerDetailApi.Repository.IRepository;
using PensionerDetailApi.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PensionerDetailApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PensionerDetailController : ControllerBase
    {
        private IPensionerService pensionerservice;

        public PensionerDetailController(IPensionerService pensionerservice)
        {
            this.pensionerservice = pensionerservice;
        }

        [HttpGet("{aadhar}")]
        public IActionResult PensionerDetailByAadhar(string aadhar)
        {
           
            PensionerDetail pensioner = pensionerservice.PensionerDetailByAdhaarService(aadhar);
            if (pensioner == null)
                return NotFound("No user found for this Adhaar no!!");
            return Ok(pensioner);
        }

    }
}
