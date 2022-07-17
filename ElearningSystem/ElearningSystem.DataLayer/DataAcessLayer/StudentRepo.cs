using ElearningSystem.DataLayer.Context;
using ElearningSystem.DataLayer.DataAcessLayerInterface;
using ElearningSystem.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningSystem.DataLayer.DataAcessLayer
{
    public class StudentRepo : IStudentRepo
    {
        private readonly ElearningContext _elearningContext;
        public StudentRepo(ElearningContext elearningContext)
        {
            _elearningContext = elearningContext;
        }
        public List<StudentModel> DeleteStudent(int studentId)
        {
            StudentModel DeleteStudent = _elearningContext.StudentModels.Where(x => x.StudentId == studentId).FirstOrDefault();
            _elearningContext.StudentModels.Remove(DeleteStudent);
            _elearningContext.SaveChanges();
            List<StudentModel> studentModels = _elearningContext.StudentModels.ToList();
            return studentModels;
        }
        public List<StudentModel> DisplayStudent()
        {
            List<StudentModel> DisplayStudentobject = _elearningContext.StudentModels.ToList();
            return (DisplayStudentobject);
        }
    }
}
