using KP.Classes;
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

namespace KP.Forms.RegistratorForms
{
    /// <summary>
    /// Логика взаимодействия для OrderAdd.xaml
    /// </summary>
    public partial class OrderAdd : Window
    {
        OrdersForm OF;
        public OrderAdd(OrdersForm OF)
        {
            this.OF = OF;
            InitializeComponent();
        }
        public void UpdateGrid()
        {
            BoxBox.ItemsSource = MyDBContext.DBContext.Boxes.ToList();
            BoxBox.DisplayMemberPath = "BoxType";
            materialBox.ItemsSource = MyDBContext.DBContext.Materials.ToList();
            materialBox.DisplayMemberPath = "MaterialName";
            ServiceBox.ItemsSource = MyDBContext.DBContext.Services.ToList();
            ServiceBox.DisplayMemberPath = "ServiceName";

            ClientBox.ItemsSource = MyDBContext.DBContext.Clients.ToList();
            ClientBox.DisplayMemberPath = "Surname";

            WorkerBox.ItemsSource = MyDBContext.DBContext.Workers.ToList();
            WorkerBox.DisplayMemberPath = "Surname";
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateGrid();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Order ord = new Order();
            ord.OrderID = MyDBContext.DBContext.Orders.Count();
            ord.OrderID++;
            ord.StartTime = DateTime.Now;
            ord.Boxes = (Boxes)BoxBox.SelectedItem;
            ord.Client = (Client)ClientBox.SelectedItem;
            ord.Worker = (Worker)WorkerBox.SelectedItem;
            ord.Services = (Services)ServiceBox.SelectedItem;
            ord.Material = (Material)materialBox.SelectedItem;
            MyDBContext.DBContext.Orders.Add(ord);
            MyDBContext.DBContext.SaveChanges();
            UpdateGrid();
            MessageBox.Show("Добавлено!");
        }
    }
}
