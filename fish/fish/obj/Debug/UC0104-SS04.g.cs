﻿#pragma checksum "..\..\UC0104-SS04.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FF500482017F09A0E233E1780D37CB8F66EC3494"
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
    /// UC0104_SS04
    /// </summary>
    public partial class UC0104_SS04 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\UC0104-SS04.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock hometxt;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\UC0104-SS04.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\UC0104-SS04.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock seatxt;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\UC0104-SS04.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image homeim;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\UC0104-SS04.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock logouttxt;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\UC0104-SS04.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image logoutim;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\UC0104-SS04.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\UC0104-SS04.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\UC0104-SS04.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame UC0104_4;
        
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
            System.Uri resourceLocater = new System.Uri("/fish;component/uc0104-ss04.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UC0104-SS04.xaml"
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
            
            #line 13 "..\..\UC0104-SS04.xaml"
            this.hometxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.gotoHome);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.seatxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 15 "..\..\UC0104-SS04.xaml"
            this.seatxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.gotoType);
            
            #line default
            #line hidden
            return;
            case 4:
            this.homeim = ((System.Windows.Controls.Image)(target));
            
            #line 17 "..\..\UC0104-SS04.xaml"
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
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\UC0104-SS04.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.gotoType);
            
            #line default
            #line hidden
            return;
            case 9:
            this.UC0104_4 = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

