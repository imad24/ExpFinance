using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ExpFinance
{
    class Messages
    {
        Messages()
        {
            
        }

        public static void Success(string msg)
        {
            MessageBox.Show(msg, "Opération réussie !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warning(string msg)
        {
            MessageBox.Show(msg, "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Error(string msg)
        {
            MessageBox.Show(msg, "Opération échouée !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Confirmation(string msg)
        {
           return MessageBox.Show(msg, "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public static void GeneralError()
        {
             Error("Une erreur est survenue. Merci de vérifier les entrées !");
        }

        public static void ShowKeyboard()
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles) +
                           @"\Microsoft Shared\ink\TabTip.exe";

                if (!File.Exists(path))
                {
                    // older windows versions
                    path = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\osk.exe";
                }

                Process.Start(path);
            }
            catch (Exception)
            {


            }
        }

        public static void ShowNumericKeyboard()
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles) + @"\Microsoft Shared\ink\TabTip.exe ";

                if (!File.Exists(path))
                {
                    // older windows versions
                    path = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\osk.exe";
                }

                Process.Start(path);
            }
            catch (Exception)
            {  
            }
        }
    }


}
