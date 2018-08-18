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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Arkadukt3.Tabs;
using MahApps.Metro.Controls;

namespace Arkadukt3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            TabItem newTabItem = new TabItem
            {
                Header = new CustomHeader("Nerf title"),
                Name = "Test"
            };

            TabItem newTabItem2 = new TabItem
            {
                Header = new CustomHeader("Nerf title"),
                Name = "Test"
            };

            TabItem newTabItem3 = new TabItem
            {
                Header = new CustomHeader("Nerf title"),
                Name = "Test"
            };
            workTabs.Items.Add(newTabItem);
            workTabs.Items.Add(newTabItem2);
            workTabs.Items.Add(newTabItem3);

            setHeight(Menu1.Items);
        }

        private void setHeight(ItemCollection list)
        {
            try
            {
                foreach (object _item in list)
                {
                    if (_item.GetType().Equals(MenuFile.GetType()))
                    {
                        MenuItem item = (MenuItem) _item;
                        if (item.Items != null)
                        {
                            setHeight(item.Items);
                        }
                        item.Height = 21;
                    }
                }
            }
            catch (XamlParseException) { }
            catch (InvalidCastException) { }
        }

        private void actionNewAddml(object sender, RoutedEventArgs e)
        {

        }

        private void actionOpenAddml(object sender, RoutedEventArgs e)
        {

        }

        private void actionReload(object sender, RoutedEventArgs e)
        {

        }

        private void actionSaveAddml(object sender, RoutedEventArgs e)
        {

        }

        private void actionSaveAddmlAs(object sender, RoutedEventArgs e)
        {

        }

        private void actionClose(object sender, RoutedEventArgs e)
        {

        }

        private void actionCloseAddml(object sender, RoutedEventArgs e)
        {

        }
    }
}
