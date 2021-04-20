using KP.Forms.AdminForms;
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
using WFAEntity.API;
using WpfApp1.Classes;

namespace KP.Forms
{
    /// <summary>
    /// Логика взаимодействия для AdminForm.xaml
    /// </summary>
    public partial class AdminForm : Window
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        public void UpdateGrid()
        {
            WorkersGrid.ItemsSource = MyDBContext.DBContext.Workers.ToList();
            WorkersGrid.Columns[0].Header = "ID сотрудника";
            WorkersGrid.Columns[1].Header = "Имя";
            WorkersGrid.Columns[2].Header = "Фамилия";
            WorkersGrid.Columns[3].Header = "Отчество";
            WorkersGrid.Columns[4].Header = "Дата рождения";
            WorkersGrid.Columns[5].Header = "Специальность";
            WorkersGrid.Columns[6].Header = "Номер телефона";
            WorkersGrid.Columns[7].Visibility = Visibility.Hidden;
            WorkersGrid.Columns[8].Visibility = Visibility.Hidden;
            WorkersGrid.Columns[9].Header = "Адрес";
            WorkersGrid.Columns[10].Visibility = Visibility.Hidden;
            WorkersGrid.Columns[11].Visibility = Visibility.Hidden;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WorkerAddForm WAF = new WorkerAddForm(this);
            WAF.ShowDialog();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            WorkerAddForm WAF = new WorkerAddForm(this, (Worker)WorkersGrid.SelectedItem);
            WAF.ShowDialog();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Worker wrk = (Worker)WorkersGrid.SelectedItem;
            MyDBContext.DBContext.Workers.Remove(wrk);
            UpdateGrid();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Services SRV = new Services();
            SRV.ShowDialog();
        }
    }
}
