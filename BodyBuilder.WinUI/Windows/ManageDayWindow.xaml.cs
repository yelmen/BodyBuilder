using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BodyBuilder.Business.Concrete.Managers;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.Entities.Concrete;
using BodyBuilder.WinUI.MVVM.View;
using Ninject;

namespace BodyBuilder.WinUI.Windows
{
    /// <summary>
    /// Interaction logic for ManageDayWindow.xaml
    /// </summary>
    public partial class ManageDayWindow : Window
    {
        public DaySelectView daySelectView;
        public DayAddView dayAddView;
        private MainWindow _mnw;
        public WorkDayManager DayManager;
        private Customer _currentCustomer;
        public ManageDayWindow(Customer currentCustomer)
        {
            InitializeComponent();
            _mnw = (MainWindow)Application.Current.MainWindow;
            DayManager = new WorkDayManager(_mnw.kernel.Get<IWorkDayDal>());
            _currentCustomer = currentCustomer;
            daySelectView = new DaySelectView(currentCustomer);
            dayAddView = new DayAddView();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ManageDayWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            BodyContent.Content = daySelectView;
            

        }

        private void ManageDayWindow_OnClosing(object sender, CancelEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            e.Cancel = true;
        }
    }
}
