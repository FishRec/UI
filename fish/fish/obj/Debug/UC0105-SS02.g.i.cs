﻿#pragma checksum "..\..\UC0105-SS02.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E5985896D36ADF6FBEBDDDB6175A38A9ABAEF058"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
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
using System.Windows.Forms.Integration;
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
using fish;


namespace fish {
    
    
    /// <summary>
    /// UC0105_SS02
    /// </summary>
    public partial class UC0105_SS02 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\UC0105-SS02.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock hometxt;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\UC0105-SS02.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\UC0105-SS02.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock dynamictxt;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\UC0105-SS02.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image homeim;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\UC0105-SS02.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock logouttxt;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\UC0105-SS02.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image logoutim;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\UC0105-SS02.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock showpath;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\UC0105-SS02.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mediaElement;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\UC0105-SS02.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame UC0105_2;
        
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
            System.Uri resourceLocater = new System.Uri("/fish;component/uc0105-ss02.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UC0105-SS02.xaml"
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
            this.hometxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 13 "..\..\UC0105-SS02.xaml"
            this.hometxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.gotoHome);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.dynamictxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 15 "..\..\UC0105-SS02.xaml"
            this.dynamictxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.gotoDynamic);
            
            #line default
            #line hidden
            return;
            case 4:
            this.homeim = ((System.Windows.Controls.Image)(target));
            
            #line 16 "..\..\UC0105-SS02.xaml"
            this.homeim.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.gotoHome);
            
            #line default
            #line hidden
            return;
            case 5:
            this.logouttxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.logoutim = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.showpath = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.mediaElement = ((System.Windows.Controls.MediaElement)(target));
            
            #line 20 "..\..\UC0105-SS02.xaml"
            this.mediaElement.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.mediaElement_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.UC0105_2 = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
