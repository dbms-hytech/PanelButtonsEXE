﻿#pragma checksum "..\..\Window1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B789246637B854AAFE1E0322B75B78DE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using ПанельЕИИС;


namespace ПанельЕИИС {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ПанельЕИИС.Window1 WindowSet;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butOpen;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPath;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid1;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butOfXML;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butSave;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butParsIcons;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butClose;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butMax;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butMin;
        
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
            System.Uri resourceLocater = new System.Uri("/ПанельЕИИС;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
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
            this.WindowSet = ((ПанельЕИИС.Window1)(target));
            
            #line 8 "..\..\Window1.xaml"
            this.WindowSet.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.WindowSet_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.butOpen = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\Window1.xaml"
            this.butOpen.Click += new System.Windows.RoutedEventHandler(this.butOpen_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DataGrid1 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 56 "..\..\Window1.xaml"
            this.DataGrid1.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.DataGrid1_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 5:
            this.butOfXML = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\Window1.xaml"
            this.butOfXML.Click += new System.Windows.RoutedEventHandler(this.butOfXML_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.butSave = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\Window1.xaml"
            this.butSave.Click += new System.Windows.RoutedEventHandler(this.butSave_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.butParsIcons = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\Window1.xaml"
            this.butParsIcons.Click += new System.Windows.RoutedEventHandler(this.butParsIcons_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.butClose = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\Window1.xaml"
            this.butClose.Click += new System.Windows.RoutedEventHandler(this.butClose_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.butMax = ((System.Windows.Controls.Button)(target));
            
            #line 121 "..\..\Window1.xaml"
            this.butMax.Click += new System.Windows.RoutedEventHandler(this.butMax_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.butMin = ((System.Windows.Controls.Button)(target));
            
            #line 124 "..\..\Window1.xaml"
            this.butMin.Click += new System.Windows.RoutedEventHandler(this.butMin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

