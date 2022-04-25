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
using BodyBuilder.Entities.Concrete;
using BodyBuilder.WinUI.Windows;

namespace BodyBuilder.WinUI.MVVM.View
{
    /// <summary>
    /// Interaction logic for DayAddView.xaml
    /// </summary>
    public partial class DayAddView : UserControl
    {
        private WorkDayManager _manager;
        private ManageDayWindow _parent;
        public DayAddView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TbxDayName.Text != "")
            {
                _manager.Add(new WorkDay() { DayName = TbxDayName.Text });
                MessageBox.Show("Ekleme işlemi başarılı", "İşlem başarılı", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                TbxDayName.Text = "";
            }
        }

        private void DayAddView_OnLoaded(object sender, RoutedEventArgs e)
        {
            //foreach (Window window in Application.Current.Windows.OfType<ManageDayWindow>())
            //    _manager = ((ManageDayWindow)window).DayManager;

            _parent = (ManageDayWindow)FindParentWindow(this);
            _manager = _parent.DayManager;
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

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            TbxDayName.Text = "";
            _parent.BodyContent.Content = null;
            _parent.BodyContent.Content = _parent.daySelectView;
        }
    }
}
