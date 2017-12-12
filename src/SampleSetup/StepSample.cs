using System;
using WixSharp;
using WixSharp.Forms;

namespace FP.XmasSample2017.SampleSetup
{
    public class StepSample
    {
        public static void Create()
        {

            var project = new ManagedProject("XmaxProductStep",
                new Dir(@"%ProgramFiles%\FP\XmaxProductStep",
                    new File("dat1.txt"),
                    new File("dat2.txt")
                )
            );

            project.GUID = new Guid("1F23815A-B892-4A25-9BCB-F23F59306631");

            project.ManagedUI = new ManagedUI();

            project.ManagedUI.InstallDialogs.Add(Dialogs.Welcome)
                .Add(Dialogs.Licence)
                .Add(Dialogs.SetupType)
                .Add(Dialogs.Features)
                .Add(Dialogs.InstallDir)
                .Add(Dialogs.Progress)
                .Add(Dialogs.Exit);

            project.ManagedUI.ModifyDialogs.Add(Dialogs.MaintenanceType)
                .Add(Dialogs.Features)
                .Add(Dialogs.Progress)
                .Add(Dialogs.Exit);

            project.BuildMsi();
        }
    }
}
