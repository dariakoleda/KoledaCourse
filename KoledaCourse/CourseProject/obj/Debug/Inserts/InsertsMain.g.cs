﻿#pragma checksum "..\..\..\Inserts\InsertsMain.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1C70A7C504738501FFF88CCA7D8ADAAC35D668037E83BC83859C7BE21BC64728"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CourseProject.Inserts;
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


namespace CourseProject.Inserts {
    
    
    /// <summary>
    /// InsertsMain
    /// </summary>
    public partial class InsertsMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Inserts\InsertsMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonInsertGroup;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Inserts\InsertsMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonInsertStudent;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Inserts\InsertsMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonInsertTopic;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Inserts\InsertsMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonInsertTeacher;
        
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
            System.Uri resourceLocater = new System.Uri("/CourseProject;component/inserts/insertsmain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Inserts\InsertsMain.xaml"
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
            this.buttonInsertGroup = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Inserts\InsertsMain.xaml"
            this.buttonInsertGroup.Click += new System.Windows.RoutedEventHandler(this.buttonInsertGroup_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonInsertStudent = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Inserts\InsertsMain.xaml"
            this.buttonInsertStudent.Click += new System.Windows.RoutedEventHandler(this.buttonInsertStudent_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonInsertTopic = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Inserts\InsertsMain.xaml"
            this.buttonInsertTopic.Click += new System.Windows.RoutedEventHandler(this.buttonInsertTopic_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonInsertTeacher = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Inserts\InsertsMain.xaml"
            this.buttonInsertTeacher.Click += new System.Windows.RoutedEventHandler(this.buttonInsertTeacher_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

