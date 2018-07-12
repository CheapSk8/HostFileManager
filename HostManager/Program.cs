using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace HostManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EmbeddedAssembly.Load("HostManager.Resources.IPAddressControlLib.dll", "IPAddressControlLib.dll");
            EmbeddedAssembly.Load("HostManager.Resources.TransparentImage.dll", "TransparentImage.dll");
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.ExportLocation))
            {
                Properties.Settings.Default.ExportLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHostFileManager());
        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
