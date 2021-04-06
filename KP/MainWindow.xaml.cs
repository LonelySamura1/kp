using KP.Forms;
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
using WFAEntity.API;
using WpfApp1.Classes;

namespace KP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MyDBContext.DBContext.Database.Exists() == false)
                {
                    MyDBContext.DBContext.Database.Create();
                    Worker WorkerObj = new Worker();
                    WorkerObj.WorkerID = 1;
                    WorkerObj.Name = "Максим";
                    WorkerObj.Surname = "Мишуто";
                    WorkerObj.Lastname = "Витальевич";
                    WorkerObj.Birthday = DateTime.Parse("03.03.2003");
                    WorkerObj.Specialize = "Администратор";
                    WorkerObj.Phone = "+375291337228";
                    WorkerObj.Login = "max2004";
                    WorkerObj.Password = "2004max";
                    WorkerObj.Adress = "г. Новополоцк ул. Молодежная 96";
                    MyDBContext.DBContext.Workers.Add(WorkerObj);
                    MyDBContext.DBContext.SaveChanges();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var tmp = (
    from tmpWorker in MyDBContext.DBContext.Workers.ToList<Worker>()
    where tmpWorker.Login.CompareTo(LoginBox.Text) == 0 && tmpWorker.Password.CompareTo(PasswordBox.Text) == 0
    select tmpWorker
          ).ToList();
            if (tmp.Count > 0)
            {
                if (tmp[0].Specialize == "Администратор")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Close();
                }
            }
        }
    }
}
