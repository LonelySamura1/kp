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

namespace KP.Forms.AdminForms
{
    /// <summary>
    /// Логика взаимодействия для Services.xaml
    /// </summary>
    public partial class Services : Window
    {
        public Services()
        {
            InitializeComponent();
        }

        public void UpdateList()
        {
            ServicesList.Items.Clear();
            var tmp = MyDBContext.DBContext.Services.ToList();
            for (int i = 0; i < tmp.Count; i++)
            {
                ServicesList.Items.Add(tmp[i].ServiceID.ToString() + " " + tmp[i].ServiceName);
            }
        }

        private void AddServButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(SeviceNameBox.Text))
            {
                Classes.Services srv = new Classes.Services();
                srv.ServiceID = MyDBContext.DBContext.Services.Count();
                srv.ServiceID++;
                srv.ServiceName = SeviceNameBox.Text;
                MyDBContext.DBContext.Services.Add(srv);
                MyDBContext.DBContext.SaveChanges();
            }
            UpdateList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] ServisesString = ServicesList.SelectedItem.ToString().Split(' ');
            int compareID = Convert.ToInt32(ServisesString[0]);
            var req = (from t in MyDBContext.DBContext.Services.ToList<Classes.Services>()
                       where t.ServiceID == compareID
                       select t).ToList();
            MyDBContext.DBContext.Services.Remove(req[0]);
            MyDBContext.DBContext.SaveChanges();
            UpdateList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateList();
        }
    }
}
