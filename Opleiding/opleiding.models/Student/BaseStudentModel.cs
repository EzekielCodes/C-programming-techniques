using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opleiding.models.Student;

public  class BaseStudentModel
{
    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(45, MinimumLength = 3)]
    [Required]
    public string StudentenNummer { get; set; }
    [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
    [StringLength(45, MinimumLength = 3)]
    [Required]
    public string Familienaam { get; set; }
    [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
    [StringLength(45, MinimumLength = 3)]
    [Required]
    public string Voornaam { get; set; }
}
