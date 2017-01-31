using System;
using System.Diagnostics;
using System.IO;

namespace ExpFinance
{
    static class ErrorLog
    {
        public static void LogError(string txt, Exception ex = null)
        {
            try
            {
                string path = Path.GetTempPath();
                var appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                if (string.IsNullOrEmpty(path)) return;

                path += $@"\{appName} - ErrorLog.txt";

                if (ex != null) while (ex.InnerException != null) ex = ex.InnerException;
                using (var sw = File.AppendText(path))
                {
                    var infos = new string[5];

                    infos[0] = Environment.UserName;
                    infos[1] = DateTime.Now.ToString("G");
                    infos[2] = txt;
                    infos[3] = ex?.Message;
                    infos[4] = ex?.InnerException?.Message;

                    var logLine = string.Join("\t", infos);

                    sw.WriteLine(logLine);
                }
            }
            catch (Exception)
            {

                return;
            }

        }

        public static void LogMessage(string txt)
        {
            try
            {
                string path = Path.GetTempPath();
                var appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                if (string.IsNullOrEmpty(path)) return;

                path += $@"\{appName} - MessagesLog.txt";

                using (var sw = File.AppendText(path))
                {
                    var infos = new string[5];

                    infos[0] = Environment.UserName;
                    infos[1] = DateTime.Now.ToString("G");
                    infos[2] = txt;

                    var logLine = string.Join("\t", infos);

                    sw.WriteLine(logLine);
                }
            }
            catch (Exception)
            {

                return;
            }

        }

        public static void LogOperation(string txt)
        {
            try
            {
                string path = Path.GetTempPath();
                var appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                if (string.IsNullOrEmpty(path)) return;

                path += $@"\{appName} - OperationLog.txt";

                using (var sw = File.AppendText(path))
                {
                    var infos = new string[5];

                    infos[0] = Environment.UserName;
                    infos[1] = DateTime.Now.ToString("G");
                    infos[2] = txt;

                    var logLine = string.Join("\t", infos);

                    sw.WriteLine(logLine);
                }
            }
            catch (Exception)
            {

                return;
            }

        }


        public static void ShowErrorReport()
        {
            try
            {
                string path = Path.GetTempPath();
                var appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                path += $@"\{appName} - ErrorLog.txt";
                var updateProcess = new ProcessStartInfo(path);
                Process.Start(updateProcess);
            }
            catch (Exception ex)
            {
                Messages.Warning("Impossible d'afficher le rapport d'erreur:\n -" + ex.Message);
            }
        }
    }
}

