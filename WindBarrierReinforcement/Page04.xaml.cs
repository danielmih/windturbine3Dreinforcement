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
using WindBarrierReinforcement.DataModels.NSPage04;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page04 : Page
    {
        public DataModel_BR_Radial1 Prop_DataModel_BR_Radial1 { get; set; }
        public DataModel_BR_Radial2 Prop_DataModel_BR_Radial2 { get; set; }
        public DataModel_BR_Circular Prop_DataModel_BR_Circular { get; set; }

       // public DataModel_BR_Circular DataModel_BR_Circular_abcd { get; set; }

        public Page04()
        {
            Prop_DataModel_BR_Radial1 = new DataModel_BR_Radial1(this);
            Prop_DataModel_BR_Radial2 = new DataModel_BR_Radial2(this);

            //DataModel_BR_Circular = new DataModel_BR_Circular();

            InitializeComponent();
            this.DataContext = this;

    
        }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
    }
}
