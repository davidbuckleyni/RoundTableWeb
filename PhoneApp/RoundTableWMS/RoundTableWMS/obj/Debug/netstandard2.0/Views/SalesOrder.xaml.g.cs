//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("RoundTableWMS.Views.SalesOrder.xaml", "Views/SalesOrder.xaml", typeof(global::RoundTableWMS.Views.SalesOrder))]

namespace RoundTableWMS.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\SalesOrder.xaml")]
    public partial class SalesOrder : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadEntry txtCustomerAccountNo;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadButton btnSearchWorkOrders;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.DataGrid.RadDataGrid grdWorksOrders;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.StackLayout messageDisplay;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(SalesOrder));
            txtCustomerAccountNo = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadEntry>(this, "txtCustomerAccountNo");
            btnSearchWorkOrders = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadButton>(this, "btnSearchWorkOrders");
            grdWorksOrders = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.DataGrid.RadDataGrid>(this, "grdWorksOrders");
            messageDisplay = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.StackLayout>(this, "messageDisplay");
        }
    }
}
