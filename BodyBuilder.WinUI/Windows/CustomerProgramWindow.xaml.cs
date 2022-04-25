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
using System.Windows.Shapes;
using BodyBuilder.Business.Concrete.Managers;
using BodyBuilder.Entities.Concrete;
using BodyBuilder.WinUI.Layouts;

namespace BodyBuilder.WinUI.Windows
{
    /// <summary>
    /// Interaction logic for CustomerProgramWindow.xaml
    /// </summary>
    public partial class CustomerProgramWindow : Window
    {
        private Customer _currentCustomer;
        private CustomerManager _customerManager;
        private DayControl _currenDayControl;
        private ScrollViewer _myScrollViewer;
        private StackPanel _myStackPanel;
        private ManageDayWindow _dayWindow;


        public CustomerProgramWindow(Customer customer,CustomerManager manager)
        {
            InitializeComponent();
            _currentCustomer = customer;
            _customerManager = manager;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void CustomerProgramWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            _myScrollViewer = new ScrollViewer();
            _myScrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;

            // Add Layout control
            _myStackPanel = new StackPanel();
            _myStackPanel.HorizontalAlignment = HorizontalAlignment.Left;
            _myStackPanel.VerticalAlignment = VerticalAlignment.Top;

            SetView();
            
        }

        public void SetView()
        {
            if (control.Content != null)
            {
                control.Content = null;
                _myStackPanel.Children.Clear();
                
            }

            List<string> days = new List<string>();


            foreach (var x in _customerManager.GetDaysByCustomerId(_currentCustomer.CustomerId))
            {
                // is the day Same ?
                if (days.Contains(x.DayName))
                {
                    //
                }
                else
                {
                    _currenDayControl = new DayControl(x.DayId, Convert.ToInt32(this.Width), x.DayName,this,_currentCustomer);
                    foreach (var workProgram in _customerManager.GetProgramsByCustomerId(_currentCustomer.CustomerId, x.DayName))
                    {
                        WorkOutControl control = new WorkOutControl( workProgram.TrainName, workProgram.WorkAmount,programId: workProgram.ProgramId);
                        _currenDayControl.AddWork(control);
                    }
                    _myStackPanel.Children.Add(_currenDayControl);
                    days.Add(x.DayName);
                }

            }


            _myScrollViewer.Content = _myStackPanel;

            control.Content = _myScrollViewer;
        }

        private void BtnAddDay_Click(object sender, RoutedEventArgs e)
        {
            _dayWindow = new ManageDayWindow(_currentCustomer);
            GetScreen(_dayWindow);
        }
        private void GetScreen(Window window)
        {
            window.Owner = this;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
    }
}
