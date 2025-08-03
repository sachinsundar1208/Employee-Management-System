using System.ComponentModel.DataAnnotations;

namespace EmployeeMaintain.Models
{
    public class Employee : IValidatableObject
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Department { get; set; }
        public DateTime DateofJoining { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Designation { get; set; }

        public int Salary { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Designation == "Intern" && (Salary < 5000 || Salary > 10000))
            {
                yield return new ValidationResult(
                    "Salary for Interns must be between 5000 and 10000.",
                    new[] { nameof(Salary) });
            }

            if (Designation == "Developer" && (Salary < 20000 || Salary > 40000))
            {
                yield return new ValidationResult(
                    "Salary for Developers must be between 20000 and 40000.",
                    new[] { nameof(Salary) });
            }

            if (Designation == "Manager" && (Salary < 60000 || Salary > 80000))
            {
                yield return new ValidationResult(
                    "Salary for Managers must be between 60000 and 80000.",
                    new[] { nameof(Salary) });
            }
        }


    }
  
}
