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
using System.ServiceModel;
using WCF2;
using Client.MyInfo;
using System.Collections.ObjectModel;

namespace Client
{
    
    public partial class MainWindow : Window
    {
        MyDirectory MyDirectory = new MyDirectory();
        ObservableCollection<MyDirectory> MyColection = new ObservableCollection<MyDirectory>();
        public MainWindow()
        {
            InitializeComponent();
            DirectoryView.ItemsSource = MyColection;
        }

        private void LoadClick(object sender, RoutedEventArgs e)
        {
            Load();
        }

        public void Load()
        {
            try
            {
                using (DiscInfoClient info = new DiscInfoClient())
                {
                    var result = info.GetDiskInfo(@MyTextBox.Text);
                    foreach (var item in result)
                    {
                        MyColection.Add(new MyDirectory() { directory = item });
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ClearClick(object sender, RoutedEventArgs e)
        {
            MyColection.Clear();
        }
    }
}
