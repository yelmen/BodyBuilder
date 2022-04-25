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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BodyBuilder.WinUI.MVVM.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        private MainWindow _mnw = (MainWindow)Application.Current.MainWindow;
        private LoginPage parent;
        public LoginView()
        {
            InitializeComponent();
        }

        private void BtnLogin_OnClick(object sender, RoutedEventArgs e)
        {
            var user = _mnw.CoachManager.Get(x => x.CoachUsername == tbxUserName.Text);

            if (user != null)
            {
                if (user.CoahPassword == pbxUserPassword.Password)
                {
                    _mnw.currentCoach = user;
                    parent.getWindow();
                }
            }
            else
            {
                MessageBox.Show("böyle bir kullanıcı bulunmamaktadır!");
            }
        }

        private void BtnRegister_OnClick(object sender, RoutedEventArgs e)
        {
            parent.LoginContent.Content = parent.RegisterView;
        }

        public static Window FindParentWindow(DependencyObject child)
        {
            DependencyObject parent = VisualTreeHelper.GetParent(child);

            //CHeck if this is the end of the tree
            if (parent == null) return null;

            Window parentWindow = parent as Window;
            if (parentWindow != null)
            {
                return parentWindow;
            }
            else
            {
                //use recursion until it reaches a Window
                return FindParentWindow(parent);
            }
        }

        private void LoginView_OnLoaded(object sender, RoutedEventArgs e)
        {
            Thread animThread = new Thread(animTask);
            animThread.Name = "Animation Thread";
            animThread.Start(); 
            parent = (LoginPage)FindParentWindow(this);

        }
        private void animTask()
        {
            Dispatcher.Invoke(() =>
            {

                ThicknessAnimation welcomeAnimation = new ThicknessAnimation(lblWelcome.Padding,
                    new Thickness(20, 0, 0, 0), new Duration(TimeSpan.FromMilliseconds(1800)));
                welcomeAnimation.EasingFunction = new QuarticEase();
                lblWelcome.BeginAnimation(PaddingProperty, welcomeAnimation);

                DoubleAnimation welcomeOpacityAnimation = new DoubleAnimation(lblWelcome.Opacity, Convert.ToDouble(1),
                    new Duration(TimeSpan.FromMilliseconds(1800)));
                welcomeOpacityAnimation.EasingFunction = new QuadraticEase();
                lblWelcome.BeginAnimation(OpacityProperty, welcomeOpacityAnimation);


                ThicknessAnimation loginSideAnimation = new ThicknessAnimation(brdLoginSide.Margin,
                    new Thickness(0, 0, 0, 0), new Duration(TimeSpan.FromMilliseconds(2100)));
                loginSideAnimation.EasingFunction = new QuarticEase();
                brdLoginSide.BeginAnimation(MarginProperty, loginSideAnimation);

                DoubleAnimation loginSideOpacityAnimation = new DoubleAnimation(brdLoginSide.Opacity, Convert.ToDouble(1),
                    new Duration(TimeSpan.FromMilliseconds(2100)));
                loginSideOpacityAnimation.EasingFunction = new QuadraticEase();
                brdLoginSide.BeginAnimation(OpacityProperty, loginSideOpacityAnimation);




            });

        }
    }
}
