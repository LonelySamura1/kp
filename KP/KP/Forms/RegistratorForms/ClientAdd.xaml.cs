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

namespace WpfApp1.Forms.RegistratorForms
{
    /// <summary>
    /// Логика взаимодействия для ClientAdd.xaml
    /// </summary>
    public partial class ClientAdd : Window
    {
        RegistratorWindow RW;
        Client EditClient;
        bool isEdit = false;
        public ClientAdd(RegistratorWindow RW)
        {
            this.RW = RW;
            InitializeComponent();
        }
        public ClientAdd(RegistratorWindow RW, Client EditClient)
        {
            this.RW = RW;
            this.EditClient = EditClient;
            isEdit = true;
            InitializeComponent();
            this.AddButton.Content = "Сохранить";
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isEdit)
            {
                if (!String.IsNullOrWhiteSpace(NameBox.Text) && !String.IsNullOrWhiteSpace(SurnameBox.Text) &&
                    !String.IsNullOrWhiteSpace(LastNameBox.Text) && !String.IsNullOrWhiteSpace(AutoMarkText.Text) &&
                    !String.IsNullOrWhiteSpace(VINText.Text) && !String.IsNullOrWhiteSpace(ModelText.Text))
                {
                    Client client = new Client();
                    client.ClientID = MyDBContext.DBContext.Clients.Count();
                    client.ClientID++;
                    client.Name = NameBox.Text;
                    client.Surname = SurnameBox.Text;
                    client.Lastname = LastNameBox.Text;
                    client.AutoMark = AutoMarkText.Text + " " + ModelText.Text;
                    client.AutoYear = YearText.Text;
                    client.VINCode = VINText.Text;
                    MyDBContext.DBContext.Clients.Add(client);
                    MyDBContext.DBContext.SaveChanges();
                    RW.UpdateGrid();
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
            else
            {
                EditClient.Name = NameBox.Text;
                EditClient.Surname = SurnameBox.Text;
                EditClient.Lastname = LastNameBox.Text;
                EditClient.AutoMark = AutoMarkText.Text + " " + ModelText.Text;
                EditClient.AutoYear = YearText.Text;
                EditClient.VINCode = VINText.Text;
                MyDBContext.DBContext.Clients.AddOrUpdate(EditClient);
                RW.UpdateGrid();
            }
        }

        private void AddButton_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (isEdit)
            {
                NameBox.Text = EditClient.Name;
                SurnameBox.Text = EditClient.Surname;
                LastNameBox.Text = EditClient.Lastname;
                string[] Auto = EditClient.AutoMark.Split(' ');
                AutoMarkText.Text = Auto[0];
                ModelText.Text = Auto[1];
                YearText.Text = EditClient.AutoYear;
                VINText.Text = EditClient.VINCode;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
