﻿

#pragma checksum "C:\Users\AngelJ\Desktop\KPG.TECHSUMMIT.MAP\KPG.TECHSUMMIT.MAP\KPG.TECHSUMMIT.MAP\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FFE530BCEBD37D8231A4AE2593BB3CAF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KPG.TECHSUMMIT.MAP
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Bing.Maps.Map map; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.StackPanel stckCommerceInfo; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock tbMunicipality; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ComboBox cbMunicipalities; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///MainPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            map = (global::Bing.Maps.Map)this.FindName("map");
            stckCommerceInfo = (global::Windows.UI.Xaml.Controls.StackPanel)this.FindName("stckCommerceInfo");
            tbMunicipality = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("tbMunicipality");
            cbMunicipalities = (global::Windows.UI.Xaml.Controls.ComboBox)this.FindName("cbMunicipalities");
        }
    }
}



