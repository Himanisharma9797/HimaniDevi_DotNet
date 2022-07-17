using ElearningSystem.BusinessLayer.InterfaceBL;
using ElearningSystem.DataLayer.DataAcessLayerInterface;
using ElearningSystem.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningSystem.BusinessLayer.BL
{
    public class StudentBusinessLayer : IStudentBusinessLayer
    {
        private readonly IStudentRepo  _studentRepo;
        public StudentBusinessLayer(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }
        public List<StudentModel> DeleteStudent(int studentId)
        {
            return _studentRepo.DeleteStudent(studentId);
        }
        public List<StudentModel> DisplayStudent()
        {
            return _studentRepo.DisplayStudent();
        }
    }   
}
