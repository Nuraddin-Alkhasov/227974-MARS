﻿#pragma checksum "..\..\..\..\..\..\..\..\Main\Regions\Dialog\MachineOverview\DataPicker\MO_DataPicker.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F8725BD77F8DF7F2720977CE8FBC919B6196DD9E3053A073937DE67785EEA819"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using VisiWin.Adapter;
using VisiWin.ApplicationFramework;
using VisiWin.Controls;
using VisiWin.Extensions;
using VisiWin.Shapes;


namespace HMI.DialogRegion.MO.Views {
    
    
    /// <summary>
    /// MO_DataPicker
    /// </summary>
    public partial class MO_DataPicker : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\..\..\..\Main\Regions\Dialog\MachineOverview\DataPicker\MO_DataPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid border;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\..\..\..\Main\Regions\Dialog\MachineOverview\DataPicker\MO_DataPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextBlock HeaderText;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\..\..\..\Main\Regions\Dialog\MachineOverview\DataPicker\MO_DataPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\..\..\..\..\Main\Regions\Dialog\MachineOverview\DataPicker\MO_DataPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image gif;
        
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
            System.Uri resourceLocater = new System.Uri("/227974-MARS;component/main/regions/dialog/machineoverview/datapicker/mo_datapick" +
                    "er.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\Main\Regions\Dialog\MachineOverview\DataPicker\MO_DataPicker.xaml"
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
            this.border = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.HeaderText = ((VisiWin.Controls.TextBlock)(target));
            return;
            case 3:
            this.CancelButton = ((VisiWin.Controls.Button)(target));
            return;
            case 4:
            this.gif = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

