using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder theCreatedName = new StringBuilder(255);

            ScanWorksAPI.sw_connect();

            short ret = ScanWorksAPI.sw_ImportProjectTo("C:\\ScanWorks\\Examples\\Scanlite2ExampleProject.zip", 255, theCreatedName, "SL_importedFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", string.Empty);

            ScanWorksAPI.sw_disconnect();
        }
    }

    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    public class ScanWorksAPI
    {
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_connect();
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_disconnect();
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_GetProjectCount();
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_GetProjectNameAt(int counter, StringBuilder theName);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_LoadProject(string projectName);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_LoadProjectAt(int counter);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_GetDesignCount();
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_GetDesignNameAt(int counter, StringBuilder theName);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_LoadDesign(string designName);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_LoadDesignAt(int counter);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_GetActionCount();
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_GetActionNameAt(int counter, StringBuilder theName);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_LoadAction(string actionName);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_LoadActionAt(int counter);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_RunAction();
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_DiagnoseAction();
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_GetSequenceCount();
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_GetSequenceNameAt(int counter, StringBuilder theName);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_LoadSequenceAt(int counter);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_RunSequence();
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_GetSequenceReportFile(StringBuilder theReportFileName);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_GetSequenceSummaryReport(StringBuilder ReportTitle, StringBuilder theReportFileName);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_GetReportFileNameCount();
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_GetReportFileNameAt(int counter, StringBuilder theReportName, StringBuilder theReportTitle);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_GetErrorMessage(StringBuilder errorText);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_connectWithController(String controllerString);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern int sw_SetUserTCK(int clockFreq);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern short sw_SetUserTCKMode(int tckMode);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern short sw_ImportProjectTo(string theFileName, int theProjectNameSize, StringBuilder theCreatedName, string theUseProjectName, string theTargetDir);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern short sw_DeleteProject(string theProjectName);
        [DllImport("ScanWorksCOMServer.DLL", CharSet = CharSet.Ansi)]
        public static extern short sw_BSTCommands(string theCommand);
        public ScanWorksAPI()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}
