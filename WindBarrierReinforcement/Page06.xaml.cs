﻿using System;
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
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.DataModels.NSPage06;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page6.xaml
    /// </summary>
    public partial class Page06 : Page
    {
        public DataModel_BR_D1 DataModel_BR_D1 { get; set; }
        public DataModel_BR_D2 DataModel_BR_D2 { get; set; }
        public DataModel_BR_L DataModel_BR_L { get; set; }
        public DataModel_TB_D1 DataModel_TB_D1 { get; set; }
        public DataModel_TB_D2 DataModel_TB_D2 { get; set; }
        public DataModel_Circular_EdgeOfL DataModel_Circular_EdgeOfL { get; set; }
        public DataModel_Generalities DataModel_Generalities { get; set; }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        public Page06()
        {
            
            DataModel_BR_D1 = new DataModel_BR_D1();
            DataModel_BR_D2 = new DataModel_BR_D2();
            DataModel_BR_L = new DataModel_BR_L();
            DataModel_TB_D1 = new DataModel_TB_D1();
            DataModel_TB_D2 = new DataModel_TB_D2();
            DataModel_Circular_EdgeOfL = new DataModel_Circular_EdgeOfL();
            DataModel_Generalities = new DataModel_Generalities();


            InitializeComponent();
            this.DataContext = this;

         //  Writer.Writer.AddElementToDisplay(PropertyDataInfo.GetInfo(DataModel_BR_D1, x => x.Diameter));
         //  Writer.Writer.AddElementToDisplay(PropertyDataInfo.GetInfo(DataModel_BR_D1, x => x.MarginCover));
         //  Writer.Writer.AddElementToDisplay(PropertyDataInfo.GetInfo(DataModel_BR_D1, x => x.Spacing));
                     
            

        }
    }
}
