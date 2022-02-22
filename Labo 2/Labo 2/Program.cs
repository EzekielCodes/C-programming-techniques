using Labo_2.LogicLayer;

namespace Labo_2;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        IStudentController _student = new StudentController();
        IOpoController _opo = new OpoController();    
        IDocentController _docent = new DocentController();
        ApplicationConfiguration.Initialize();
        Application.Run(new Overzicht(_student,_opo,_docent));
    }
}