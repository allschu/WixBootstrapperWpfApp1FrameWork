using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WixSharp;
using WixSharp.Bootstrapper;

namespace WixBootstrapperWpfApp1FrameWork
{
    internal class Program
    {
        private static void Main()
        {
            string productMsi = BuildMsi();

            var bootstrapper =
                new Bundle("MyProduct",
                    new MsiPackage(productMsi)
                    {
                        Id = "MyProductPackageId",
                        DisplayInternalUI = true
                    });

            bootstrapper.Version = new Version("1.0.0.0");
            bootstrapper.UpgradeCode = new Guid("0779a1bc-b66e-4815-93df-8644d4a928d9");

            bootstrapper.Application = new ManagedBootstrapperApplication("%this%");

            bootstrapper.Build("MyProduct.exe");
        }

        private static string BuildMsi()
        {
            var project = new Project("MyProduct",
                new Dir(@"%ProgramFiles%\My Company\My Product",
                    new File(@"..\..\Program.cs")));

            project.GUID = new Guid("0779a1bc-b66e-4815-93df-8644d4a928d9");

            return project.BuildMsi();
        }
    }
}