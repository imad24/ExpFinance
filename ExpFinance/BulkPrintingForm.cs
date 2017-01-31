using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Drawing.Printing;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpFinance.Properties;
using Microsoft.Reporting.WinForms;

namespace ExpFinance
{
    public partial class BulkPrintingForm : Form
    {
        private ReportViewer _reportViewer;
        private int _numAvoir;
        private string _codeClient, _montant,_printerName;
        private BulkPrintingViewModel _viewModel;
        private decimal _progress;
        public BulkPrintingForm()
        {
            InitializeComponent();

            _viewModel = new BulkPrintingViewModel();
            numericTo.Maximum = _viewModel.GetLastAvoir();
            numericFrom.Maximum = _viewModel.GetLastAvoir();
        }

        private void BulkPrintingForm_Load(object sender, EventArgs e)
        {
            //LoadServerReport();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (printingWorker.IsBusy) return;
            ErrorLog.LogMessage("lunching printing version 2.5.3");
            printingWorker.RunWorkerAsync();


        }

        private void printingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
            ErrorLog.LogMessage("Begin Printing Work...");

            var reportViewer = new ReportViewer { ProcessingMode = ProcessingMode.Remote };
            var uri = new Uri(Settings.Default.reportServerURL);
            reportViewer.ServerReport.ReportServerUrl = uri;


          ErrorLog.LogMessage($"Server registred {Settings.Default.reportServerURL}");

                // Get a reference to the default credentials
                ICredentials credentials = CredentialCache.DefaultCredentials;

            // Get a reference to the report server credentials
            var rsCredentials = reportViewer.ServerReport.ReportServerCredentials;

            // Set the credentials for the server report
            rsCredentials.NetworkCredentials = credentials;


            //I'm really sorry for doing this but i had to :'( :'( :'(
            //may god forgive me
            rsCredentials.NetworkCredentials = new NetworkCredential("erpadmin", "Heavy.all2016@", "GHP");
            reportViewer.ZoomMode = ZoomMode.PageWidth;


            var from = (int)numericFrom.Value;
            var to = (int)numericTo.Value;

            var documents = new PrintDocument[1000];
            var i = 0;
                ErrorLog.LogMessage($"Begin Rendering");
                for (var avoir = from; avoir <= to; avoir++)
            {

                switch (_viewModel.GetTypeAvoir(avoir))
                {
                    case 0:
                        reportViewer.ServerReport.ReportPath = "/ExpFinance/AvoirFinancier";
                        break;

                    case 1:
                        reportViewer.ServerReport.ReportPath = "/ExpFinance/AvoirFinancier_libre";
                        break;
                    case 2:
                        reportViewer.ServerReport.ReportPath = "/ExpFinance/AvoirFinancier_ant";
                        break;
                    case 3:
                        reportViewer.ServerReport.ReportPath = "/ExpFinance/AvoirFinancier_EF";
                        break;
                }

                    ErrorLog.LogMessage($"Printing From {reportViewer.ServerReport.ReportPath}");
                    _numAvoir = avoir;
                _codeClient = _viewModel.GetCodeClient(avoir);
                _montant = _viewModel.GetAvoirFinancier(avoir).montant.ToString("N2");


                if(string.IsNullOrEmpty(_codeClient)) continue;
                var parameters = new[]
            {
                    new ReportParameter("client", _codeClient),
                    new ReportParameter("numAvoir", _numAvoir.ToString()),

               // new ReportParameter("montant", _montant)
            };

                //_reportViewer.ShowCredentialPrompts = true;
                reportViewer.ServerReport.SetParameters(parameters);
                reportViewer.RefreshReport();

                var printabledocument = new ReportPrintDocument(reportViewer.ServerReport)
                {
                    PrinterSettings =
                    {
                        FromPage = 1,
                        ToPage = 1,
                        MinimumPage = 1,
                        MaximumPage = 1
                    }
                };

                documents[i] = printabledocument;
                var progress = (decimal)(avoir - from + 1) / (decimal)(to - from + 1) *100;
                printingWorker.ReportProgress((int)progress);
                i++;
            }

            ErrorLog.LogMessage("All pages done");
                var printingDocuments = new MultiPrintDocument(documents)
                {
                    PrinterSettings = {Copies = (short) numericCopies.Value}
                };


                //set printing settings
            if (string.IsNullOrEmpty(_printerName))
            {
                var printerDialog = new PrintDialog();
                var result = printerDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _printerName = printerDialog.PrinterSettings.PrinterName;
                    printingDocuments.PrinterSettings.PrinterName = _printerName;
                }
            }
            else
            {
                printingDocuments.PrinterSettings.PrinterName = _printerName;
            }

                ErrorLog.LogMessage("Begin Printing");

                printingDocuments.Print();
            }
            catch (Exception ex)
            {

                Messages.Error("Une erreur s'est produite !");
                ErrorLog.LogError($"Impression de {Settings.Default.reportServerURL}", ex);
            }

        }

        private void printingWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void printingWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ErrorLog.LogMessage("Work done.");
        }


        #region Unused
        private void LoadServerReport()
        {
            try
            {
                _reportViewer.ProcessingMode = ProcessingMode.Remote;
                var uri = new Uri(Settings.Default.reportServerURL);
                _reportViewer.ServerReport.ReportServerUrl = uri;

                // Get a reference to the default credentials
                ICredentials credentials = CredentialCache.DefaultCredentials;

                // Get a reference to the report server credentials
                var rsCredentials = _reportViewer.ServerReport.ReportServerCredentials;

                // Set the credentials for the server report
                rsCredentials.NetworkCredentials = credentials;


                //I'm really sorry for doing this but i had to :'( :'( :'(
                //may god forgive me
                rsCredentials.NetworkCredentials = new NetworkCredential("erpadmin", "Heavy.all2016@", "GHP");

            }
            catch (Exception ex)
            {
                Messages.Error("Vérifier la connexion avec le serveur !");
                ErrorLog.LogError("Vérifier la connexion avec le serveur !",ex);
                Close();
            }
        }

        private void BulkPrintPrepare()
        {
            //try
            //{
            var reportViewer = new ReportViewer { ProcessingMode = ProcessingMode.Remote };
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


            var from = (int)numericFrom.Value;
            var to = (int)numericTo.Value;

            var documents = new PrintDocument[1000];
            var i = 0;
            for (var avoir = from; avoir <= to; avoir++)
            {

                switch (_viewModel.GetTypeAvoir(avoir))
                {
                    case 0:
                        _reportViewer.ServerReport.ReportPath = "/ExpFinance/test/AvoirFinancier";
                        break;

                    case 1:
                    case 3:
                        _reportViewer.ServerReport.ReportPath = "/ExpFinance/test/AvoirFinancier_libre";
                        break;

                    case 2:
                        _reportViewer.ServerReport.ReportPath = "/ExpFinance/test/AvoirFinancier_ant";
                        break;
                }
                _numAvoir = avoir;
                _codeClient = _viewModel.GetCodeClient(avoir);
                _montant = _viewModel.GetAvoirFinancier(avoir).montant.ToString("N2");

                var parameters = new[]
            {
                new ReportParameter("numAvoir", _numAvoir.ToString()),
                new ReportParameter("client", _codeClient),
               // new ReportParameter("montant", _montant)
            };

                //_reportViewer.ShowCredentialPrompts = true;
                reportViewer.ServerReport.SetParameters(parameters);
                reportViewer.ZoomMode = ZoomMode.PageWidth;
                reportViewer.RefreshReport();

                ReportPrintDocument printabledocument = new ReportPrintDocument(reportViewer.ServerReport);

                documents[i] = printabledocument;
                var progress = ((avoir - from + 1) / (to - from + 1)) * 100;
                printingWorker.ReportProgress(progress);
                i++;
            }

            var printingDocuments = new MultiPrintDocument(documents);
            printingDocuments.Print();
            //}
            //catch (Exception)
            //{

            //    Messages.Error("Erreur");
            //    Close();
            //}

        }

        private void SetReportInfo(int numAvoir)
        {
            //try
            //{

            switch (_viewModel.GetTypeAvoir(numAvoir))
            {
                case 0:
                    _reportViewer.ServerReport.ReportPath = "/ExpFinance/test/AvoirFinancier";
                    break;

                case 1:
                case 3:
                    _reportViewer.ServerReport.ReportPath = "/ExpFinance/test/AvoirFinancier_libre";
                    break;

                case 2:
                    _reportViewer.ServerReport.ReportPath = "/ExpFinance/test/AvoirFinancier_ant";
                    break;
            }
            _numAvoir = numAvoir;
            _codeClient = _viewModel.GetCodeClient(numAvoir);
            _montant = _viewModel.GetAvoirFinancier(numAvoir).montant.ToString("N2");

            var parameters = new[]
        {
                new ReportParameter("numAvoir", _numAvoir.ToString()),
                new ReportParameter("client", _codeClient),
               // new ReportParameter("montant", _montant)
            };

            //_reportViewer.ShowCredentialPrompts = true;
            _reportViewer.ServerReport.SetParameters(parameters);
            _reportViewer.ZoomMode = ZoomMode.PageWidth;
            _reportViewer.RefreshReport();
            //}
            //catch (Exception)
            //{
            //    Messages.Error("Vérifier la connexion avec le serveur !");
            //    Close();
            //}
        }

        #endregion
    }
}
