﻿#pragma checksum "..\..\..\..\MVVM\View\RegisterView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E65E1B64B1426F0AAD3B5FE1376288FE29F5951A7724DA2E772DF44E150CDB3A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using BodyBuilder.WinUI.MVVM.View;
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


namespace BodyBuilder.WinUI.MVVM.View {
    
    
    /// <summary>
    /// RegisterView
    /// </summary>
    public partial class RegisterView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnlForm;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRegister;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border brdForm;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxUserName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pbxUserPassword;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pbxReUserPassword;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxName;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxSurname;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\MVVM\View\RegisterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSubmit;
        
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
            System.Uri resourceLocater = new System.Uri("/BodyBuilder.WinUI;component/mvvm/view/registerview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\RegisterView.xaml"
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
            
            #line 9 "..\..\..\..\MVVM\View\RegisterView.xaml"
            ((BodyBuilder.WinUI.MVVM.View.RegisterView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.RegisterView_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\MVVM\View\RegisterView.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.pnlForm = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.lblRegister = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.brdForm = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.tbxUserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.pbxUserPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.pbxReUserPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.tbxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.tbxSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.btnSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\MVVM\View\RegisterView.xaml"
            this.btnSubmit.Click += new System.Windows.RoutedEventHandler(this.btnSubmit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
