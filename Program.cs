using System;
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
            AssemblyName assemblyName = new AssemblyName(args.Name);

            if (args.Name.StartsWith("Interop") || args.Name.StartsWith("ADODB"))
            {
                string strFolderProgFiles;
                string PRIMAVERA_COMMON_FILES_FOLDER = "PRIMAVERA\\SG100";

                strFolderProgFiles = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles);
                assemblyFullName = System.IO.Path.Combine(System.IO.Path.Combine(strFolderProgFiles, PRIMAVERA_COMMON_FILES_FOLDER), assemblyName.Name + ".dll");

                if (System.IO.File.Exists(assemblyFullName))
                {
                    return Assembly.LoadFile(assemblyFullName);
                }

                strFolderProgFiles = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86);
                assemblyFullName = System.IO.Path.Combine(System.IO.Path.Combine(strFolderProgFiles, PRIMAVERA_COMMON_FILES_FOLDER), assemblyName.Name + ".dll");

                if (System.IO.File.Exists(assemblyFullName))
                {
                    return Assembly.LoadFile(assemblyFullName);
                }
            }
            else
            {
                string erpPATH = "C:\\Program Files\\PRIMAVERA\\SG100\\Apl";

                //string erpPATH = GetInstalledApplicationPath();

                if (!string.IsNullOrEmpty(erpPATH))
                {
                    assemblyFullName = System.IO.Path.Combine(erpPATH, assemblyName.Name + ".dll");

                    if (System.IO.File.Exists(assemblyFullName))
                    {
                        return Assembly.LoadFile(assemblyFullName);
                    }
                }

            }

            //File not Found
            return null;

        }
    }
}