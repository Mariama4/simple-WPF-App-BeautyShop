﻿#pragma checksum "..\..\..\Pages\PageMain.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0D58CC29CE548D9375AE80034ECB5D980684C27D"
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
    /// PageMain
    /// </summary>
    public partial class PageMain : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnService;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClient;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProduct;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddProduct;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStuff;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCompany;
        
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
            System.Uri resourceLocater = new System.Uri("/BeautyShopApp;component/pages/pagemain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageMain.xaml"
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
            
            #line 9 "..\..\..\Pages\PageMain.xaml"
            ((BeautyShopApp.Pages.PageMain)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Page_MouseMove);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Pages\PageMain.xaml"
            ((BeautyShopApp.Pages.PageMain)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.Page_GotFocus);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Pages\PageMain.xaml"
            ((BeautyShopApp.Pages.PageMain)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Page_MouseEnter);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Pages\PageMain.xaml"
            ((BeautyShopApp.Pages.PageMain)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 11 "..\..\..\Pages\PageMain.xaml"
            ((System.Windows.Controls.Grid)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.Grid_GotFocus);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\Pages\PageMain.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Grid_MouseMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnService = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Pages\PageMain.xaml"
            this.btnService.Click += new System.Windows.RoutedEventHandler(this.BtnService_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnClient = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\PageMain.xaml"
            this.btnClient.Click += new System.Windows.RoutedEventHandler(this.BtnClient_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnProduct = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\PageMain.xaml"
            this.btnProduct.Click += new System.Windows.RoutedEventHandler(this.BtnProduct_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAddProduct = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Pages\PageMain.xaml"
            this.btnAddProduct.Click += new System.Windows.RoutedEventHandler(this.BtnAddProduct_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnStuff = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Pages\PageMain.xaml"
            this.btnStuff.Click += new System.Windows.RoutedEventHandler(this.BtnStuff_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCompany = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Pages\PageMain.xaml"
            this.btnCompany.Click += new System.Windows.RoutedEventHandler(this.BtnCompany_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
