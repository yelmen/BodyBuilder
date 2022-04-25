using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using BodyBuilder.WinUI.MVVM.View;

namespace BodyBuilder.WinUI
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        private MainWindow _mnw = new MainWindow();
        public LoginView loginView = new LoginView();
        public RegisterView RegisterView = new RegisterView();
        

        public LoginPage()
        {
            InitializeComponent();
            
            
        }

        

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
            _mnw.Close();
        }


        public void getWindow()
        {
            this.Close();
            _mnw.Show();
        }

        private void LoginPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            SetView(loginView);
            //Thread animThread = new Thread(animTask);
            //animThread.Name = "Animation Thread";
            //animThread.Start();

            //MessageBox.Show(animThread.IsAlive.ToString());
        }

        public void SetView(object view)
        {
            LoginContent.Content = view;
        }

        

        private void animTask()
        {
            //Dispatcher.Invoke(() =>
            //{

            //    ThicknessAnimation welcomeAnimation = new ThicknessAnimation(lblWelcome.Padding,
            //        new Thickness(20, 0, 0, 0), new Duration(TimeSpan.FromMilliseconds(1800)));
            //    welcomeAnimation.EasingFunction = new QuarticEase();
            //    lblWelcome.BeginAnimation(PaddingProperty, welcomeAnimation);

            //    DoubleAnimation welcomeOpacityAnimation = new DoubleAnimation(lblWelcome.Opacity, Convert.ToDouble(1),
            //        new Duration(TimeSpan.FromMilliseconds(1800)));
            //    welcomeOpacityAnimation.EasingFunction = new QuadraticEase();
            //    lblWelcome.BeginAnimation(OpacityProperty,welcomeOpacityAnimation);


            //    ThicknessAnimation loginSideAnimation = new ThicknessAnimation(brdLoginSide.Margin,
            //        new Thickness(0, 0, 0, 0), new Duration(TimeSpan.FromMilliseconds(2100)));
            //    loginSideAnimation.EasingFunction = new QuarticEase();
            //    brdLoginSide.BeginAnimation(MarginProperty, loginSideAnimation);

            //    DoubleAnimation loginSideOpacityAnimation = new DoubleAnimation(brdLoginSide.Opacity, Convert.ToDouble(1),
            //        new Duration(TimeSpan.FromMilliseconds(2100)));
            //    loginSideOpacityAnimation.EasingFunction = new QuadraticEase();
            //    brdLoginSide.BeginAnimation(OpacityProperty, loginSideOpacityAnimation);




            //});

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //var user = _mnw.userService.Get(x => x.UserName == tbxUserName.Text);

            //if ( user != null)
            //{
            //    MessageBox.Show(user.Password == pbxUserPassword.Password ? "giriş başarılı!" : "Şifre hatalı");
            //}
            //else
            //{
            //    MessageBox.Show("böyle bir kullanıcı bulunmamaktadır!");
            //}

            
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            //brdLoginContent.Visibility = Visibility.Hidden;
            
        }
    }
}
