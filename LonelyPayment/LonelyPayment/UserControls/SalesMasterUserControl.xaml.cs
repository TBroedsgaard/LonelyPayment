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

namespace LonelyPayment.UserControls
{
    /// <summary>
    /// Interaction logic for SalesMasterUserControl.xaml
    /// </summary>
    public partial class SalesMasterUserControl : UserControl
    {
        public SalesMasterUserControl()
        {
            InitializeComponent();

            var sale = new { 
                Started = DateTime.Now.ToShortDateString(), 
                Customer = "John", 
                Status = "Active" 
            };

            salesListView.Items.Add(sale);
        }
    }
}
