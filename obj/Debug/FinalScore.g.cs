﻿#pragma checksum "..\..\FinalScore.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3F6D5346AFAE8F23AFD4F3F4158963C53514227A914D9AB45839CDCFAE52D098"
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
    /// FinalScore
    /// </summary>
    public partial class FinalScore : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\FinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageBx;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\FinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label usernameLbl;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\FinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label userageLbl;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\FinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label userCorrect;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\FinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label userIncorrect;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\FinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label userTiempoLbl;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\FinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FSMainMenuBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/KidsMathGame;component/finalscore.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FinalScore.xaml"
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
            
            #line 9 "..\..\FinalScore.xaml"
            ((KidsMathGame.FinalScore)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ImageBx = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.usernameLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.userageLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.userCorrect = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.userIncorrect = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.userTiempoLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.FSMainMenuBtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\FinalScore.xaml"
            this.FSMainMenuBtn.Click += new System.Windows.RoutedEventHandler(this.FSMainMenuBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

