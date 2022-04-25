using BodyBuilder.Core.Entities;
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
    /// Interaction logic for Popup.xaml
    /// </summary>
    public partial class Popup : Window
    {
        private Customer _entity ;
        private MainWindow _mnw = (MainWindow)Application.Current.MainWindow;
        private CustomerManager _manager;
        private CustomerManager.FitTypes _fitType = CustomerManager.FitTypes.Special;
        public Popup()
        {
            InitializeComponent();
        }

        public Popup(string title,IEntity entity=null)
        {
            InitializeComponent();
            WindowText.Content = title;
            if (entity != null)
            {
                _entity = (Customer)entity;
            }

            _manager = _mnw.CustomerManager;

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

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (_entity != null)
            {
                if (EndDatePicker.SelectedDate.Value != null && StartDatePicker.SelectedDate.Value != null)
                {
                    _entity.CoachId = _mnw.currentCoach.CoachId;
                    _entity.CustomerAddress = TxtAddress.Text;
                    _entity.CustomerAge = Convert.ToInt32(TxtAge.Text);
                    _entity.CustomerName = TxtName.Text;
                    _entity.CustomerPhone = TxtPhoneNumber.Text;
                    _entity.CustomerSize = Convert.ToDouble(TxtSize.Text);
                    _entity.CustomerSurname = TxtSurname.Text;
                    _entity.CustomerTc = TxtIdentity.Text;
                    _entity.CustomerWeight = Convert.ToDouble(TxtWeight.Text);
                    _entity.endDate = EndDatePicker.SelectedDate.Value;
                    _entity.startDate = StartDatePicker.SelectedDate.Value;

                    _mnw.CustomerManager.Update(_entity);
                    _mnw.RefreshData(_mnw.CustomerManager.GetAll(x => x.CoachId == _mnw.currentCoach.CoachId),
                        new List<int>() { 0, 9 ,10,11});
                    MessageBox.Show("Güncelleme işlemi tamamlandı!");
                    this.Close();
                }
            }
            else
            {
                if (EndDatePicker.SelectedDate.Value != null && StartDatePicker.SelectedDate.Value != null)
                {
                    Customer _addedCustomer = new Customer()
                    {
                        CoachId = _mnw.currentCoach.CoachId,
                        CustomerAddress = TxtAddress.Text,
                        CustomerAge = Convert.ToInt32(TxtAge.Text),
                        CustomerName = TxtName.Text,
                        CustomerPhone = TxtPhoneNumber.Text,
                        CustomerSize = Convert.ToDouble(TxtSize.Text),
                        CustomerSurname = TxtSurname.Text,
                        CustomerTc = TxtIdentity.Text,
                        CustomerWeight = Convert.ToDouble(TxtWeight.Text),
                        endDate = EndDatePicker.SelectedDate.Value,
                        startDate = StartDatePicker.SelectedDate.Value,

                    };



                    _manager.Add(_addedCustomer, _fitType);
  

                    _mnw.RefreshData(_mnw.CustomerManager.GetAll(x => x.CoachId == _mnw.currentCoach.CoachId),
                        new List<int>() { 0, 9 ,10,11});
                    MessageBox.Show("Başarıyla Eklendi!");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("alanlar boş bırakılmamalıdır");
                }
            }
            
            
            
            
        }

        private void Popup_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (_entity != null)
            {
                TxtAddress.Text = _entity.CustomerAddress;
                TxtAge.Text = _entity.CustomerAge.ToString();
                TxtName.Text = _entity.CustomerName;
                TxtPhoneNumber.Text = _entity.CustomerPhone;
                TxtSize.Text = _entity.CustomerSize.ToString();
                TxtSurname.Text = _entity.CustomerSurname;
                TxtIdentity.Text = _entity.CustomerTc;
                TxtWeight.Text = _entity.CustomerWeight.ToString();
                EndDatePicker.SelectedDate = _entity.endDate;
                StartDatePicker.SelectedDate = _entity.startDate;
                BrdBodyType.Visibility = Visibility.Hidden;
            }

            else
            {
                StartDatePicker.SelectedDate = DateTime.Now;
                EndDatePicker.SelectedDate = DateTime.Now.AddMonths(3);
            }

        }

        private void EditEndDate(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "BtnOne")
            {
                DateTime oneYear = ((DateTime)StartDatePicker.SelectedDate).AddYears(1);
                EndDatePicker.SelectedDate = oneYear;

            }
            else if (btn.Name == "BtnThree")
            {
                DateTime threeMonth = ((DateTime)StartDatePicker.SelectedDate).AddMonths(3);
                EndDatePicker.SelectedDate = threeMonth;
            }
            else
            {
                DateTime sixMonth = ((DateTime)StartDatePicker.SelectedDate).AddMonths(6);
                EndDatePicker.SelectedDate = sixMonth;
            }
        }

        private void SetBodyType(object sender, RoutedEventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            if (btn.Name == "RbtBodyBuild")
            {
                _fitType = CustomerManager.FitTypes.BodyBuild;
            }else if (btn.Name == "RbtBeginner")
            {
                _fitType = CustomerManager.FitTypes.Starter;
            }else if (btn.Name == "RbtLosingWeight")
            {
                _fitType = CustomerManager.FitTypes.LosingWeight;
            }
            else
            {
                _fitType = CustomerManager.FitTypes.Special;
            }
        }
    }
}
