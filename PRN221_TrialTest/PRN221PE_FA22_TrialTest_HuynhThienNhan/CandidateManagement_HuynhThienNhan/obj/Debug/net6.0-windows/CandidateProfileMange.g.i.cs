﻿#pragma checksum "..\..\..\CandidateProfileMange.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "568994D572E5C1835D31FD393C165C8DC7E2E6AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CandidateManagement_HuynhThienNhan;
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


namespace CandidateManagement_HuynhThienNhan {
    
    
    /// <summary>
    /// CandidateProfileMange
    /// </summary>
    public partial class CandidateProfileMange : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\CandidateProfileMange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCandidateId;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\CandidateProfileMange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFullname;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\CandidateProfileMange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtImageURL;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\CandidateProfileMange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpBirthday;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\CandidateProfileMange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbJobPosting;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\CandidateProfileMange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCandidateDescription;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\CandidateProfileMange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgCandidateProfile;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\CandidateProfileMange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\CandidateProfileMange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\CandidateProfileMange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\CandidateProfileMange.xaml"
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
            System.Uri resourceLocater = new System.Uri("/CandidateManagement_HuynhThienNhan;V1.0.0.0;component/candidateprofilemange.xaml" +
                    "", System.UriKind.Relative);
            
            #line 1 "..\..\..\CandidateProfileMange.xaml"
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
            this.txtCandidateId = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\CandidateProfileMange.xaml"
            this.txtCandidateId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtFullname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtImageURL = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.dpBirthday = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.cbbJobPosting = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.txtCandidateDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.dgCandidateProfile = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

