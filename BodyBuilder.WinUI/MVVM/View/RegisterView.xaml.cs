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
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.WinUI.MVVM.View
{
    /// <summary>
    /// Interaction logic for RegisterView.xaml
    /// </summary>
    public partial class RegisterView : UserControl
    {
        private LoginPage parent;
        public RegisterView()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            parent.LoginContent.Content = parent.loginView;
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

        private void RegisterView_OnLoaded(object sender, RoutedEventArgs e)
        {
            parent = (LoginPage)FindParentWindow(this);
            Thread animThread = new Thread(animTask);
            animThread.Name = "Animation Thread";
            animThread.Start();

        }

        private void animTask()
        {
            Dispatcher.Invoke(() =>
            {

                ThicknessAnimation RegisterAnimation = new ThicknessAnimation(lblRegister.Margin,
                    new Thickness(20, -50, 0, 0), new Duration(TimeSpan.FromMilliseconds(2200)));
                RegisterAnimation.EasingFunction = new QuarticEase();
                lblRegister.BeginAnimation(MarginProperty, RegisterAnimation);

                DoubleAnimation sizeAnimation = new DoubleAnimation(lblRegister.FontSize, 26,
                    new Duration(TimeSpan.FromMilliseconds(1800)));
                sizeAnimation.EasingFunction = new QuadraticEase();
                lblRegister.BeginAnimation(FontSizeProperty,sizeAnimation);

                DoubleAnimation formOpacityAnimation = new DoubleAnimation(pnlForm.Opacity, Convert.ToDouble(1),
                    new Duration(TimeSpan.FromMilliseconds(1800)));
                formOpacityAnimation.EasingFunction = new QuadraticEase();
                pnlForm.BeginAnimation(OpacityProperty, formOpacityAnimation);


                ThicknessAnimation loginSideAnimation = new ThicknessAnimation(brdForm.Margin,
                    new Thickness(0, 10, 0, 0), new Duration(TimeSpan.FromMilliseconds(2100)));
                loginSideAnimation.EasingFunction = new QuarticEase();
                brdForm.BeginAnimation(MarginProperty, loginSideAnimation);





            });

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Coach user = new Coach()
                {
                    CoachName = tbxName.Text,
                    CoahPassword = pbxUserPassword.Password,
                    CoachSurname = tbxSurname.Text,
                    CoachUsername = tbxUserName.Text
                };
                ((MainWindow)Application.Current.MainWindow).CoachManager.Add(user);
                MessageBox.Show("Kayıt işlemi başarılı!");
                parent.LoginContent.Content = parent.loginView;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            

        }
    }
}
