using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CarInsurance.Models
{
    public class Insuree : IValidatableObject
    {
        public int Id { get; set; }

        [Required, StringLength(50), Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required, StringLength(50), Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Required, EmailAddress, Display(Name = "Email Address")]
        public string EmailAddress { get; set; } = string.Empty;

        [Required, DataType(DataType.Date), Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required, Range(1900, 2100), Display(Name = "Car Year")]
        public int CarYear { get; set; }

        [Required, StringLength(50), Display(Name = "Car Make")]
        public string CarMake { get; set; } = string.Empty;

        [Required, StringLength(50), Display(Name = "Car Model")]
        public string CarModel { get; set; } = string.Empty;

        public bool DUI { get; set; }

        [Range(0, 100), Display(Name = "Speeding Tickets")]
        public int SpeedingTickets { get; set; }
        [Required, StringLength(50), Display(Name = "Coverage Type")]
        public string CoverageType { get; set; }

        [Precision(18, 2)]
        public decimal Quote { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            int maxYear = DateTime.Today.Year + 1;

            if (CarYear > maxYear)
            {
                yield return new ValidationResult(
                    $"Car year can't be later than {maxYear}.",
                    new[] { nameof(CarYear) });
            }
        }
    }
}