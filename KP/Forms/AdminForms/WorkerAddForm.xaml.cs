using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
using WFAEntity.API;
using WpfApp1.Classes;

namespace KP.Forms.AdminForms
{
    /// <summary>
    /// Логика взаимодействия для WorkerAddForm.xaml
    /// </summary>
    public partial class WorkerAddForm : Window
    {
        AdminForm AF;
        bool IsEdit = false;
        Worker EditWorker;
        public WorkerAddForm(AdminForm AF)
        {
            this.AF = AF;
            InitializeComponent();
        }
        public WorkerAddForm(AdminForm AF, Worker EditWorker)
        {
            IsEdit = true;
            this.AF = AF;
            this.EditWorker = EditWorker;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsEdit)
            {
                NameBox.Text = EditWorker.Name;
                SurnameBox.Text = EditWorker.Surname;
                LastNameBox.Text = EditWorker.Lastname;
                PhoneBox.Text = EditWorker.Phone;
                LoginBox.Text = EditWorker.Login;
                PasswordBox.Text = EditWorker.Password;
                WorkerDatePicker.SelectedDate = EditWorker.Birthday;
                AdressBox.Text = EditWorker.Adress;
                AccessCombo.SelectedIndex = 0;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!IsEdit)
            {
                if (!String.IsNullOrWhiteSpace(NameBox.Text) && !String.IsNullOrWhiteSpace(SurnameBox.Text) && !String.IsNullOrWhiteSpace(LastNameBox.Text)
                    && WorkerDatePicker.SelectedDate != null && !String.IsNullOrWhiteSpace(PhoneBox.Text) && !String.IsNullOrWhiteSpace(LoginBox.Text) && !String.IsNullOrWhiteSpace(PasswordBox.Text))
                {
                    Worker WorkerObj = new Worker();
                    int Temp = MyDBContext.DBContext.Workers.Count();
                    WorkerObj.WorkerID = Temp++;
                    WorkerObj.Name = NameBox.Text;
                    WorkerObj.Surname = SurnameBox.Text;
                    WorkerObj.Lastname = LastNameBox.Text;
                    WorkerObj.Adress = AdressBox.Text;
                    WorkerObj.Birthday = (DateTime)WorkerDatePicker.SelectedDate;
                    WorkerObj.Phone = PhoneBox.Text;
                    WorkerObj.Login = LoginBox.Text;
                    WorkerObj.Password = PasswordBox.Text;

                    if (AccessCombo.SelectedIndex == 1)
                    {
                        WorkerObj.Specialize = "Мастер";
                    }
                    if (AccessCombo.SelectedIndex == 0)
                    {
                        WorkerObj.Specialize = "Администратор";
                    }
                    if (AccessCombo.SelectedIndex == 2)
                    {
                        WorkerObj.Specialize = "Приемщик";
                    }
                    MyDBContext.DBContext.Workers.Add(WorkerObj);
                    NameBox.Text = String.Empty;
                    SurnameBox.Text = String.Empty;
                    LastNameBox.Text = String.Empty;
                    PhoneBox.Text = String.Empty;
                    LoginBox.Text = String.Empty;
                    PasswordBox.Text = String.Empty;
                    MyDBContext.DBContext.SaveChanges();
                    AF.UpdateGrid();
                }
                else
                {
                    MessageBox.Show("Заполните все данные!");
                }
            }
            else
            {
                EditWorker.Name = NameBox.Text;
                EditWorker.Surname = SurnameBox.Text;
                EditWorker.Lastname = LastNameBox.Text;
                EditWorker.Phone = PhoneBox.Text;
                EditWorker.Login = LoginBox.Text;
                EditWorker.Password = PasswordBox.Text;
                EditWorker.Birthday = (DateTime)WorkerDatePicker.SelectedDate;
                EditWorker.Adress = AdressBox.Text;
                if (AccessCombo.SelectedIndex == 1)
                {
                    EditWorker.Specialize = "Мастер";
                }
                if (AccessCombo.SelectedIndex == 0)
                {
                    EditWorker.Specialize = "Администратор";
                }
                if (AccessCombo.SelectedIndex == 2)
                {
                    EditWorker.Specialize = "Приемщик";
                }
                MyDBContext.DBContext.Workers.AddOrUpdate(EditWorker);
                MyDBContext.DBContext.SaveChanges();
                AF.UpdateGrid();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
