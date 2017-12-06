using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPAge03
{
    public  class DataModel_ScrewPiles : DataModel
    {
        private Page03 page03;
        public DataModel_ScrewPiles(Page03 page03)
        {
            this.page03 = page03;
        }

        private int row;
        public int Row
        {
            get { return row; }
            set { row = value; NotifyPropertyChanged("Row"); }
        }

        private string pileType;
        public string PileType
        {
            get { return pileType ; }
            set { pileType = value; NotifyPropertyChanged("PileType"); }
        }

        private int circleDiameter;
        public int CircleDiameter
        {
            get { return circleDiameter; }
            set { circleDiameter = value; NotifyPropertyChanged("CircleDiameter"); }
        }

        private int noPiles;
        public int NoPiles
        {
            get { return noPiles; }
            set { noPiles = value; NotifyPropertyChanged("NoPiles"); }
        }

        private int divPerCurve;
        public int DivPerCurve
        {
            get { return divPerCurve; }
            set { divPerCurve = value; NotifyPropertyChanged("DivPerCurve"); }
        }

        private double angle ;
        public double Angle
        {
            get { return angle; }
            set { angle = value; NotifyPropertyChanged("Angle"); }
        }

        private int pileDepth;
        public int PileDepth
        {
            get { return pileDepth; }
            set { pileDepth = value; NotifyPropertyChanged("PileDepth"); }
        }

        private string materialPiles= "C12/45-OB";
        public string MaterialPiles
        {
            get { return materialPiles; }
            set { materialPiles = value; NotifyPropertyChanged("MaterialPIles"); }
        }

        private double slope;
        public double Slope
        {
            get { return slope; }
            set { slope = value; NotifyPropertyChanged("Slope"); }
        }

        private int depthPile;
        public int DepthPile
        {
            get { return depthPile; }
            set { depthPile = value; NotifyPropertyChanged("DepthPile"); }
        }

        private string forces;
        public string Forces
        {
            get { return forces; }
            set { forces = value; NotifyPropertyChanged("Forces"); }
        }

        private int pr_BottomCover;
        public int PR_BottomCover
        {
            get { return pr_BottomCover; }
            set { pr_BottomCover = value; NotifyPropertyChanged("PR_BottomCover"); }
        }

        private int pr_TopCover;
        public int PR_TopCover
        {
            get { return pr_TopCover; }
            set { pr_TopCover = value; NotifyPropertyChanged("PR_TopCover"); }
        }

        private int pr_StirrupRadius_Layer1;
        public int PR_StirrupRadius_Layer1
        {
            get { return pr_StirrupRadius_Layer1; }
            set { pr_StirrupRadius_Layer1 = value; NotifyPropertyChanged("PR_StirrupRadius_Layer1"); }
        }

        private int pr_Spacing_Layer1;
        public int PR_Spacing_Layer1
        {
            get { return pr_Spacing_Layer1; }
            set { pr_Spacing_Layer1 = value; NotifyPropertyChanged("PR_Spacing_Layer1"); }
        }

        private int selectedIndexDiameter1;
        public int SelectedIndexDiameter1
        {
            get { return selectedIndexDiameter1; }
            set { selectedIndexDiameter1 = value; NotifyPropertyChanged("SelectedIndexDiameter1"); }
        }

        public List<String> PR_StirrupRebarDiam_Layer1 => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private int pr_NoOfLongRebars;
        public int PR_NoOfLongRebars
        {
            get { return pr_NoOfLongRebars; }
            set { pr_NoOfLongRebars = value; NotifyPropertyChanged("PR_NoOfLongRebars"); }
        }

        private int selectedIndexDiameter2;
        public int SelectedIndexDiameter2
        {
            get { return selectedIndexDiameter2; }
            set { selectedIndexDiameter2 = value; NotifyPropertyChanged("SelectedIndexDiameter2"); }
        }

        public List<String> PR_LongRebarDiam => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));


        private int pr_TopLongExtension;
        public int PR_TopLongExtension
        {
            get { return pr_TopLongExtension; }
            set { pr_TopLongExtension = value; NotifyPropertyChanged("PR_TopLongExtension"); }
        }


        private int pr_StirrupRadius_Layer2;
        public int PR_StirrupRadius_Layer2
        {
            get { return pr_StirrupRadius_Layer2; }
            set { pr_StirrupRadius_Layer2 = value; NotifyPropertyChanged("PR_StirrupRadius_Layer2"); }
        }

        private int pr_Spacing_Layer2;
        public int PR_Spacing_Layer2
        {
            get { return pr_Spacing_Layer2; }
            set { pr_Spacing_Layer2 = value; NotifyPropertyChanged("PR_Spacing_Layer2"); }
        }

        private int selectedIndexDiameter3;
        public int SelectedIndexDiameter3
        {
            get { return selectedIndexDiameter3; }
            set { selectedIndexDiameter3 = value; NotifyPropertyChanged("SelectedIndexDiameter3"); }
        }

        public List<String> PR_StirrupRebarDiam_Layer2 => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private int selectedIndexDiameter4;
        public int SelectedIndexDiameter4
        {
            get { return selectedIndexDiameter4; }
            set { selectedIndexDiameter4 = value; NotifyPropertyChanged("SelectedIndexDiameter4"); }
        }

        public List<String> PR_Ureinforcement_RebarDiam => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));



    }
}
