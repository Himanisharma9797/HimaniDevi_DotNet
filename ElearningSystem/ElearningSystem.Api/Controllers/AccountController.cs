using ElearningSystem.BusinessLayer.InterfaceBL;
using ElearningSystem.DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ElearningSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountBusinessLayer _accountBusinessLayer;
        public AccountController(IAccountBusinessLayer accountBusinessLayer)
        {
            _accountBusinessLayer = accountBusinessLayer;
        }
        [HttpPost("signupAdmin")]
        public async Task<IActionResult> SignUpAdmin([FromBody] RegisterModel registerModel)
        {
            var result = await _accountBusinessLayer.SignUpAdminAsync(registerModel);
            if (result.Succeeded)
            {
                return Ok("True");
            }
            return Unauthorized();
        }
        [HttpPost("signupstudent")]
        public async Task<IActionResult> SignUpStudent([FromBody] RegisterModel registerModel)
        {
            var result = await _accountBusinessLayer.SignUpStudentAsync(registerModel);
            if (result.Succeeded)
            {
                return Ok("True");
            }
            return Unauthorized();
        }
        [HttpPost("signupFaculty")]
        public async Task<IActionResult> SignUpFaculty([FromBody] RegisterModel registerModel)
        {
            var result = await _accountBusinessLayer.SignUpFacultyAsync(registerModel);
            if (result.Succeeded)
            {
                return Ok("True");
            }
            return Unauthorized();
        }
        [HttpPost("logInStudent")]
        public async Task<IActionResult> LogInStudent([FromBody] LogInModel logInModel)
        {
            var result = await _accountBusinessLayer.LoginStudentAsync(logInModel);
            if (string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }
            return Ok(result);
        }
        [HttpPost("logInAdmin")]
        public async Task<IActionResult> LogInAdmin([FromBody] LogInModel logInModel)
        {
            var result = await _accountBusinessLayer.LoginAdminAsync(logInModel);
            if (string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }
            return Ok(result);
        }
        [HttpPost("logInFaculty")]
        public async Task<IActionResult> LogInFaculty([FromBody] LogInModel logInModel)
        {
            var result = await _accountBusinessLayer.LoginFacultytAsync(logInModel);
            if (string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }
            return Ok(result);
        }
    }
}
