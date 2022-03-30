using System.Collections.Generic;
using System.Linq;
using iit.crossplateforme.Domain;

namespace iit.crossplateforme.Data
{
    public class PatientRepository: IDataRepository<Patient>
	{
		private readonly PatientContext _patientContext;

        public PatientRepository(PatientContext context)
        {
			_patientContext = context;
        }
		public IList<Patient> GetAll()
		{
			
			return _patientContext.Patients.ToList();
		}

		public Patient Get(long id)
		{
			
			return _patientContext.Patients.FirstOrDefault(v=> id.Equals(v.Id));
		}

		public void Add(Patient entity)
		{
			_patientContext.Patients.Add(entity);
			_patientContext.SaveChanges();

		}
	}
}
