using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BodyBuilder.Business.Concrete.Managers;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.Entities.Concrete;
using BodyBuilder.WinUI.Windows;
using Ninject;

namespace BodyBuilder.WinUI.MVVM.View
{
    /// <summary>
    /// Interaction logic for DaySelectView.xaml
    /// </summary>
    public partial class DaySelectView : UserControl
    {
        private ManageDayWindow _manageDay;
        private MainWindow _mnw;
        private ProgramManager _programManager;
        private Customer _currentCustomer;
        public DaySelectView(Customer currentCustomer)
        {
            InitializeComponent();
            _currentCustomer = currentCustomer;
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

        private void DaySelectView_OnLoaded(object sender, RoutedEventArgs e)
        {
            _manageDay = (ManageDayWindow)FindParentWindow(this);
            _mnw = (MainWindow)Application.Current.MainWindow;
            _programManager = new ProgramManager(_mnw.kernel.Get<IProgramDal>());

            try
            {
                CbxSelectDay.DisplayMemberPath = "DayName";
                CbxSelectDay.SelectedIndex = 0;
                CbxSelectDay.ItemsSource = _manageDay.DayManager.GetAll();
            }
            catch (Exception exception)
            {
                Console.WriteLine("İşlem sırasında bir hata oluştu");
                throw;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _programManager.Add(new Program()
            {
                CustomerId = _currentCustomer.CustomerId,
                DayId = ((WorkDay)CbxSelectDay.SelectedItem).DayId,
                TrainingId = null
            });

            foreach (Window window in Application.Current.Windows.OfType<CustomerProgramWindow>())
                ((CustomerProgramWindow)window).SetView();
        }

        private void BtnAddDay_Click(object sender, RoutedEventArgs e)
        {
            _manageDay.BodyContent.Content = null;
            _manageDay.BodyContent.Content = _manageDay.dayAddView;
        }
    }
}
