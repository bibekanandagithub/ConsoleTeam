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
namespace ConsoleTeam
{
    class Program
    {
        static void Main(string[] args)
        {




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

        }
    }
}
