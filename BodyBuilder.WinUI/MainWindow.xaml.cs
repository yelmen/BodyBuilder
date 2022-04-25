using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BodyBuilder.Business.Abstract;
using BodyBuilder.Business.Concrete.Managers;
using BodyBuilder.Business.DependencyResolvers.Ninject;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.Entities.Concrete;
using BodyBuilder.WinUI.Windows;
using Ninject;

namespace BodyBuilder.WinUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IKernel kernel = new StandardKernel(new BusinessModule());
        private bool _isEdit = false ;
        private Customer _currentCustomer;
        
        public Coach currentCoach;
        public CoachManager CoachManager;
        public CustomerManager CustomerManager;
        public MainWindow()
        {
            InitializeComponent();
            CoachManager = new CoachManager(kernel.Get<ICoachDal>());
            CustomerManager = new CustomerManager(kernel.Get<ICustomerDal>(),kernel.Get<IProgramDal>(),kernel.Get<ITrainDal>());
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Button sndButton = (Button)sender;
            if (sndButton.Name == "btnClose")
            {
                this.Close();
                
            }
            else
            {
                this.WindowState = WindowState.Minimized;
            }
        }

        public void RefreshData(IEnumerable<object> data,List<int> hiddenDataIndexList = null)
        {
            dgwCustomers.ItemsSource = data;
            if (hiddenDataIndexList != null)
            {
                foreach (var index in hiddenDataIndexList)
                {
                    dgwCustomers.Columns[index].Visibility = Visibility.Hidden;

                }
            }



        }


        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            dgwCustomers.ItemsSource = CustomerManager.GetAll(x => x.CoachId == currentCoach.CoachId);

            dgwCustomers.Columns[0].Visibility = Visibility.Hidden;
            dgwCustomers.Columns[9].Visibility = Visibility.Hidden;
            dgwCustomers.Columns[10].Visibility = Visibility.Hidden;
            dgwCustomers.Columns[11].Visibility = Visibility.Hidden;


        }

        private void BtnDynamicAction_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Content.ToString() == "Ekle")
            {
                Popup popup = new Popup("Abone Ekle");
                GetScreen(popup);

            }
            else
            {
                CustomerProgramWindow customerWindow = new CustomerProgramWindow(_currentCustomer,CustomerManager);
                GetScreen(customerWindow);

            }
            

        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void BtnDynamicActionLeft_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Content.ToString() == "Sil")
            {
                if (dgwCustomers.SelectedItem != null)
                {
                    Customer selectedCustomer = (Customer)dgwCustomers.SelectedItem;
                    MessageBoxResult result = MessageBox.Show(string.Format("{0} {1} adlı müşteriyi silmek istiyor musunuz ?",
                        selectedCustomer.CustomerName, selectedCustomer.CustomerSurname), "Uyarı", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        CustomerManager.Delete(selectedCustomer);
                        RefreshData(CustomerManager.GetAll(x => x.CoachId == currentCoach.CoachId), new List<int>() { 0, 9 });
                    }

                }
            }
            else
            {
                Popup popup = new Popup("Düzenle",((Customer)dgwCustomers.SelectedItem));
                GetScreen(popup);

            }

        }

        private void DgwCustomers_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            _currentCustomer = (Customer)dgwCustomers.SelectedItem;
            ChangeState();
        }

        private void ChangeState()
        {
            if (!_isEdit)
            {
                _isEdit = true;
                BtnDynamicActionRight.Content = "Programı gör";
                BtnDynamicActionLeft.Content = "Düzenle";
            }
          
            

        }

        private void DgwCustomers_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _isEdit = false;
            BtnDynamicActionRight.Content = "Ekle";
            _currentCustomer = null;
            BtnDynamicActionLeft.Content = "Sil";
        }

        private void DgwCustomers_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                _isEdit = false;
                BtnDynamicActionRight.Content = "Ekle";
                BtnDynamicActionLeft.Content = "Sil";
                dgwCustomers.SelectedItem = null;
                _currentCustomer = null;
            }

        }

        private void GetScreen(Window window)
        {
            window.Owner = this;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
    }
}
