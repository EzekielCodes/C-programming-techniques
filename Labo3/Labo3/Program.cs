using Labo3.DataLayer;

namespace Labo3;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        IModel data = new Model();
        ILogic logic = new Logic(data);
        ApplicationConfiguration.Initialize();
        Application.Run(new Overzicht(logic));
    }
}