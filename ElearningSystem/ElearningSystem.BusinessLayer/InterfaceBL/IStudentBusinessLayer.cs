using ElearningSystem.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningSystem.BusinessLayer.InterfaceBL
{
   public interface IStudentBusinessLayer
    {
        List<StudentModel> DisplayStudent();
        List<StudentModel> DeleteStudent(int studentId);
    }
}
