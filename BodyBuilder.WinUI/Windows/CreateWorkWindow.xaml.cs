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

namespace BodyBuilder.WinUI.Windows
{
    /// <summary>
    /// Interaction logic for CreateWorkWindow.xaml
    /// </summary>
    public partial class CreateWorkWindow : Window
    {
        private TrainManager _manager;

        public CreateWorkWindow(TrainManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CreateWorkWindow_OnLoaded(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {
            if (TbxMoveAmount.Text != "" && TbxMoveName.Text != "" )
            {

                _manager.Add(new Training()
                {
                    TrainingName = TbxMoveName.Text,
                    WorkAmount = TbxMoveAmount.Text
                });
                MessageBox.Show("Ekleme işlemi başarılı!", "İşlem başarıyla tamamlandı", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                TbxMoveAmount.Text = "";
                TbxMoveName.Text = "";
                foreach (Window window in Application.Current.Windows.OfType<AddWorkPage>())
                    ((AddWorkPage)window).Refresh();
            }
            else
            {
                MessageBox.Show("Alanlar boş bırakılmamalıdır!", "Uyarı", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
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

    }
}
