using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iit.crossplateforme.Domain
{
    public class Patient
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }
		public string Name { get; set; }

		public string FamilyName { get; set; }

		public string HealthCare { get; set; }

		public int TelNumber { get; set; }


	}
}
