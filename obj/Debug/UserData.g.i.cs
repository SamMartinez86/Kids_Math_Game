﻿#pragma checksum "..\..\UserData.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4010C28E38D706540FDD431BB9A53CEE463845CA1F00E6EC54FD23F53B413318"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KidsMathGame;
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


namespace KidsMathGame {
    
    
    /// <summary>
    /// UserData
    /// </summary>
    public partial class UserData : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\UserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton AddRadio;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\UserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SubRadio;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\UserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MultiRadio;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\UserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton DivRadio;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\UserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MainMenuBtn;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\UserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NameLbl;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\UserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AgeLbl;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\UserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTxt;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\UserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ageTxt;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\UserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nameErrLbl;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\UserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ageErrLbl;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\UserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label radioErrLbl;
        
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
            System.Uri resourceLocater = new System.Uri("/KidsMathGame;component/userdata.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserData.xaml"
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
            
            #line 10 "..\..\UserData.xaml"
            ((KidsMathGame.UserData)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddRadio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 23 "..\..\UserData.xaml"
            this.AddRadio.Checked += new System.Windows.RoutedEventHandler(this.AddRadio_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SubRadio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 29 "..\..\UserData.xaml"
            this.SubRadio.Checked += new System.Windows.RoutedEventHandler(this.SubRadio_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MultiRadio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 35 "..\..\UserData.xaml"
            this.MultiRadio.Checked += new System.Windows.RoutedEventHandler(this.MultiRadio_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DivRadio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 41 "..\..\UserData.xaml"
            this.DivRadio.Checked += new System.Windows.RoutedEventHandler(this.DivRadio_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MainMenuBtn = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\UserData.xaml"
            this.MainMenuBtn.Click += new System.Windows.RoutedEventHandler(this.MainMenuBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NameLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.AgeLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.nameTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.ageTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.nameErrLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.ageErrLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.radioErrLbl = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
