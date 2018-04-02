using Safa.SchoolManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safa.SchoolManager.Domain.RepositoryInterfaces
{
    public interface IProgramRepository
    {
        bool AddProgram(Program program);
        bool UpdateProgram(Program program);
        bool DeleteProgram(Program program);
        bool AddCours(Cours cours);
        bool UpdateCours(Cours cours);
        bool DeleteCours(Cours cours);
        Program GetProgramByID(int id);
        List<Cours> GetCoursOfProgram(int programId);
    }
}
