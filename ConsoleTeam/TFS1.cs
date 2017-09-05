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

namespace ConsoleTeam
{
    class TFS1
    {
        Uri CollectionUri = new Uri("http://desktop-anh3ro7:8080/tfs/");
       
        public void GetAllWorkItem()
        {
            //Connect to the Team Foundation Server
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);
            WorkItemStore wis = tpc.GetService<WorkItemStore>();
            //query will execute and store into the work items
            Query wiq = new Query(wis,"Select * from WorkItems");
            //All the collection will store here
            WorkItemCollection wic = wiq.RunQuery();
            foreach(WorkItem wi in wic)
            {
                Console.WriteLine(wi.Title.ToString() + "---" + wi.Fields["Work Item Type"].Value.ToString());
            }

            Console.Read();
            
        }
        public void GetActiveWorkItem()
        {
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);
            WorkItemStore wis = tpc.GetService<WorkItemStore>();
            Query q = new Query(wis,"select * from WorkItem");
            WorkItemCollection wic = q.RunQuery();
            foreach(WorkItem wi in wic)
            {
               if(wi.State=="Active")
                {
                    Console.WriteLine(wi.Title.ToString() + "---" + wi.Fields["Work Item Type"].Value.ToString());
                }
            }
            Console.Read();
        }
        //single work item by query
        public void GetSpecificworkitem(int WorkItemID)
        {
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);
            WorkItemStore wis = tpc.GetService<WorkItemStore>();
            WorkItemCollection wic = new Query(wis, "select * from WorkItem where ID='"+WorkItemID+"'").RunQuery();
            foreach(WorkItem wi in wic)
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

        }
    }
}
