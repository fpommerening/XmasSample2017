using System;
using WixSharp;

namespace FP.XmasSample2017.SampleSetup
{
    public class FeatureSample
    {
        public static void Create()
        {
            var featue1 = new Feature("Opt1", true, false);
            var featue2 = new Feature("Opt2", true, true);


            var project = new ManagedProject("XmaxProductFeature",
                new Dir(@"%ProgramFiles%\FP\XmaxProductFeature",
                    new File(featue1, "dat1.txt"),
                    new File(featue2, "dat2.txt")
                )
            );

            project.GUID = new Guid("6fe30b47-2333-43ad-9095-1861ba25889b");

           
            project.ManagedUI = ManagedUI.Default;

            project.BuildMsi();
        }
    }
}
