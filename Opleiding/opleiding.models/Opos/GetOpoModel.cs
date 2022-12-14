using opleiding.models.Docent;
using opleiding.models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace opleiding.models.Opos;

public class GetOpoModel:BaseOpoModel
{
    public Guid OpoId { get; set; }
    public string OpoVerantwoordelijke { get; set; }
    public int AantalStudenten { get; set; }
    public List<GetOpoModel> Opo { get; set; }
    public List<string> Docenten { get; set; }
    public ICollection<BaseStudentModel> GetStudentenModel { get; set; }
   
}
