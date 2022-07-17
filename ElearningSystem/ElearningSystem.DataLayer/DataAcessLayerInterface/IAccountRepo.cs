using ElearningSystem.DataLayer.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningSystem.DataLayer.DataAcessLayerInterface
{
    public interface IAccountRepo
    {
        Task<IdentityResult> SignUpAdminAsync(RegisterModel registerModel);
        Task<IdentityResult> SignUpStudentAsync(RegisterModel registerModel);
        Task<IdentityResult> SignUpFacultyAsync(RegisterModel registerModel);
        Task<string> LoginStudentAsync(LogInModel logInModel);
        Task<string> LoginAdminAsync(LogInModel logInModel);
        Task<string> LoginFacultyAsync(LogInModel logInModel);
    }
}
