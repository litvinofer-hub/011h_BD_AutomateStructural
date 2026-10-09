using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using Application = Autodesk.AutoCAD.ApplicationServices.Application;

[assembly: CommandClass(typeof(Structural_Automation.AutoCadCommands.Commands))]

namespace Structural_Automation.AutoCadCommands;

public class Commands
{
    [CommandMethod("SA_HELLO")]
    public void Hello()
    {
        var doc = Application.DocumentManager.MdiActiveDocument;
        doc?.Editor.WriteMessage("\nAutoCadCommands loaded.");
    }
}
