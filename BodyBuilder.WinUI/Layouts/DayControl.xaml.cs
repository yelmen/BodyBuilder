using System;
using System.Collections;
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

namespace BodyBuilder.WinUI.Layouts
{
    /// <summary>
    /// Interaction logic for DayControl.xaml
    /// </summary>
    public partial class DayControl : UserControl
    {
        private StackPanel _myStackPanel = new StackPanel();
        private CustomerProgramWindow _owner;
        private MainWindow _mnw = (MainWindow)Application.Current.MainWindow;
        private Customer _currenCustomer;
        private ProgramManager _manager;
        private int _dayId;
        public DayControl(int dayId,int width,string dayName,Window owner,Customer currentCustomer)
        {
            InitializeComponent();
            this.Width = width-50;
            Control.MaxWidth = Convert.ToDouble(width - 50);
            DayName.Content = dayName;
            _owner = (CustomerProgramWindow)owner;
            _dayId = dayId;
            _currenCustomer = currentCustomer;
            _manager = new ProgramManager(_mnw.kernel.Get<IProgramDal>());
        }


        private void DayControl_OnLoaded(object sender, RoutedEventArgs e)
        {
            var myScrollViewer = new ScrollViewer();
            myScrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            myScrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;

            // Add Layout control

            _myStackPanel.Orientation = Orientation.Horizontal;



            myScrollViewer.Content = _myStackPanel;

            Control.Content = myScrollViewer;

        }

        public void AddWork(WorkOutControl workControl)
        {
            _myStackPanel.Children.Add(workControl);

        }


        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            GetScreen(new AddWorkPage(_dayId,_currenCustomer),_owner);
        }

        private void GetScreen(Window window,Window owner)
        {
            window.Owner = owner;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }

        private void BtnDeleteAll_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Tüm kayıdı silmek istediğinizden emin misiniz ?", "Uyarı",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                foreach (WorkOutControl workOutControl in _myStackPanel.Children)
                {
                    _manager.Delete(_manager.Get(x => x.ProgramId == workOutControl._programId && x.CustomerId == _currenCustomer.CustomerId));

                }

                foreach (var day in _manager.GetAll(x=>x.DayId == _dayId && x.CustomerId == _currenCustomer.CustomerId))
                {
                    _manager.Delete(day);
                }
                
            }

            _owner.SetView();
            
        }
    }
}
