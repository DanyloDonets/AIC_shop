#pragma checksum "..\..\..\Puschase.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8A070C5DB1715FA653339C2470805E653DB6BDBF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Drug_Shop;
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


namespace Drug_Shop {
    
    
    /// <summary>
    /// Puschase
    /// </summary>
    public partial class Puschase : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Puschase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategoryItemList;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Puschase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProductsItemList;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Puschase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider QuantitySlider;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Puschase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AmountForProduct;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Puschase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ReceiptProductsItemList;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Puschase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Amount;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Drug_Shop;V1.0.0.0;component/puschase.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Puschase.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CategoryItemList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\Puschase.xaml"
            this.CategoryItemList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CategoryItemList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ProductsItemList = ((System.Windows.Controls.ListView)(target));
            
            #line 24 "..\..\..\Puschase.xaml"
            this.ProductsItemList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProductsItemList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.QuantitySlider = ((System.Windows.Controls.Slider)(target));
            
            #line 39 "..\..\..\Puschase.xaml"
            this.QuantitySlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.QuantitySlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AmountForProduct = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            
            #line 43 "..\..\..\Puschase.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ReceiptProductsItemList = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.Amount = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            
            #line 62 "..\..\..\Puschase.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 63 "..\..\..\Puschase.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 64 "..\..\..\Puschase.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

