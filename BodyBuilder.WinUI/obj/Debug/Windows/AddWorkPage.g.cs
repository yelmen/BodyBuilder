#pragma checksum "..\..\..\Windows\AddWorkPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E02A4BC8A89CD4FEC1C46381EA095EC9DB23483B0A0F9771B51C41C23D910ECB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using BodyBuilder.WinUI.Windows;
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


namespace BodyBuilder.WinUI.Windows {
    
    
    /// <summary>
    /// AddWorkPage
    /// </summary>
    public partial class AddWorkPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Windows\AddWorkPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\AddWorkPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbxSearchBar;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Windows\AddWorkPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddWork;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Windows\AddWorkPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl Control;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Windows\AddWorkPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAccept;
        
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
            System.Uri resourceLocater = new System.Uri("/BodyBuilder.WinUI;component/windows/addworkpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AddWorkPage.xaml"
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
            
            #line 11 "..\..\..\Windows\AddWorkPage.xaml"
            ((BodyBuilder.WinUI.Windows.AddWorkPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.AddWorkPage_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnClose = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Windows\AddWorkPage.xaml"
            this.BtnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TbxSearchBar = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\Windows\AddWorkPage.xaml"
            this.TbxSearchBar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbxSearchBar_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnAddWork = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Windows\AddWorkPage.xaml"
            this.BtnAddWork.Click += new System.Windows.RoutedEventHandler(this.BtnAddWork_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Control = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 6:
            this.BtnAccept = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\Windows\AddWorkPage.xaml"
            this.BtnAccept.Click += new System.Windows.RoutedEventHandler(this.BtnAccept_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

