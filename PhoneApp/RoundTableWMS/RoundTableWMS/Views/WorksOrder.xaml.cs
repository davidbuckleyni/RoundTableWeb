﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RoundTableDal;
using RoundTableAPILib;

namespace RoundTableWMS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorksOrder : ContentPage
    {
        RoundTableAPIClient api = new RoundTableAPIClient();
        public WorksOrder()
        {
            InitializeComponent();
           
        }

        
    }
}