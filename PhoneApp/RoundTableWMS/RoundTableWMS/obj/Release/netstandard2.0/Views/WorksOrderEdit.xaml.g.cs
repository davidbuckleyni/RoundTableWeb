//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("RoundTableWMS.Views.WorksOrderEdit.xaml", "Views/WorksOrderEdit.xaml", typeof(global::RoundTableWMS.Views.WorksOrderEdit))]

namespace RoundTableWMS.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\WorksOrderEdit.xaml")]
    public partial class WorksOrderEdit : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label lblWorksOrderNo;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadEntry txtDescription;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadEntry txtNotes;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.DataGrid.RadDataGrid grdOrderLines;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.DatePicker rdDaatePicker;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.DatePicker rdEndDate;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label lblSign;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::SignaturePad.Forms.SignaturePadView signatureView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Picker picker;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Telerik.XamarinForms.Input.RadButton btnSaveWorkOrder;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(WorksOrderEdit));
            lblWorksOrderNo = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "lblWorksOrderNo");
            txtDescription = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadEntry>(this, "txtDescription");
            txtNotes = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadEntry>(this, "txtNotes");
            grdOrderLines = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.DataGrid.RadDataGrid>(this, "grdOrderLines");
            rdDaatePicker = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.DatePicker>(this, "rdDaatePicker");
            rdEndDate = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.DatePicker>(this, "rdEndDate");
            lblSign = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "lblSign");
            signatureView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SignaturePad.Forms.SignaturePadView>(this, "signatureView");
            picker = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Picker>(this, "picker");
            btnSaveWorkOrder = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Telerik.XamarinForms.Input.RadButton>(this, "btnSaveWorkOrder");
        }
    }
}
