﻿#pragma checksum "..\..\..\CandidateProfileWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EBCD84AD38779A22A7B10CFDC9969FCDE31CC50E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CandidateManagement_PhanVoNgocPhu;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace CandidateManagement_PhanVoNgocPhu {
    
    
    /// <summary>
    /// CandidateProfileWindow
    /// </summary>
    public partial class CandidateProfileWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\CandidateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCandidateId;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\CandidateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFullname;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\CandidateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtImageURL;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\CandidateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpBirthday;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\CandidateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbJobPosting;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\CandidateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCandidateDescription;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\CandidateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgCandidateProfile;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\CandidateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\CandidateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\CandidateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\CandidateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CandidateManagement_PhanVoNgocPhu;V1.0.0.0;component/candidateprofilewindow.xaml" +
                    "", System.UriKind.Relative);
            
            #line 1 "..\..\..\CandidateProfileWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\CandidateProfileWindow.xaml"
            ((CandidateManagement_PhanVoNgocPhu.CandidateProfileWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtCandidateId = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\CandidateProfileWindow.xaml"
            this.txtCandidateId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtFullname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtImageURL = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.dpBirthday = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.cbbJobPosting = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.txtCandidateDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.dgCandidateProfile = ((System.Windows.Controls.DataGrid)(target));
            
            #line 23 "..\..\..\CandidateProfileWindow.xaml"
            this.dgCandidateProfile.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgCandidateProfile_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\CandidateProfileWindow.xaml"
            this.dgCandidateProfile.Loaded += new System.Windows.RoutedEventHandler(this.dgCandidateProfile_Loaded);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\CandidateProfileWindow.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\CandidateProfileWindow.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\CandidateProfileWindow.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\CandidateProfileWindow.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

