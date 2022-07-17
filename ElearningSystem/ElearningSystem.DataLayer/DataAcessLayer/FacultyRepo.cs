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
    public class FacultyRepo : IFacultyRepo
    {
        private readonly ElearningContext _elearningContext;
        public FacultyRepo(ElearningContext elearningContext)
        {
            _elearningContext = elearningContext;
        }

        public List<FacultyModel> DeleteFaculty(int facultyId)
        {
            FacultyModel DeleteFaculty = _elearningContext.facultyModels.Where(x => x.FacultyId == facultyId).FirstOrDefault();
            _elearningContext.facultyModels.Remove(DeleteFaculty);
            _elearningContext.SaveChanges();

            List<FacultyModel> facultyModels = _elearningContext.facultyModels.ToList();
            return facultyModels;
        }
        public List<FacultyModel> DisplayFaculty()
        {
            List<FacultyModel> DisplayFacultyobject = _elearningContext.facultyModels.ToList();
            return (DisplayFacultyobject);
        }
    }
}