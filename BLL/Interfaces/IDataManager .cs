using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IDataManager
    {
        IDoctorRepository Doctors { get; }
        IPatientRepository Patients { get; }
        ISpecializationRepository Specializations { get; }
        IVisitRepository Visits { get; }
        IVisitResultRepository VisitResults { get; }
    }
}
