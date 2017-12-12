using System;
using WixSharp;

namespace FP.XmasSample2017.SampleSetup
{
    public class SimpleSample
    {
        public static void Create()
        {
            var project = new Project("XmaxProductSimple",
                new Dir(@"%ProgramFiles%\FP\XmaxProductSimple",
                    new File("..\\SampleApp\\bin\\Release\\SampleApp.exe"),
                    new File("..\\SampleApp\\bin\\Release\\SampleApp.exe.config")
                )
            );

            project.GUID = new Guid("6fe30b47-8989-43ad-9095-1861ba25889b");
            project.BuildMsi();
        }
        
    }
}
