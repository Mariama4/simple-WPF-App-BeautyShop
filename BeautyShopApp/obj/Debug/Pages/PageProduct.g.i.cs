﻿#pragma checksum "..\..\..\Pages\PageProduct.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E5EE8B190BEF7DE81DC7E8306470B8484993824E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BeautyShopApp.Pages;
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


namespace BeautyShopApp.Pages {
    
    
    /// <summary>
    /// PageProduct
    /// </summary>
    public partial class PageProduct : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitleProduct;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSearch;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalehistory;
        
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
            System.Uri resourceLocater = new System.Uri("/BeautyShopApp;component/pages/pageproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageProduct.xaml"
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
            this.lblTitleProduct = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.TxtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\Pages\PageProduct.xaml"
            this.TxtSearch.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseUp);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\Pages\PageProduct.xaml"
            this.TxtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SafeTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dtGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 25 "..\..\..\Pages\PageProduct.xaml"
            this.dtGrid.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.dtGrid_ClickUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Pages\PageProduct.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSalehistory = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Pages\PageProduct.xaml"
            this.btnSalehistory.Click += new System.Windows.RoutedEventHandler(this.BtnSalehistory_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

