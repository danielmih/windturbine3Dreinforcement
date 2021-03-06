﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPage07
{
    public class DataModel_CircularBarsTop : DataModel
    {
        /// <summary>
        /// UI_TextBox_OPTR_CircularBarDiam
        /// </summary>        
        private int selectedIndexDiameter;
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged("SelectedIndexDiameter"); }
        }

        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private void Context_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            SelectedIndexDiameter = 0;
        }
        /// <summary>
        /// OPTR_CircularTop_Option
        /// </summary>
        private int selectedIndexOption;
        public int SelectedIndexOption
        {
            get { return selectedIndexOption; }
            set { selectedIndexOption = value; NotifyPropertyChanged("SelectedIndexOption"); NotifyPropertyChanged("SpacingEnabled");}
        }

        public List<String> OptionNames => EnumHelpers.GetEnumDisplayText(typeof(EOption));

        /// <summary>
        /// UI_TextBox_OPTR_CircularTop_Spacing
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
        /// UI_TextBox_OPTR_CircularTop_NoBars
        /// </summary>
        private int noOfBars;
        public int NoOfBars
        {
            get { return noOfBars; }
            set { noOfBars = value; NotifyPropertyChanged("NoOfBars"); }
        }

        /// <summary>
        /// UI_TextBox_OPTR_CircularTop_MaxLength
        /// </summary>
        private int maxLength;
        public int MaxLength
        {
            get { return maxLength; }
            set { maxLength = value; NotifyPropertyChanged("MaxLength"); }
        }
        /// <summary>
        /// UI_TextBox_OPTR_CircularTop_Overlap
        /// </summary>
        private int overlap;
        public int Overlap
        {
            get { return overlap; }
            set { overlap = value; NotifyPropertyChanged("Overlap"); }
        }
        /// <summary>
        /// UI_TextBox_OPTR_Groups
        /// </summary>
        private string groups;
        public string Groups
        {
            get { return groups; }
            set { groups = value; NotifyPropertyChanged("Groups"); }
        }


    }
}
