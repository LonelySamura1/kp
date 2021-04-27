using KP.Classes;
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

namespace KP.Forms.MasterForms
{
    /// <summary>
    /// Логика взаимодействия для MasterForm.xaml
    /// </summary>
    public partial class MasterForm : Window
    {
        public struct OrderStruct
        {
            public int ID { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public double price { get; set; }
            public string box { get; set; }
            public string Client { get; set; }
            public string Material { get; set; }
            public string Service { get; set; }
            public string Worker { get; set; }
            public OrderStruct(int ID, DateTime StartTime, DateTime? EndTime, double? price, string box, string Client, string Material, string Service, string Worker) : this()
            {
                this.ID = ID;
                this.StartTime = StartTime;
                if (EndTime == null)
                {
                    this.EndTime = StartTime;
                }
                else
                {
                    this.EndTime = (DateTime)EndTime;
                }
                if (price == null)
                {
                    this.price = 0;
                }
                else
                {
                    this.price = (double)price;
                }
                this.box = box;
                this.Client = Client;
                this.Material = Material;
                this.Service = Service;
                this.Worker = Worker;
            }
        }
        public List<OrderStruct> StructsList = new List<OrderStruct>();
        public void UpdateGrid()
        {
            var tmp = MyDBContext.DBContext.Orders.ToList();
            for (int i = 0; i < tmp.Count; i++)
            {
                string tempBox = tmp[i].Boxes.BoxType;
                string tempClient = tmp[i].Client.Surname + " " + tmp[i].Client.Name + " " + tmp[i].Client.Lastname;
                string TempMaterial = tmp[i].Material.MaterialName;
                string TempService = tmp[i].Services.ServiceName;
                string tempWorker = tmp[i].Worker.Surname + " " + tmp[i].Worker.Name + " " + tmp[i].Worker.Lastname;
                StructsList.Add(new OrderStruct(tmp[i].OrderID, tmp[i].StartTime, tmp[i].EndTime, tmp[i].Price, tempBox, tempClient, TempMaterial, TempService, tempWorker));
            }
            OrdersGrid.ItemsSource = StructsList;
            OrdersGrid.Columns[0].Header = "Номер заказа";
            OrdersGrid.Columns[1].Header = "Время состовления";
            OrdersGrid.Columns[2].Header = "Время выполнения";
            OrdersGrid.Columns[3].Header = "Цена";
            OrdersGrid.Columns[4].Header = "Бокс";
            OrdersGrid.Columns[5].Header = "Клиент";
            OrdersGrid.Columns[6].Header = "Материал";
            OrdersGrid.Columns[7].Header = "Услуга";
            OrdersGrid.Columns[8].Header = "Сотрудник";

        }
        public MasterForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateGrid();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OrderStruct temp = (OrderStruct)this.OrdersGrid.SelectedItem;
            var req = (from t in MyDBContext.DBContext.Orders.ToList<Classes.Order>()
                       where t.OrderID == temp.ID
                       select t).ToList();
            CloseOrderForm cof = new CloseOrderForm(req[0], this);
            cof.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MaterialsAdd materialsAdd = new MaterialsAdd();
            materialsAdd.ShowDialog();
        }
    }
}
