﻿#pragma checksum "..\..\..\View\test.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "617040FE2F221AB0E0B8E0231E44C266DA2CC4DF3049CA154DE8EF4D1C74DF76"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace QLNH {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\View\test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button thucDon;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\View\test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSua;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\View\test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MenuDataGrid;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\View\test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ActionPanel;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\View\test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonUpdateSua;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\View\test.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonHuySua;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QLNH;component/view/test.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\test.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.thucDon = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\View\test.xaml"
            this.thucDon.Click += new System.Windows.RoutedEventHandler(this.View_ThucDon);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 63 "..\..\..\View\test.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_AddFood);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonSua = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\View\test.xaml"
            this.buttonSua.Click += new System.Windows.RoutedEventHandler(this.buttonSua_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MenuDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.ActionPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.buttonUpdateSua = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\..\View\test.xaml"
            this.buttonUpdateSua.Click += new System.Windows.RoutedEventHandler(this.buttonUpdateSua_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonHuySua = ((System.Windows.Controls.Button)(target));
            
            #line 162 "..\..\..\View\test.xaml"
            this.ButtonHuySua.Click += new System.Windows.RoutedEventHandler(this.ButtonHuySua_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

