using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opleiding.models.Opos;

public class BaseOpoModel
{

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(6, MinimumLength = 3)]
    [Required]
    public string Code { get; set; }
    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(45, MinimumLength = 3)]
    [Required]
    public string Naam { get; set; }
    [Range(3, 12, ErrorMessage = "Waarde moet tussen {3} en {18} liggen")]
    public int Stp { get; set; }
    [Range(1, 3, ErrorMessage = "Waarde moet tussen {1} en {3} liggen")]
    public int Fase { get; set; }
    [Range(1, 2, ErrorMessage = "Waarde moet tussen {1} en {2} liggen")]
    public int Semester { get; set; }
}
