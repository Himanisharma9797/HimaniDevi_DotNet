using ElearningSystem.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningSystem.DataLayer.DataAcessLayerInterface
{
    public interface IFacultyRepo
    {
        List<FacultyModel> DisplayFaculty();
        List<FacultyModel> DeleteFaculty(int facultyId);
    }
}
