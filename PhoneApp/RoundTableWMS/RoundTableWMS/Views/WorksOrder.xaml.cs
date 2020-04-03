using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RoundTableDal;
using RoundTableAPILib;
using RoundTableCore;
using RoundTableDal.Models;

namespace RoundTableWMS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorksOrder : ContentPage
    {
        RoundTableAPIClient _client = new RoundTableAPIClient();
        public string ApiUrl { get; set; }
        public WorksOrder()
        {
            InitializeComponent();
            SetIpAddress();
            LoadData();
        }

        public void SetIpAddress()
        {
            if (Device.RuntimePlatform == Device.Android)
                ApiUrl =Constants.andriodAPi;
            else if (Device.RuntimePlatform == Device.iOS)
                ApiUrl = Constants.isoApi;


        }

        public async void LoadData()
        {
            List<WorksOrderModel> allOrders = new List<WorksOrderModel>();

            allOrders = await _client.GetAllWorksOrder(ApiUrl);

            grdWorksOrders.ItemsSource = allOrders;


        }

        private async  void grdWorksOrders_SelectionChanged(object sender, Telerik.XamarinForms.DataGrid.DataGridSelectionChangedEventArgs e)
        {
            await Navigation.PushAsync(new WorksOrderEdit());
        }
        public void AddMessage(string message)

        {

            Device.BeginInvokeOnMainThread(() =>

            {

                if (messageDisplay.Children.OfType<Label>().Where(c => c.Text == message).Any())

                {

                    // Do nothing, an identical message already exists

                }

                else

                {

                    Label label = new Label()

                    {

                        Text = message,

                        HorizontalOptions = LayoutOptions.CenterAndExpand,

                        VerticalOptions = LayoutOptions.Start

                    };

                    messageDisplay.Children.Add(label);

                }

            });

        }   
    }
}