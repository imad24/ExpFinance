using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpFinance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //authentificate

            if (!Authentif())
            {
                Messages.Error("Vous n'êtes pas autorisé à utiliser l'application. Merci de contacter votre administrateur.");
                return;
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static bool Authentif()
        {
            try
            {
                using (var model = new ExpFinanceEntities())
                {
                    return (from u in model.AF_UTILISATEUR
                            where u.Username == Environment.UserDomainName + @"\" + Environment.UserName
                            select u).Any();

                }
            }
            catch (Exception)
            {
                Messages.Error("La connexion à la base de données a échoué. vérifier votre connexion réseau ou contactez votre administrateur");
                return false;
            }

        }
    }
}
