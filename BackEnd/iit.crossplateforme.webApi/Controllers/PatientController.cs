using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using iit.crossplateforme.Domain;

namespace iit.crossplateforme.webApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PatientController : ControllerBase
	{
		private readonly ILogger<PatientController> _logger;
		private readonly IDataRepository<Patient> _patientRepository;

		public PatientController(ILogger<PatientController> logger, IDataRepository<Patient> patientRepository)
		{
			_logger = logger;
			_patientRepository = patientRepository;
		}

		[HttpGet]
		public IEnumerable<Patient> Get()
		{
			_logger.Log(LogLevel.Trace, "Get all patients");
			return _patientRepository.GetAll();

		}
	}
}
