using ElearningSystem.DataLayer.Context;
using ElearningSystem.DataLayer.DataAcessLayerInterface;
using ElearningSystem.DataLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ElearningSystem.DataLayer.DataAcessLayer
{
    public class AccountRepo : IAccountRepo
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly ElearningContext _elearningContext;

        public AccountRepo(UserManager<ApplicationUser> userManager
            , SignInManager<ApplicationUser> signInManager,
            ElearningContext elearningContext,
            RoleManager<IdentityRole> roleManager,
             IConfiguration Configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _configuration = Configuration;
            _elearningContext = elearningContext;
        }
        public async Task<string> LoginAdminAsync(LogInModel logInModel)
        {

            var user = await _userManager.FindByEmailAsync(logInModel.Email);
            bool presenceOfAdmin = false;
            var presenceOfAdmins = _elearningContext.adminModels.Where(x => x.AdminEmail == logInModel.Email);
            if (presenceOfAdmins.Count() != 0)
            {
                presenceOfAdmin = true;
            }
            if (presenceOfAdmin == true)
            {
                var result = await _signInManager.PasswordSignInAsync(logInModel.Email, logInModel.Password, false, false);
                if (!result.Succeeded)
                {
                    return null;
                }
                var userRoles = await _userManager.GetRolesAsync(user);
                var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, logInModel.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }
                var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(1),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                    );

                return new JwtSecurityTokenHandler().WriteToken(token);
            }

            else
            {
                return "";
            }
        }
        public async Task<string> LoginFacultyAsync(LogInModel logInModel)
        {
            var user = await _userManager.FindByEmailAsync(logInModel.Email);
            bool presenceOfFaculty = false;
            var presenceOfFacultys = _elearningContext.facultyModels.Where(x => x.FacultyEmail == logInModel.Email);
            if (presenceOfFacultys.Count() != 0)
            {
                presenceOfFaculty = true;
            }
            if (presenceOfFaculty == true)
            {
                var result = await _signInManager.PasswordSignInAsync(logInModel.Email, logInModel.Password, false, false);
                if (!result.Succeeded)
                {
                    return null;
                }
                var userRoles = await _userManager.GetRolesAsync(user);
                var authClaims = new List<Claim>
                {
                new Claim(ClaimTypes.Name, logInModel.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };
                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }
                var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(1),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                    );

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            else
            {
                return "";
            }
        }
        public async Task<string> LoginStudentAsync(LogInModel logInModel)
        {
            var user = await _userManager.FindByEmailAsync(logInModel.Email);
            bool presenceOfStudent = false;
            var presenceOfStudents = _elearningContext.StudentModels.Where(x => x.StudentEmail == logInModel.Email);
            if (presenceOfStudents.Count() != 0)
            {
                presenceOfStudent = true;
            }
            if (presenceOfStudent == true)
            {
                var result = await _signInManager.PasswordSignInAsync(logInModel.Email, logInModel.Password, false, false);
                if (!result.Succeeded)
                {
                    return null;
                }
                var userRoles = await _userManager.GetRolesAsync(user);
                var authClaims = new List<Claim>
                {
                new Claim(ClaimTypes.Name, logInModel.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };
                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }
                var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(1),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                    );

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            else
            {
                return "";
            }
        }
        public async Task<IdentityResult> SignUpAdminAsync(RegisterModel registerModel)
        {
            var user = new ApplicationUser()
            {
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                Email = registerModel.Email,
                UserName = registerModel.Email
            };
            var admin = new AdminModel()
            {
                AdminFirstName = user.FirstName,
                AdminLastName = user.LastName,
                AdminEmail = user.Email

            };
            _elearningContext.Add(admin);
            var result = await _userManager.CreateAsync(user, registerModel.Password);
            if (!await _roleManager.RoleExistsAsync(Roles.Admin))
                await _roleManager.CreateAsync(new IdentityRole(Roles.Admin));
            if (!await _roleManager.RoleExistsAsync(Roles.Admin))
                await _roleManager.CreateAsync(new IdentityRole(Roles.Admin));
            if (await _roleManager.RoleExistsAsync(Roles.Admin))
            {
                await _userManager.AddToRoleAsync(user, Roles.Admin);
            }

            return result;
        }
        public async Task<IdentityResult> SignUpFacultyAsync(RegisterModel registerModel)
        {
            var user = new ApplicationUser()
            {
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                Email = registerModel.Email,
                UserName = registerModel.Email
            };
            var faculty = new FacultyModel()
            {
                FacultyFirstName= user.FirstName,
                FacultyLastName = user.LastName,
                FacultyEmail = user.Email

            };
            _elearningContext.Add(faculty);
            var result = await _userManager.CreateAsync(user, registerModel.Password);
            if (!await _roleManager.RoleExistsAsync(Roles.Faculty))
                await _roleManager.CreateAsync(new IdentityRole(Roles.Faculty));
            if (!await _roleManager.RoleExistsAsync(Roles.Faculty))
                await _roleManager.CreateAsync(new IdentityRole(Roles.Faculty));
            if (await _roleManager.RoleExistsAsync(Roles.Faculty))
            {
                await _userManager.AddToRoleAsync(user, Roles.Faculty);
            }

            return result;
        }
        public async Task<IdentityResult> SignUpStudentAsync(RegisterModel registerModel)
        {
            var user = new ApplicationUser()
            {
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                Email = registerModel.Email,
                UserName = registerModel.Email
            };
            var student = new StudentModel()
            {
                StudentFirstName = user.FirstName,
                StudentLastName = user.LastName,
                StudentEmail = user.Email
                
            };
            _elearningContext.Add(student);

            var result = await _userManager.CreateAsync(user, registerModel.Password);
            if (!await _roleManager.RoleExistsAsync(Roles.Student))
                await _roleManager.CreateAsync(new IdentityRole(Roles.Student));
            if (!await _roleManager.RoleExistsAsync(Roles.Student))
                await _roleManager.CreateAsync(new IdentityRole(Roles.Student));
            if (await _roleManager.RoleExistsAsync(Roles.Student))
            {
                await _userManager.AddToRoleAsync(user, Roles.Student);

            }
            return result;
        }
    }
    }


    
