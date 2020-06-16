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
using static WpfApp8.MySort;


namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// try to show what button was pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommonClickHandler(object sender, RoutedEventArgs e)
        {
            FrameworkElement feElement = e.Source as FrameworkElement;
            switch (feElement.Name)
            {
                case "YesButton":
                    MessageBox.Show("you pressed -" + "Yes");
                    break;
                case "NoButton":
                    MessageBox.Show("you pressed -" + e.Source);
                    break;
                case "CancelButton":
                    //MessageBox.Show("you pressed -" + e.Source);

                   // var _timeandDate = new DateTime();
                    //GetSorted(1, _timeandDate);
                    // List<DateTime> _anything = new List<DateTime>();
                    var _anything = new List<int>();

                    
                    for (int i = 0; i < 5; i++)
                    {
                        _anything.Add(i);
                        MessageBox.Show(_anything[i].ToString(), "Hopefully a list of days or dates");
                    }
                    //MessageBox.Show(_anything[i], "Hopefully a list of days or dates");
                    
                    break;
                   
                   

            }

            // image location D:\lesli\Documents\VS2019Glyphs\vswin2019

            e.Handled = true;
           
        }

        

        private void GetSorted(int v1, object v2)
        {
            
           
            if (v1 < 0)
                return;
            {
                MessageBox.Show(v1 + " " + v2,"Day Of The Week");
            }
            //throw new NotImplementedException();
        }
    }
}

