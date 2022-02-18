using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using TRTv10.User_Interface;

namespace TRTv10
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            Application.Run(new FrmLogin());
        }

        /// <summary>
        ///     Resolving Assembly
        /// </summary>
        /// <param name="sender">Application</param>
        /// <param name="args">Resolving Assembly Name</param>
        /// <returns>Assembly</returns>
        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string assemblyFullName;

            AssemblyName assemblyName;

            const string primaveraFolder = "C:\\Program Files\\PRIMAVERA\\SG100\\Apl"; 

            assemblyName = new AssemblyName(args.Name);
            assemblyFullName =
                Path.Combine(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                        primaveraFolder), assemblyName.Name + ".dll");

            if (File.Exists(assemblyFullName))
                return Assembly.LoadFile(assemblyFullName);
            return null;
        }
    }
}