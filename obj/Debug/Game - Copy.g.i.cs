﻿#pragma checksum "..\..\Game - Copy.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF061EB375A17711B6404C79D12CCE6257B900FC03B38E018FF64B4ACD67E150"
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
    /// Game
    /// </summary>
    public partial class Game : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\Game - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button QuitBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Game - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartBtn;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Game - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label outcomeLbl;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Game - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label num1Lbl;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Game - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label operatorLbl;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Game - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label num2Lbl;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Game - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label equalsLbl;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Game - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userTxtBx;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\Game - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubmitBtn;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\Game - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TimerLbl;
        
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
            System.Uri resourceLocater = new System.Uri("/KidsMathGame;component/game%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Game - Copy.xaml"
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
            this.QuitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Game - Copy.xaml"
            this.QuitBtn.Click += new System.Windows.RoutedEventHandler(this.QuitBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StartBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\Game - Copy.xaml"
            this.StartBtn.Click += new System.Windows.RoutedEventHandler(this.StartBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.outcomeLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.num1Lbl = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.operatorLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.num2Lbl = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.equalsLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.userTxtBx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.SubmitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\Game - Copy.xaml"
            this.SubmitBtn.Click += new System.Windows.RoutedEventHandler(this.SubmitBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.TimerLbl = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

