﻿#pragma checksum "..\..\..\..\Forms\AdminForms\WorkerAddForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D3419F931F939D6AA744949CFAA33B86EDFEFDBC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using KP.Forms.AdminForms;
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


namespace KP.Forms.AdminForms {
    
    
    /// <summary>
    /// WorkerAddForm
    /// </summary>
    public partial class WorkerAddForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Forms\AdminForms\WorkerAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Forms\AdminForms\WorkerAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SurnameBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Forms\AdminForms\WorkerAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Forms\AdminForms\WorkerAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker WorkerDatePicker;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Forms\AdminForms\WorkerAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Forms\AdminForms\WorkerAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Forms\AdminForms\WorkerAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Forms\AdminForms\WorkerAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AccessCombo;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Forms\AdminForms\WorkerAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AdressBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Forms\AdminForms\WorkerAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
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
            System.Uri resourceLocater = new System.Uri("/KP;component/forms/adminforms/workeraddform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Forms\AdminForms\WorkerAddForm.xaml"
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
            
            #line 8 "..\..\..\..\Forms\AdminForms\WorkerAddForm.xaml"
            ((KP.Forms.AdminForms.WorkerAddForm)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.SurnameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.LastNameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.WorkerDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.PhoneBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.LoginBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.PasswordBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.AccessCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.AdressBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\Forms\AdminForms\WorkerAddForm.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 53 "..\..\..\..\Forms\AdminForms\WorkerAddForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

