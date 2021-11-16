namespace ImageToIcon
{
    using System;
    using System.Windows.Forms;

    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            //Ini.SetFile(Path.ChangeExtension(PathEx.LocalPath, ".ini"));
            //Log.AllowLogging(Ini.FilePath);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}