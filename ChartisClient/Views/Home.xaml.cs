using System;
using System.Data.Services.Client;
using System.Diagnostics;
using System.Linq;
using System.Windows.Browser;
using System.Windows.Controls;
using System.Windows.Navigation;
using ChartisClient.ChartisService;

namespace ChartisClient
{
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();

            try
            {
                var uri = new Uri(HtmlPage.Document.DocumentUri, "ChartisData.svc");
                var repository = new Repository(uri);
                var query = (DataServiceQuery<Sprint>) (from sprint in repository.Sprints select sprint);
                query.BeginExecute(result => DataContext = query.EndExecute(result), null);
            }
            catch (Exception e)
            {
                Remark.Text = e.Message;
            }
            
        }

        void sprints_LoadCompleted(object sender, LoadCompletedEventArgs e)
        {
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}