using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using ExpFinance.DetailsFactureDataSetTableAdapters;
using ExpFinance.Properties;
using Microsoft.Reporting.WinForms;
using ReportParameter = Microsoft.Reporting.WinForms.ReportParameter;

namespace ExpFinance
{
    public partial class DetailsFactureForm : Form
    {
        private readonly string _entite, _codeClient;
        readonly decimal _numFacture;

        public DetailsFactureForm(string ent, string codeCli, decimal numFact)
        {
            InitializeComponent();
            _entite = ent;
            _codeClient = codeCli;
            _numFacture = numFact;
        }

        private void DetailsFactureForm_Load(object sender, EventArgs e)
        {
            LoadServerReport();
        }
        
        private void LoadReport()
        {
            try
            {
              
                
                var parameters = new[]
            {
                new ReportParameter("entite", _entite), 
                new ReportParameter("codeClient", _codeClient),
                new ReportParameter("numFacture", _numFacture.ToString(CultureInfo.InvariantCulture))
            };
                reportViewer.ProcessingMode = ProcessingMode.Local;
          

                reportViewer.ZoomMode = ZoomMode.PageWidth;
                reportViewer.LocalReport.SetParameters(parameters);
                reportViewer.RefreshReport(); 
            }
            catch (Exception)
            {
                
                Messages.Error("Vérifier la connexion avec le serveur !");
                Close();
            }
        }

        private void LoadServerReport()
        {
            try
            {
                var parameters = new[]
            {
                new ReportParameter("entite", _entite),
                new ReportParameter("codeClient", _codeClient),
                new ReportParameter("numFacture", _numFacture.ToString(CultureInfo.InvariantCulture))
            };

                reportViewer.ProcessingMode = ProcessingMode.Remote;
                var uri = new Uri(Settings.Default.reportServerURL);
                reportViewer.ServerReport.ReportServerUrl = uri;

                // Get a reference to the default credentials
                ICredentials credentials = CredentialCache.DefaultCredentials;

                // Get a reference to the report server credentials
                var rsCredentials = reportViewer.ServerReport.ReportServerCredentials;

                // Set the credentials for the server report
                rsCredentials.NetworkCredentials = credentials;


                //I'm really sorry for doing this but i had to :'( :'( :'( 
                //may god forgive me
                rsCredentials.NetworkCredentials = new NetworkCredential("erpadmin", "Heavy.all2016@", "GHP");

                reportViewer.ServerReport.ReportPath = Settings.Default.reportDetailsFacture;
                reportViewer.ShowCredentialPrompts = true;
                reportViewer.ServerReport.SetParameters(parameters);


                reportViewer.ZoomMode = ZoomMode.PageWidth;
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                Messages.Error("Vérifier la connexion avec le serveur !");
                ErrorLog.LogError("Vérifier la connexion avec le serveur !",ex);
                Close();
            }
        }
    }
}
