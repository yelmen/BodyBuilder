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
using BodyBuilder.Business.Abstract;
using BodyBuilder.Business.Concrete.Managers;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.DataAccess.Concrete.EntityFramework.DataAccessLayers;
using BodyBuilder.WinUI.Windows;
using Ninject;

namespace BodyBuilder.WinUI.Layouts
{
    /// <summary>
    /// Interaction logic for WorkOutControl.xaml
    /// </summary>
    public partial class WorkOutControl : UserControl
    {
        private string _workName;
        private string _workAmount;
        public int _programId;
        private IProgramService _programService;
        private MainWindow _mnw;
        private CustomerProgramWindow _customerParentWindow;
        private AddWorkPage _workParentWindow;
        private bool _selectionMode;
        private bool _isSelected;
        private int _trainingId;

        public WorkOutControl(string workName,string workAmount = "",bool selectionMode = false, int programId = 0,int trainingId = 0)
        {
            InitializeComponent();
            _mnw = (MainWindow)Application.Current.MainWindow;
            _workName = workName;
            _workAmount = workAmount;
            _programId = programId;
            _programService = new ProgramManager(_mnw.kernel.Get<IProgramDal>());
            _selectionMode = selectionMode;
            _trainingId = trainingId;
        }

        private void WorkOutControl_OnLoaded(object sender, RoutedEventArgs e)
        {
            WorkName.Text = _workName;
            WorkCount.Content = _workAmount;
            if (_selectionMode)
            {
                _workParentWindow = (AddWorkPage)FindParentWindow(this);
            }
            else
            {
                _customerParentWindow = (CustomerProgramWindow)FindParentWindow(this);
            }

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bu programı silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                _programService.Delete(_programService.GetById(_programId));
                _customerParentWindow.SetView();
            }
        }

        private void UIElement_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (!_selectionMode) { 
                BtnWorkDelete.Visibility = Visibility.Visible;
                WorkCount.Visibility = Visibility.Visible;
            }
            else if (_selectionMode && e.LeftButton == MouseButtonState.Pressed && !_isSelected)    
            {
                BorderContent.Background = Brushes.DimGray;
                _isSelected = !_isSelected;
                _workParentWindow._selectedIndexes.Add(_trainingId);

            }
            else if (_selectionMode && e.RightButton == MouseButtonState.Pressed && _isSelected)
            {
                BorderContent.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD9D9D9"));
                _isSelected = !_isSelected;
                _workParentWindow._selectedIndexes.Remove(_trainingId);

            }


        }

        private void UIElement_OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (!_selectionMode)
                BtnWorkDelete.Visibility = Visibility.Hidden;
            
        }

        private void BorderContent_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_selectionMode)
            {
                if (e.LeftButton == MouseButtonState.Pressed && !_isSelected)
                {
                    BorderContent.Background = Brushes.DimGray;
                    _isSelected = !_isSelected;
                    _workParentWindow._selectedIndexes.Add(_trainingId);

                }else if (e.RightButton == MouseButtonState.Pressed && _isSelected)
                {
                    BorderContent.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD9D9D9"));
                    _isSelected = !_isSelected;

                    _workParentWindow._selectedIndexes.Remove(_trainingId);
                }
            }
           
        }
    }
}
