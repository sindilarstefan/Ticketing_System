﻿#pragma checksum "..\..\TicheteNerezolvateClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AA7A790F1890564ED6FEA1A19DEF7D521B87D6201C1BF962DD7A21E6E8F25FC3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ATM_Tiketing;
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


namespace ATM_Tiketing {
    
    
    /// <summary>
    /// TicheteNerezolvateClient
    /// </summary>
    public partial class TicheteNerezolvateClient : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 246 "..\..\TicheteNerezolvateClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 257 "..\..\TicheteNerezolvateClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame mainFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/ATM_Tiketing;component/tichetenerezolvateclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TicheteNerezolvateClient.xaml"
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
            
            #line 13 "..\..\TicheteNerezolvateClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TiketsButton_Click2);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 62 "..\..\TicheteNerezolvateClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ListaMea_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 110 "..\..\TicheteNerezolvateClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SchiteButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 154 "..\..\TicheteNerezolvateClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Rezolvate_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 200 "..\..\TicheteNerezolvateClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Nerezolvate_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.mainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

