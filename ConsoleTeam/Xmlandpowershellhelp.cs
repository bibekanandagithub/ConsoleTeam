using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTeam
{
    class Xmlandpowershellhelp
    {
        #region for XML Update
        //    var path = System.IO.Path.GetDirectoryName(
        //System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\" + "ReportCreator" + "\\" + "configtestcount.xml";

        //    XmlDocument xdoc = new XmlDocument();
        //    xdoc.Load(path);

        //        XmlNodeList _fnames = xdoc.GetElementsByTagName("type");
        //    XmlNodeList _lnames = xdoc.GetElementsByTagName("value");
        //    XmlNodeList _email = xdoc.GetElementsByTagName("emailto");
        //    XmlNodeList _isendmail = xdoc.GetElementsByTagName("sendmail");



        //    _fnames[0].InnerText = "abstraction type report";
        //        //<value> SuiteID:123456; Enviornment:117 </value>
        //        _lnames[0].InnerText = "SuiteID:" + textBox2.Text + " " + ";" + " Enviornment:" + textBox3.Text;
        //        _email[0].InnerText = textBox1.Text;
        //        string localPath = new Uri(path).LocalPath;
        //    xdoc.Save(localPath);
        #endregion

        #region XMLRead
        //   var path = System.IO.Path.GetDirectoryName(
        //System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\" + "ReportCreator" + "\\" + "configtestcount.xml";

        //   XmlDocument xdoc = new XmlDocument();
        //   xdoc.Load(path);

        //       XmlNodeList _fnames = xdoc.GetElementsByTagName("type");
        //   XmlNodeList _lnames = xdoc.GetElementsByTagName("value");
        //   XmlNodeList _email = xdoc.GetElementsByTagName("emailto");
        //   XmlNodeList _isendmail = xdoc.GetElementsByTagName("sendmail");
        //   string typeis = _fnames[0].InnerText;
        //   string valueis = _lnames[0].InnerText;
        //   string emailis = _email[0].InnerText;
        //   string ismailsend = _isendmail[0].InnerText;

        //MessageBox.Show(typeis);
        //MessageBox.Show(valueis);
        //MessageBox.Show(emailis);
        //MessageBox.Show(ismailsend);
        #endregion
        #region XMLFORMAT
        //        <?xml version = "1.0" encoding="utf-8" ?>
        //<configuration>
        //  <emailto>elnovio.amie @gmail.com</emailto>
        //  <sendmail>true</sendmail>
        //  <sections>
        //    <section>
        //      <type>abstraction type report</type>
        //      <value> SuiteID:123456; Enviornment:117 </value>
        //    </section>
        //  </sections>
        //</configuration>

        #endregion


        #region VBSFileExecute
        //Process scriptProc = new Process();
        //scriptProc.StartInfo.FileName = @"cscript";
        //        scriptProc.StartInfo.WorkingDirectory = @"c:\ps\";
        //        scriptProc.StartInfo.Arguments = "//B //Nologo a.vbs";
        //        scriptProc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; //prevents console window from popping out
        //        scriptProc.Start();
        //        scriptProc.WaitForExit(); //(Optional)
        //        scriptProc.Close();

        #endregion

        #region VBS CODE
        //set shell = WScript.CreateObject("WScript.shell")
        //shell.Run("c:\ps\test.bat"), 0 , True


        //Create a notepad file and store above text and save in test.vbs
        //it will execute batch file
        #endregion



    }
}













//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Collections.ObjectModel;
//using System.Management.Automation;
//using System.Management.Automation.Runspaces;
//using System.IO;
//using System.Threading;
//using System.Diagnostics;

//namespace WindowsFormsApp1
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }
//        BackgroundWorker m_oWorker;
//        private void Form1_Load(object sender, EventArgs e)
//        {
//            InitializeComponent();
//            //m_oWorker = new BackgroundWorker();

//            //// Create a background worker thread that ReportsProgress &
//            //// SupportsCancellation
//            //// Hook up the appropriate events.
//            //m_oWorker.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
//            //m_oWorker.ProgressChanged += new ProgressChangedEventHandler
//            //        (backgroundWorker1_ProgressChanged);
//            //m_oWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler
//            //        (backgroundWorker1_RunWorkerCompleted);
//            //m_oWorker.WorkerReportsProgress = true;
//            //m_oWorker.WorkerSupportsCancellation = true;
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            try
//            {

//                //  richTextBox1.Text = RunScript(textBox1.Text.Trim());
//                //ExecuteBatchFile();
//                //  List<string> test = new List<string>();
//                // test.Add("bibek");
//                //RunPowershellScript(@"c:\ps\1.ps1", test);
//                //  richTextBox1.Text=   RunPowershellScript();
//                //  RunPowershellScript2("c:\\ps\\1.ps1",test);

//                /*
//                 * open powershell in admin mode and set the below command
//                 * Set-ExecutionPolicy RemoteSigned -Scope CurrentUser
//                 * */

//                //   FormProgressViewer fpv = new FormProgressViewer();



//                // Kickoff the worker thread to begin it's DoWork function.
//                backgroundWorker1.WorkerReportsProgress = true;
//                backgroundWorker1.RunWorkerAsync();
//                Process scriptProc = new Process();
//                scriptProc.StartInfo.FileName = @"cscript";
//                scriptProc.StartInfo.WorkingDirectory = @"c:\ps\";
//                scriptProc.StartInfo.Arguments = "//B //Nologo a.vbs";
//                scriptProc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; //prevents console window from popping out
//                scriptProc.Start();
//                scriptProc.WaitForExit(); //(Optional)
//                scriptProc.Close();



//            }
//            catch (Exception error)
//            {
//                richTextBox1.Text += String.Format("\r\nError in script : {0}\r\n", error.Message);
//            }

//        }

//        private void simulateheavyjob()
//        {

//            Thread.Sleep(100);


//        }

//        public static string RunPowershellScript()
//        {
//            ProcessStartInfo startInfo = new ProcessStartInfo();
//            startInfo.FileName = @"powershell.exe";
//            //provide powershell script full path
//            //            startInfo.Arguments = @"& 'C:\ps\1.ps1'";
//            startInfo.Arguments = @"& 'C:\ps\ex.ps1'";

//            startInfo.RedirectStandardOutput = true;
//            startInfo.RedirectStandardError = true;
//            startInfo.UseShellExecute = false;
//            startInfo.CreateNoWindow = true;
//            Process process = new Process();
//            process.StartInfo = startInfo;
//            // execute script call start process
//            process.Start();
//            // get output information
//            string output = process.StandardOutput.ReadToEnd();


//            // catch error information
//            string errors = process.StandardError.ReadToEnd();
//            return output + "  " + errors;
//        }
//        private string RunScript(string scriptText)
//        {
//            // create Powershell runspace
//            Runspace runspace = RunspaceFactory.CreateRunspace();

//            // open it
//            runspace.Open();

//            // create a pipeline and feed it the script text
//            Pipeline pipeline = runspace.CreatePipeline();
//            pipeline.Commands.AddScript(scriptText);

//            // add an extra command to transform the script output objects into nicely formatted strings
//            // remove this line to get the actual objects that the script returns. For example, the script
//            // "Get-Process" returns a collection of System.Diagnostics.Process instances.
//            pipeline.Commands.Add("Out-String");

//            // execute the script
//            Collection<PSObject> results = pipeline.Invoke();

//            // close the runspace
//            runspace.Close();

//            // convert the script result into a single string
//            StringBuilder stringBuilder = new StringBuilder();
//            foreach (PSObject obj in results)
//            {
//                stringBuilder.AppendLine(obj.ToString());
//            }

//            return stringBuilder.ToString();
//        }

//        private void ExecuteBatchFile()
//        {
//            System.Security.SecureString pass = new System.Security.SecureString();
//            string strPass = "47758";
//            foreach (char c in strPass)
//            {
//                pass.AppendChar(c);
//            }
//            System.Diagnostics.Process.Start(@"C:\ps\test.bat", "vsdeveloper", pass, "WORKGROUP");

//        }


//        private BackgroundWorker worker = null;

//        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
//        {
//            for (int i = 0; i <= 100; i++)
//            {
//                //CHECK FOR CANCELLATION FIRST
//                if (backgroundWorker1.CancellationPending)
//                {
//                    //CANCEL
//                    e.Cancel = true;
//                }
//                else
//                {
//                    simulateheavyjob();
//                    backgroundWorker1.ReportProgress(i);
//                }
//            }
//        }

//        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
//        {
//            progressBar1.Value = e.ProgressPercentage;
//            lblDirectoryStatus.Text = "Processing......" + progressBar1.Value.ToString() + "%";
//        }

//        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
//        {
//            if (e.Cancelled)
//            {
//                display("You have Cancelled");
//                progressBar1.Value = 0;
//                lblDirectoryStatus.Text = "0";
//            }
//            else
//            {
//                display("Work completed successfully");
//            }

//            //Change the status of the buttons on the UI accordingly

//        }
//        private void display(String text)
//        {
//            MessageBox.Show(text);
//        }
//    }
//}











