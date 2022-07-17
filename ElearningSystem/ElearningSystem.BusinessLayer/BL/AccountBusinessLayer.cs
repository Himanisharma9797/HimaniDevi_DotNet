using ElearningSystem.BusinessLayer.InterfaceBL;
using ElearningSystem.DataLayer.DataAcessLayerInterface;
using ElearningSystem.DataLayer.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningSystem.BusinessLayer.BL
{
    public class AccountBusinessLayer : IAccountBusinessLayer
    {
        private readonly IAccountRepo _accountRepo;
        public AccountBusinessLayer(IAccountRepo accountRepo)
        {
            this._accountRepo = accountRepo;
        }
        public Task<string> LoginAdminAsync(LogInModel logInModel)
        {
            return _accountRepo.LoginAdminAsync(logInModel);
        }
        public Task<string> LoginFacultytAsync(LogInModel logInModel)
        {
            return _accountRepo.LoginFacultyAsync(logInModel);
        }
        public Task<string> LoginStudentAsync(LogInModel logInModel)
        {
            return _accountRepo.LoginStudentAsync(logInModel);
        }
        public Task<IdentityResult> SignUpAdminAsync(RegisterModel registerModel)
        {
            return _accountRepo.SignUpAdminAsync(registerModel);
        }
        public Task<IdentityResult> SignUpFacultyAsync(RegisterModel registerModel)
        {
            return _accountRepo.SignUpFacultyAsync(registerModel);
        }
        public Task<IdentityResult> SignUpStudentAsync(RegisterModel registerModel)
        {
            {
                return _accountRepo.SignUpStudentAsync(registerModel);
            }
        }
    }
}
