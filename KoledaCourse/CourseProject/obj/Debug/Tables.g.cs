﻿#pragma checksum "..\..\Tables.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EBCFBD2C67E15778C0373B214F48F1DA3DDAE9F06DFB0FCAF58BFDA32AFB36F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CourseProject;
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


namespace CourseProject {
    
    
    /// <summary>
    /// Tables
    /// </summary>
    public partial class Tables : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuReports;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuSettingsDB;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridMain;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridTopics;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxYear;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxMonth;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxGroup;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonShow;
        
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
            System.Uri resourceLocater = new System.Uri("/CourseProject;component/tables.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Tables.xaml"
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
            this.menuReports = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\Tables.xaml"
            this.menuReports.Click += new System.Windows.RoutedEventHandler(this.menuReports_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.menuSettingsDB = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\Tables.xaml"
            this.menuSettingsDB.Click += new System.Windows.RoutedEventHandler(this.menuSettingsDB_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dataGridMain = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.dataGridTopics = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.comboBoxYear = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.comboBoxMonth = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.comboBoxGroup = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.buttonShow = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Tables.xaml"
            this.buttonShow.Click += new System.Windows.RoutedEventHandler(this.buttonShow_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

