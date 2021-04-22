using KP.Classes;
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

namespace KP.Forms.MasterForms
{
    /// <summary>
    /// Логика взаимодействия для CloseOrderForm.xaml
    /// </summary>
    public partial class CloseOrderForm : Window
    {
        Order CloseOrder;
        MasterForm refer;
        public CloseOrderForm(Order order, MasterForm mf)
        {
            InitializeComponent();
            CloseOrder = order;
            refer = mf;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CloseOrder.EndTime = DateTime.Now;
            CloseOrder.Price = Convert.ToDouble(Pricetxt.Text);
            MyDBContext.DBContext.Orders.AddOrUpdate(CloseOrder);
            MyDBContext.DBContext.SaveChanges();
            refer.UpdateGrid();
            this.Close();
        }
    }
}
