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
using Microsoft.TeamFoundation.VersionControl.Client;
using System.IO;

namespace ConsoleTeam
{
    class TFS1
    {
        Uri CollectionUri = new Uri("http://desktop-anh3ro7:8080/tfs/DefaultCollection/");

        public void GetAllWorkItem()
        {
            //Connect to the Team Foundation Server
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);
            WorkItemStore wis = tpc.GetService<WorkItemStore>();
            //query will execute and store into the work items
            Query wiq = new Query(wis, "Select * from WorkItems");
            //All the collection will store here
            WorkItemCollection wic = wiq.RunQuery();
            foreach (WorkItem wi in wic)
            {
                Console.WriteLine(wi.Title.ToString() + "---" + wi.Fields["Work Item Type"].Value.ToString());
            }

            Console.Read();

        }
        public void GetActiveWorkItem()
        {
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);
            WorkItemStore wis = tpc.GetService<WorkItemStore>();
            Query q = new Query(wis, "select * from WorkItem");
            WorkItemCollection wic = q.RunQuery();
            foreach (WorkItem wi in wic)
            {
                if (wi.State == "Active")
                {
                    Console.WriteLine(wi.Title.ToString() + "---" + wi.Fields["Work Item Type"].Value.ToString());
                }
            }
            Console.Read();
        }

        public void GetListofRequirement()
        {
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);
            WorkItemStore wis = tpc.GetService<WorkItemStore>();
            Query Q = new Query(wis, "Select * from WorkItem");
            WorkItemCollection wic = Q.RunQuery();
            foreach (WorkItem w in wic)
            {
                if (w.Fields["Work Item Type"].Value.ToString() == "Requirement")
                {
                    Console.WriteLine(w.Title.ToString());
                }
            }
        }
        //single work item by query
        public void GetSpecificworkitem(int WorkItemID)
        {
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);
            WorkItemStore wis = tpc.GetService<WorkItemStore>();
            WorkItemCollection wic = new Query(wis, "select * from WorkItem where ID='" + WorkItemID + "'").RunQuery();
            foreach (WorkItem wi in wic)
            {
                Console.WriteLine(wi.Title.ToString() + "---" + wi.Fields["Work Item Type"].Value.ToString());
            }
            Console.Read();
        }
        public void GetSpecificworkitemByClass(int WorkItemID)
        {
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);
            WorkItemStore wis = tpc.GetService<WorkItemStore>();
            WorkItemCollection wic = new Query(wis, "select * from WorkItem").RunQuery();
            WorkItem wi = wis.GetWorkItem(WorkItemID);
            Console.WriteLine(wi.Title + " " + wi.Type.Name.ToString() + "  " + "Area Path=" + wi.Fields["Area Path"].Value.ToString());

        }
        public void GetAllTestPlan()
        {
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);
            ITestManagementTeamProject itp = tpc.GetService<ITestManagementService>().GetTeamProject("Techbrother_Team");

        }
        public void GetTestPoints(int suidid)
        {
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);
            ITestManagementTeamProject itp = tpc.GetService<ITestManagementService>().GetTeamProject("Techbrother_Team");
            ITestSuiteBase testsuite = itp.TestSuites.Query("select * from TestSuite where id=" + suidid + "").FirstOrDefault();
            ITestPointCollection ipc = testsuite.Plan.QueryTestPoints("select * from TestPoint where Suiteid=" + suidid + "");

            foreach (ITestPoint tp in ipc)
            {
                Console.WriteLine(tp.SuiteId + "----" + tp.TestCaseId + "-----" + tp.State.ToString() + "---" + tp.TestCaseWorkItem.Title);
            }

        }
        public void GetSharedQueries()
        {
            WorkItemCollection queryResults = null;
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);
            WorkItemStore wis = tpc.GetService<WorkItemStore>();
            List<string> listQueries = new List<string>();
            var project = wis.Projects["Techbrother_Team"];
            QueryHierarchy queryHierarchy = project.QueryHierarchy;
            var queryFolder = queryHierarchy as QueryFolder;
            QueryItem queryItem = queryFolder["Shared Queries"];
            queryFolder = queryItem as QueryFolder;
            foreach (var item in queryFolder)
            {

                listQueries.Add(item.Name);
                //  Console.WriteLine(item.Name);
            }
            var variables = new Dictionary<string, string>() { { "project", "Techbrother_Team" } };

            QueryHierarchy queryRoot = wis.Projects[0].QueryHierarchy;
            QueryFolder folder = (QueryFolder)queryRoot["Shared Queries"];
            QueryDefinition query = (QueryDefinition)folder["BugDisplayQueries"];
            queryResults = wis.Query(query.QueryText, variables);
            foreach (FieldDefinition field in queryResults.DisplayFields)
            {
                Console.WriteLine(field.Name);
            }
            Console.WriteLine("-----------------");
            foreach (WorkItem w in queryResults)
            {
                Console.WriteLine(w.Title);
            }
        }

        public void GetAllChangeSets()
        {
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);

            var vcs = tpc.GetService<VersionControlServer>();

            // Create versionspec's. Example start with changeset 13
            VersionSpec versionFrom = VersionSpec.ParseSingleSpec("C13", null);
            // If you want all changesets use this versionFrom:
            // VersionSpec versionFrom = null;
            VersionSpec versionTo = VersionSpec.Latest;

            // Get Changesets
            var changesets = vcs.QueryHistory("$/Techbrother_Team/Main",

              VersionSpec.Latest,
              0,
              RecursionType.Full,
              null,
              null,
              versionTo,
              Int32.MaxValue,
              true,
              false
              ).Cast<Changeset>();

            foreach (var changeset in changesets)
            {
                Console.WriteLine(changeset.ChangesetId + "--" + changeset.OwnerDisplayName + changeset.CreationDate);
            }
        }

        public void FindContentofFileinTFS()
        {
            string teamProjectCollectionUrl = "http://desktop-anh3ro7:8080/tfs/";
            string filePath = @"$/Techbrother_Team/Main/ConsolewithtfsFeature/ConsolewithtfsFeature/Program.cs";

            // Get the version control server
            TfsTeamProjectCollection teamProjectCollection = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(teamProjectCollectionUrl));
            VersionControlServer versionControlServer = teamProjectCollection.GetService<VersionControlServer>();

            // Get the latest Item for filePath
            Item item = versionControlServer.GetItem(filePath, VersionSpec.Latest);

            // Download and display content to console
            string fileString = string.Empty;

            using (Stream stream = item.DownloadFile())
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);

                    // Use StreamReader to read MemoryStream created from byte array
                    using (StreamReader streamReader = new StreamReader(new MemoryStream(memoryStream.ToArray())))
                    {
                        fileString = streamReader.ReadToEnd();
                    }
                }
            }

            Console.WriteLine(fileString);
            Console.ReadLine();
        }
        public void GetTestSuiteByName()
        {
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);
            ITestManagementTeamProject itp = tpc.GetService<ITestManagementService>().GetTeamProject("Techbrother_Team");
            string query = string.Concat("SELECT * FROM TestSuite");
            var firstMatchingSuite = itp.TestSuites.Query(query);
            foreach (IStaticTestSuite childSuite in firstMatchingSuite)
            {
                Console.WriteLine("{0} Suite", childSuite.Title);

            }
            ITestPlan testPlan = itp.TestPlans.Find(3);
            Console.WriteLine("Root Suite: {0}", testPlan.RootSuite.Title);

        }
        public void GetAllTestPlanALL()
        {
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);
            ITestManagementTeamProject itp = tpc.GetService<ITestManagementService>().GetTeamProject("TechBrothers");

            ITestPlanCollection plans = itp.TestPlans.Query("Select * From TestPlan");
            foreach (ITestPlan plan in plans)
            {
                //Console.WriteLine(plan.RootSuite.Title);
                //  Console.WriteLine(plan.RootSuite.TestCases);
                foreach (ITestSuiteEntry ie in plan.RootSuite.TestCases)
                {
                    Console.WriteLine(ie.Title);
                }
                Console.WriteLine("-------------------------------");
            }

        }
    }
}
