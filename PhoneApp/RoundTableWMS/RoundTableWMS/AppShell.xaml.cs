using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RoundTableWMS
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
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
