﻿#pragma checksum "..\..\TipCont.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9935C2C73F7F44313048482C19AFC259689F48C422B73DA2A11F1661FF6B92E5"
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
    /// TipCont
    /// </summary>
    public partial class TipCont : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 60 "..\..\TipCont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Angajat;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\TipCont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button inainte;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\TipCont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock introdu;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\TipCont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\TipCont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox cod;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\TipCont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock gresit;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\TipCont.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ATM_Tiketing;component/tipcont.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TipCont.xaml"
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
            
            #line 16 "..\..\TipCont.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Obisnuit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Angajat = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\TipCont.xaml"
            this.Angajat.Click += new System.Windows.RoutedEventHandler(this.Angajat_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 103 "..\..\TipCont.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Inapoi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.inainte = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\TipCont.xaml"
            this.inainte.Click += new System.Windows.RoutedEventHandler(this.Inainte_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.introdu = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.border = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            this.cod = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 197 "..\..\TipCont.xaml"
            this.cod.PasswordChanged += new System.Windows.RoutedEventHandler(this.cod_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.gresit = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.mainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

