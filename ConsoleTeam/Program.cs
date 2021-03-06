﻿#define Bibek

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Common;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.TestManagement.Client;
using System.Data;

namespace ConsoleTeam
{
    class Program
    {
        static void Main(string[] args)
        {

            Uri CollectionUri = (args.Length < 1) ? new Uri("http://desktop-anh3ro7:8080/tfs/DefaultCollection/") : new Uri(args[0]);
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);
            WorkItemStore wis = tpc.GetService<WorkItemStore>();  // To get work items service
            ITestManagementTeamProject tm = tpc.GetService<ITestManagementService>().GetTeamProject("TechBrothers");
            #region fetch test plan and test case

            TFS1 obj = new TFS1();
            obj.GetAllWorkItem();
            Console.Read();


            #region powershell Help

            //private static void RunPowershellScript2(string scriptFile, List<string> parameters)
            //{
            //    // Validate parameters
            //    if (string.IsNullOrEmpty(scriptFile)) { throw new ArgumentNullException("scriptFile"); }
            //    if (parameters == null) { throw new ArgumentNullException("parameters"); }
            //    RunspaceConfiguration runspaceConfiguration = RunspaceConfiguration.Create();
            //    using (Runspace runspace = RunspaceFactory.CreateRunspace(runspaceConfiguration))
            //    {
            //        runspace.Open();
            //        RunspaceInvoke scriptInvoker = new RunspaceInvoke(runspace);
            //        scriptInvoker.Invoke("Set-ExecutionPolicy Unrestricted");
            //        Pipeline pipeline = runspace.CreatePipeline();
            //        Command scriptCommand = new Command(scriptFile);
            //        Collection<CommandParameter> commandParameters = new Collection<CommandParameter>();
            //        foreach (string scriptParameter in parameters)
            //        {
            //            CommandParameter commandParm = new CommandParameter(null, scriptParameter);
            //            commandParameters.Add(commandParm);
            //            scriptCommand.Parameters.Add(commandParm);
            //        }
            //        pipeline.Commands.Add(scriptCommand);
            //        Collection<PSObject> psObjects;
            //        psObjects = pipeline.Invoke();
            //    }
            //}


            /*
                 * open powershell in admin mode and set the below command
                 * Set-ExecutionPolicy RemoteSigned -Scope CurrentUser
                 * */


            //public static string RunPowershellScript()
            //{
            //    ProcessStartInfo startInfo = new ProcessStartInfo();
            //    startInfo.FileName = @"powershell.exe";
            //    //provide powershell script full path
            //    //            startInfo.Arguments = @"& 'C:\ps\1.ps1'";
            //    startInfo.Arguments = @"& 'C:\ps\ex.ps1'";

            //    startInfo.RedirectStandardOutput = true;
            //    startInfo.RedirectStandardError = true;
            //    startInfo.UseShellExecute = false;
            //    startInfo.CreateNoWindow = true;
            //    Process process = new Process();
            //    process.StartInfo = startInfo;
            //    // execute script call start process
            //    process.Start();
            //    // get output information
            //    string output = process.StandardOutput.ReadToEnd();


            //    // catch error information
            //    string errors = process.StandardError.ReadToEnd();
            //    return output + "  " + errors;
            //}
            #endregion  


            //for getting groups

            //static void getgroup()
            //{
            //    using (SqlConnection cc = new SqlConnection("server=.;database=SyncDBServer;integrated security=true"))
            //    {
            //        using (SqlCommand cmd = new SqlCommand("select * from tbl_group", cc))
            //        {
            //            DataTable dt = new DataTable();
            //            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //            adp.Fill(dt);

            //            var groupedData = from b in dt.AsEnumerable()
            //                              group b by b.Field<string>("runbyname") into g
            //                              let list = g.ToList()
            //                              select new
            //                              {
            //                                  ChargeTag = g.Key,
            //                                  Count = list.Count,

            //                                  Billable = g.Where(row => row.Field<string>("outcome") == "passed").Count()

            //                              };




            //            foreach (var a in groupedData)
            //            {
            //                Console.WriteLine(a.ChargeTag + "  " + a.Count + "   " + a.Billable);
            //            }
            //            Console.Read();

            //        }
            //    }
            //}



            //DataTable dt = new DataTable();
            //dt = null; // dt contain some value
            //DataTable uniqueContacts = dt.AsEnumerable()
            //               .GroupBy(x => x.Field<string>("name"))
            //               .Select(g => g.First()).CopyToDataTable();





            //ITestPlanCollection plans = tm.TestPlans.Query("Select * From TestPlan");
            //foreach (ITestPlan tp in plans)
            //{
            //    Console.WriteLine(tp.Name +"-" +"TestPan");
            //    GetAllTestCasesInTestPlan(tm, tp, true);
            //}



            //var tstService = (ITestManagementService)tpc.GetService(typeof(ITestManagementService));
            //var tProject = tstService.GetTeamProject(tm.TeamProjectName);

            //var myTestSuite = tProject.TestSuites.Find(4);
            //Console.WriteLine("-----------------------------------");
            //foreach (var obj in myTestSuite.TestCases)
            //{

            //    Console.WriteLine(obj.Title.ToString()+"-     Suite id is="+obj.Id);

            //}
            //Console.WriteLine("-----------------------------------");



            //Console.Read();

            #endregion





            #region ConnectTFS
            //      Uri tfsUri = (args.Length < 1) ?
            //         new Uri("http://desktop-anh3ro7:8080/tfs") : new Uri(args[0]);

            //      TfsConfigurationServer configurationServer =
            //          TfsConfigurationServerFactory.GetConfigurationServer(tfsUri);

            //      // Get the catalog of team project collections
            //      ReadOnlyCollection<CatalogNode> collectionNodes = configurationServer.CatalogNode.QueryChildren(
            //          new[] { CatalogResourceTypes.ProjectCollection },
            //          false, CatalogQueryOptions.None);

            //      // List the team project collections
            //      foreach (CatalogNode collectionNode in collectionNodes)
            //      {
            //          // Use the InstanceId property to get the team project collection
            //          Guid collectionId = new Guid(collectionNode.Resource.Properties["InstanceId"]);
            //          TfsTeamProjectCollection teamProjectCollection = configurationServer.GetTeamProjectCollection(collectionId);

            //          // Print the name of the team project collection
            //          Console.WriteLine("Collection: " + teamProjectCollection.Name);

            //          // Get a catalog of team projects for the collection
            //          ReadOnlyCollection<CatalogNode> projectNodes = collectionNode.QueryChildren(
            //              new[] { CatalogResourceTypes.TeamProject },
            //              false, CatalogQueryOptions.None);

            //          // List the team projects in the collection
            //          foreach (CatalogNode projectNode in projectNodes)
            //          {
            //              Console.WriteLine(" Team Project: " + projectNode.Resource.DisplayName);
            //          }

            //          Console.Read();

            //      }


            //      TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(
            //new Uri("http://localhost:8080/tfs/"));
            //      WorkItemStore workItemStore = (WorkItemStore)tpc.GetService(typeof(WorkItemStore));

            //      // Run a query.
            //      WorkItemCollection queryResults = workItemStore.Query(
            //         "Select [State], [Title] " +
            //         "From WorkItems " +
            //         "Order By [State] Asc, [Changed Date] Desc");

            //      // Run a saved query.  cc
            //      //Add somethig
            //      QueryHierarchy queryRoot = workItemStore.Projects[0].QueryHierarchy;
            //      QueryFolder folder = (QueryFolder)queryRoot["Shared Queries"];
            //      QueryDefinition query = (QueryDefinition)folder["My Work items"];
            //      queryResults = workItemStore.Query(query.QueryText);
            #endregion


            NamedParameterCollection(b: 10);
            Console.Read();

          
        }





        public static void NamedParameterCollection(int a=40,int b=1)
        {
            Console.WriteLine(string.Format("Vale of a is {0} and b is {1}", a, b));
        }

        public static List<TestCase> GetAllTestCasesInTestPlan(ITestManagementTeamProject testManagementTeamProject, ITestPlan testPlan, bool initializeTestCaseStatus = true)
        {
            testPlan.Refresh();
            List<TestCase> testCasesList;
            testCasesList = new List<TestCase>();
            string fullQuery =
                String.Format("SELECT [System.Id], [System.Title] FROM WorkItems WHERE [System.WorkItemType] = 'Test Case' AND [Team Project] = '{0}'", testManagementTeamProject.TeamProjectName);
            IEnumerable<ITestCase> allTestCases = testManagementTeamProject.TestCases.Query(fullQuery);
            foreach (var currentTestCase in allTestCases)
            {
                Console.WriteLine(currentTestCase.Title.ToString());
            }

            return testCasesList;
        }

      
    }

    [Serializable]
    public class TestCase 
    {
        [NonSerialized]
        private TeamFoundationIdentityName teamFoundationIdentityName;
        private int id;
        private string title;
        private string area;
        private string createdBy;
        private DateTime dateCreated;
        private DateTime dateModified;
         protected bool isInitialized;

        public string OwnerDisplayName { get; set; }

        public Guid TeamFoundationId { get; set; }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
               
                this.title = value;
               
            }
        }

        public DateTime DateCreated
        {
            get
            {
                return this.dateCreated;
            }

            set
            {
                this.dateCreated = value;
               
            }
        }

        public string CreatedBy
        {
            get
            {
                return this.createdBy;
            }

            set
            {
                this.createdBy = value;
                
            }
        }

        public DateTime DateModified
        {
            get
            {
                return this.dateModified;
            }

            set
            {
                this.dateModified = value;
              
            }
        }

        public string Area
        {
            get
            {
                return this.area;
            }

            set
            {
               
                this.area = value;
               
            }
        }

        public TeamFoundationIdentityName TeamFoundationIdentityName
        {
            get
            {
                return this.teamFoundationIdentityName;
            }

            set
            {
               
                this.teamFoundationIdentityName = value;
               
            }
        }

        
    }
}
