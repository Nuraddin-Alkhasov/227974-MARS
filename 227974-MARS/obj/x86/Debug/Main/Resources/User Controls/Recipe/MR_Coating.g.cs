﻿#pragma checksum "..\..\..\..\..\..\..\Main\Resources\User Controls\Recipe\MR_Coating.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2137AE8401B3D2186B95F98445EBA2AD932779B7274BF000D5D90083EA3327CD"
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


namespace HMI.Resources.UserControls {
    
    
    /// <summary>
    /// MR_Coating
    /// </summary>
    public partial class MR_Coating : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\..\..\..\..\Main\Resources\User Controls\Recipe\MR_Coating.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.RadioButton A;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\..\..\..\Main\Resources\User Controls\Recipe\MR_Coating.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.PictureBox _img;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\..\..\Main\Resources\User Controls\Recipe\MR_Coating.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextVarOut _name;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\..\..\Main\Resources\User Controls\Recipe\MR_Coating.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextVarOut _descr;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\..\..\Main\Resources\User Controls\Recipe\MR_Coating.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextVarOut _tank;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\..\..\Main\Resources\User Controls\Recipe\MR_Coating.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.ComboBox _paint;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\..\..\Main\Resources\User Controls\Recipe\MR_Coating.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button _del;
        
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
            System.Uri resourceLocater = new System.Uri("/227974-MARS;component/main/resources/user%20controls/recipe/mr_coating.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\Main\Resources\User Controls\Recipe\MR_Coating.xaml"
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
            
            #line 4 "..\..\..\..\..\..\..\Main\Resources\User Controls\Recipe\MR_Coating.xaml"
            ((HMI.Resources.UserControls.MR_Coating)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.A = ((VisiWin.Controls.RadioButton)(target));
            return;
            case 3:
            this._img = ((VisiWin.Controls.PictureBox)(target));
            return;
            case 4:
            this._name = ((VisiWin.Controls.TextVarOut)(target));
            return;
            case 5:
            this._descr = ((VisiWin.Controls.TextVarOut)(target));
            return;
            case 6:
            this._tank = ((VisiWin.Controls.TextVarOut)(target));
            return;
            case 7:
            this._paint = ((VisiWin.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\..\..\..\..\Main\Resources\User Controls\Recipe\MR_Coating.xaml"
            this._paint.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this._paint_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this._del = ((VisiWin.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

