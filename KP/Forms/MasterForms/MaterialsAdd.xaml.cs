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

namespace KP.Forms.AdminForms
{
    /// <summary>
    /// Логика взаимодействия для MaterialsAdd.xaml
    /// </summary>
    public partial class MaterialsAdd : Window
    {
        public MaterialsAdd()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Material mt = new Material();
            mt.MaterialID = MyDBContext.DBContext.Materials.Count();
            mt.MaterialID++;
            mt.MaterialName = NameBox.Text;
            mt.MaterialType = TypeBox.Text;
            mt.Count = Convert.ToInt32(CountBox.Text);
            MyDBContext.DBContext.Materials.Add(mt);
            MyDBContext.DBContext.SaveChanges();
            MessageBox.Show("Добавлено!");
        }
    }
}
