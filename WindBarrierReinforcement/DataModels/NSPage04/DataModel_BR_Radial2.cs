using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPage04
{
    public class DataModel_BR_Radial2 : DataModel
    {

        //Common properties
        public List<String> ListOfDiameters2 => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        public List<String> HookTypes2 => EnumHelpers.GetEnumDisplayText(typeof(EHookType));
        private double _no_LargeDiameter;
        public double No_LargeDiameter
        {
            get { return _no_LargeDiameter; }
            set
            {
                _no_LargeDiameter = value;
                NotifyPropertyChanged("No_LargeDiameter");
            }
        }

        private int selectedIndexDiameter_LD2;
        public int SelectedIndexDiameter_LD2
        {
            get { return selectedIndexDiameter_LD2; }
            set { selectedIndexDiameter_LD2 = value; NotifyPropertyChanged("SelectedIndexDiameter_LD2"); }

        }

        private int _no_SmallDiameter;
        public int No_SmallDiameter
        {
            get { return _no_SmallDiameter; }
            set { _no_SmallDiameter = value; NotifyPropertyChanged("No_SmallDiameter"); }
        }

        private int selectedIndexDiameter_SD;
        public int SelectedIndexDiameter_SD2
        {
            get { return selectedIndexDiameter_SD; }
            set { selectedIndexDiameter_SD = value; NotifyPropertyChanged("SelectedIndexDiameter_SD2"); }
        }

        private double _no_3rdDiameter;
        public double No_3rdDiameter
        {
            get { return _no_3rdDiameter; }
            set { _no_3rdDiameter = value; NotifyPropertyChanged("No_3rdDiameter"); }
        }

        private int selectedIndexDiameter_3D2;
        public int SelectedIndexDiameter_3D2
        {
            get { return selectedIndexDiameter_3D2; }
            set { selectedIndexDiameter_3D2 = value; NotifyPropertyChanged("SelectedIndexDiameter_3D2"); }
        }

        private int unreinforcedcore;
        public int UnreinforcedCore
        {
            get { return unreinforcedcore; }
            set
            {
                unreinforcedcore = value;
                NotifyPropertyChanged("UnreinforcedCore");
            }
        }

        public double SpacingAngle => (No_LargeDiameter == 0) ? 0 : 360 / No_LargeDiameter;

        public int LargeDiameterOffsetFromCenter
        {
            get => Math.Max(MinCore, UnreinforcedCore);
        }

        public int SmallDiameterOffsetFromCenter
        {
            //TODO :4105 and 36 are hardcoded for now
            get => (int)Math.Ceiling(((double)4105 / 2 + 50 + 36 / 2));
        }

        public int ThirdDiameterOffsetFromCenter
        {
            get => (int)Math.Ceiling(MinSpaceField / (Math.Sin(0.5*Spacing3rdDiameterAngle * Math.PI / 180)));
        }

        private int selectedIndex_HT;
        public int SelectedIndex_HT
        {
            get { return selectedIndex_HT; }
            set { selectedIndex_HT = value; NotifyPropertyChanged("SelectedIndex_HT"); }
        }

        private int overlappLargeDiameter;
        public int OverlappLargeDiameter
        {
            get { return overlappLargeDiameter; }
            set { overlappLargeDiameter = value; NotifyPropertyChanged("OverlappLargeDiameter"); }
        }

        private int overlappSmallDiameter;
        public int OverlappSmallDiameter
        {
            get { return overlappSmallDiameter; }
            set { overlappSmallDiameter = value; NotifyPropertyChanged("OverlappSmallDiameter"); }
        }

        private int overlapp3rdDiameter;
        public int Overlapp3rdDiameter
        {
            get { return overlapp3rdDiameter; }
            set { overlapp3rdDiameter = value; NotifyPropertyChanged("Overlapp3rdDiameter"); }
        }

        private double spacing3rdDiameterAngle;
        public double Spacing3rdDiameterAngle
        {
            get { return spacing3rdDiameterAngle = 360 / No_3rdDiameter; }
            set
            {
                spacing3rdDiameterAngle = value;
                NotifyPropertyChanged("Spacing3rdDiameterAngle");
            }
        }

        private double startOffsetAngle;
        public double StartOffsetAngle
        {
            get { return startOffsetAngle = Math.Round(SpacingAngle / 2, 2); }
            set { startOffsetAngle = value; NotifyPropertyChanged("StartOffsetAngle"); }
        }

        private int maximumLength;
        public int MaximumLength
        {
            get { return maximumLength; }
            set { maximumLength = value; NotifyPropertyChanged("MaximumLength"); }
        }

        public int MinCore => (int)Math.Ceiling(MinSpaceCenter / Math.Sin(SpacingAngle* Math.PI / 180));

        private double minSpaceField;
        public double MinSpaceField
        {
            get { return minSpaceField; }
            set
            {
                minSpaceField = value;
                NotifyPropertyChanged("MinSpaceField");
            }
        }

        private double minSpaceCenter;
        public double MinSpaceCenter
        {
            get { return minSpaceCenter; }
            set { minSpaceCenter = value; NotifyPropertyChanged("MinSpaceCenter"); }
        }

        public DataModel_BR_Radial2(FrameworkElement context)
        {
            this.PropertyChanged += DataModel_BR_Radial2_PropertyChanged;

            context.Loaded += (o, e) =>
            {
                SelectedIndexDiameter_LD2= 0;
                SelectedIndexDiameter_SD2 = 0;
                SelectedIndexDiameter_3D2 = 0;
            };
        }

        private void DataModel_BR_Radial2_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "MinSpaceCenter")
            {
                NotifyPropertyChanged("MinCore");
            }
            if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_BR_Radial1>(x => x.No_LargeDiameter))
            {
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_BR_Radial1>(x => x.SpacingAngle));
            }
            if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_BR_Radial1>(x => x.SpacingAngle))
            {
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_BR_Radial1>(x => x.StartOffsetAngle));
                // NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_BR_Radial>(x => x.MinCore));
            }

        }
    }


}
