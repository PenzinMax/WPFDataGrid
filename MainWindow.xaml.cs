using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace WpfApp3
{
    
    public partial class MainWindow : Window
    {
        public ObservableCollection<Period> period = null;

        public MainWindow()
        {
            

            period = new ObservableCollection<Period>() {
                new Period(){
                        DateStart = DateTime.Now,
                        DateFinish = DateTime.Now,
                        Type = 1
                }, new Period(){
                        DateStart = DateTime.Now,
                        DateFinish = DateTime.Now,
                        Type = 2
                }, new Period(){
                        DateStart = DateTime.Now,
                        DateFinish = DateTime.Now,
                        Type = 3
                }
            };
            /*foreach (var item in period)
            {
                MessageBox.Show(item.DateFinish.ToString());
            }
            */
        }
    }
}