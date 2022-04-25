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
using BodyBuilder.Business.Abstract;
using BodyBuilder.Business.Concrete.Managers;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.DataAccess.Concrete.EntityFramework.DataAccessLayers;
using BodyBuilder.Entities.Concrete;
using BodyBuilder.WinUI.Layouts;
using Ninject;

namespace BodyBuilder.WinUI.Windows
{
    /// <summary>
    /// Interaction logic for AddWorkPage.xaml
    /// </summary>
    public partial class AddWorkPage : Window
    {
        private ScrollViewer _myScrollViewer;
        private WrapPanel _myStackPanel;
        public List<int> _selectedIndexes = new List<int>();
        private MainWindow _mnw = (MainWindow)Application.Current.MainWindow;
        private TrainManager _trainManager;
        private ProgramManager _programManager;
        private Customer _currenCustomer;
        private int _dayId;

        public AddWorkPage(int dayId,Customer currenCustomer)
        {
            InitializeComponent();
            _dayId = dayId;
            _trainManager = new TrainManager(_mnw.kernel.Get<ITrainDal>());
            _programManager = new ProgramManager(_mnw.kernel.Get<IProgramDal>());
            _currenCustomer = currenCustomer;
        }

        private void AddWorkPage_OnLoaded(object sender, RoutedEventArgs e)
        {

            _myScrollViewer = new ScrollViewer();
            _myScrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            _myScrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;

            // Add Layout control
            _myStackPanel = new WrapPanel();
            _myStackPanel.HorizontalAlignment = HorizontalAlignment.Left;
            _myStackPanel.VerticalAlignment = VerticalAlignment.Top;
            _myStackPanel.Orientation = Orientation.Horizontal;
            _myStackPanel.Width = 500;


            Refresh();
            
        }


        private void BtnClose_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TbxSearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            ClearCurrentView();
            foreach (var program in _trainManager.GetAll(x=>x.TrainingName.Contains(TbxSearchBar.Text)))
            {
                WorkOutControl control = new WorkOutControl( program.TrainingName,program.WorkAmount, true,trainingId:program.TrainingId);
                _myStackPanel.Children.Add(control);
            }

            _myScrollViewer.Content = _myStackPanel;
            Control.Content = _myScrollViewer;
        }

        public void Refresh()
        {
            ClearCurrentView();
            foreach (var program in _trainManager.GetAll())
            {

                WorkOutControl control = new WorkOutControl(program.TrainingName, program.WorkAmount, true,trainingId:program.TrainingId);
                _myStackPanel.Children.Add(control);

            }
            _myScrollViewer.Content = _myStackPanel;

            Control.Content = _myScrollViewer;

        }
        private void ClearCurrentView()
        {
            _myStackPanel.Children.Clear();
            Control.Content = null;
            _myScrollViewer.Content = null;
        }

        private void BtnAddWork_Click(object sender, RoutedEventArgs e)
        {
            CreateWorkWindow window = new CreateWorkWindow(_trainManager);
            GetScreen(window);
        }

        private void GetScreen(Window window)
        {
            window.Owner = this;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }

        private void BtnAccept_OnClick(object sender, RoutedEventArgs e)
        {
            if (_selectedIndexes.Count != 0)
            {
                foreach (var selectedIndex in _selectedIndexes)
                {
                    _programManager.Add(new Program()
                    {
                        CustomerId = _currenCustomer.CustomerId,
                        TrainingId = selectedIndex,
                        DayId = _dayId
                    });
                }

                Refresh();
                _selectedIndexes.Clear();
                TbxSearchBar.Text = "";

                foreach (Window window in Application.Current.Windows.OfType<CustomerProgramWindow>())
                    ((CustomerProgramWindow)window).SetView();

                MessageBox.Show("Ekleme işlemi başarılı!", "İşlem başarılı", MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
        }
    }
}
