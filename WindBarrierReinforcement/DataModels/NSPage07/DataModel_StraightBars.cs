﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPage07
{
    public class DataModel_StraightBars : DataModel
    {
        
        /// <summary>
        /// ComboBox - Option Types
        /// </summary>
        private int selectedIndexOption;
        public int SelectedIndexOption
        {
            get { return selectedIndexOption; }
            set { selectedIndexOption = value; NotifyPropertyChanged("SelectedIndexOption"); NotifyPropertyChanged("SpacingEnabled"); }
        }

        public List<String> OptionNames => EnumHelpers.GetEnumDisplayText(typeof(EOption));

        /// <summary>
        /// ComboBox - Diameter Types
        /// </summary>
        private int selectedIndexDiameter;
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged("SelectedIndexDiameter"); }
        }

        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));


        public DataModel_StraightBars(Page context)
        {
            context.Loaded += Context_Loaded;
        }

        private void Context_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            SelectedIndexOption = 0;
            SelectedIndexDiameter = 0;
        }
        /// <summary>
        /// Spacing
        /// </summary>
        private int spacing;
        public int Spacing
        {
            get { return spacing; }
            set { spacing = value; NotifyPropertyChanged("Spacing"); }
        }

        public string SpacingEnabled
        {
            get
            {
                if (SelectedIndexOption == 0)
                    return "Disabled";
                else
                    return "Enabled";
            }
        }
        /// <summary>
        /// NoOfBars
        /// </summary>
        private int noOfBars;
        public int NoOfBars
        {
            get { return noOfBars; }
            set { noOfBars = value; NotifyPropertyChanged("NoOfBars"); }
        }

        //public string NoOfBarsEnabled
        //{
        //    get
        //    {
        //        if (SelectedIndexOption == 0)
        //            return "Enabled";
        //        else
        //            return "Disabled";
        //    }
        //}        
        /// <summary>
        /// Lx
        /// </summary>
        private int lx;
        public int Lx
        {
            get { return lx; }
            set { lx = value; NotifyPropertyChanged("Lx"); }
        }       
        /// <summary>
        /// Ly
        /// </summary>
        private int ly;
        public int Ly
        {
            get { return ly; }
            set { ly = value; NotifyPropertyChanged("Ly"); }
        }        
        /// <summary>
        /// EdgeCover
        /// </summary>
        private int edgeCover;
        public int EdgeCover
        {
            get { return edgeCover; }
            set { edgeCover = value; NotifyPropertyChanged("EdgeCover"); }
        }
    }
}
