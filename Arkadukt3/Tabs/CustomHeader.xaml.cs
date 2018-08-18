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

namespace Arkadukt3.Tabs
{
    /// <summary>
    /// Interaction logic for CustomHeader.xaml
    /// </summary>
    public partial class CustomHeader : UserControl
    {
        public CustomHeader(string title)
        {
            InitializeComponent();
            TextBoxHeader.Text = title;
        }
    }
}
