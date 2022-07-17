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
    public class FacultyBusinessLayer : IFacultyBusinessLayer
    {
        private readonly IFacultyRepo _facultyRepo;
        public FacultyBusinessLayer(IFacultyRepo facultyRepo)
        {
            _facultyRepo = facultyRepo;
        }
        public List<FacultyModel> DeleteFaculty(int facultyId)
        {
            return _facultyRepo.DeleteFaculty(facultyId);
        }
        public List<FacultyModel> DisplayFaculty()
        {
            return _facultyRepo.DisplayFaculty();
        }
    }
}
