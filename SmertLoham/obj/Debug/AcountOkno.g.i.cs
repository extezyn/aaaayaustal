﻿#pragma checksum "..\..\AcountOkno.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B9B2D0BDF351F5BB7DFD6EDADF09270CC5F790CBC1C5704BE6B1880D5E7404DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SmertLoham;
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


namespace SmertLoham {
    
    
    /// <summary>
    /// AcountOkno
    /// </summary>
    public partial class AcountOkno : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\AcountOkno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SecondGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AcountOkno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AT;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AcountOkno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Balance;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AcountOkno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Vsetablicy;
        
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
            System.Uri resourceLocater = new System.Uri("/SmertLoham;component/acountokno.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AcountOkno.xaml"
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
            this.SecondGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 20 "..\..\AcountOkno.xaml"
            this.SecondGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SecondGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AT = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\AcountOkno.xaml"
            this.AT.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.AT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Balance = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\AcountOkno.xaml"
            this.Balance.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Balance_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 29 "..\..\AcountOkno.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Insert_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 30 "..\..\AcountOkno.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 31 "..\..\AcountOkno.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Vsetablicy = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\AcountOkno.xaml"
            this.Vsetablicy.Click += new System.Windows.RoutedEventHandler(this.Vsetablicy_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
