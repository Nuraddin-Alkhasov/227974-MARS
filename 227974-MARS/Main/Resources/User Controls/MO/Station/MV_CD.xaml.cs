using HMI.CO.General;
using System.Windows;
using System.Windows.Controls;
using VisiWin.ApplicationFramework;
using VisiWin.DataAccess;

namespace HMI.Resources.UserControls.MO
{
    public partial class MV_CD : UserControl
    {
        public MV_CD()
        {
            InitializeComponent();

            DTTemperature = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT HMI.Actual.Dipping Vat.Act Paint Temp";
            isDT = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT HMI.Actual.Dipping Vat.Is Vat";
            PurgeStatus = "CPU1.PLC.Blocks.03 Basket coating.00 Main.DB BC HMI.Actual.Exhaust Air.Purge time acitive";
            ViscoCheckL1 = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT HMI.Actual.Dipping Vat.Viscosity.Check 30 min required";
            ViscoCheckL2 = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT HMI.Actual.Dipping Vat.Viscosity.Check hard required";

        }
        IVariableService VS = ApplicationService.GetService<IVariableService>();

        IVariable doorStatus;
        IVariable VWN_isLTB;
        IVariable VWN_PT;
        IVariable VWN_ViscoCheckL1;
        IVariable VWN_ViscoCheckL2;
        public string DTTemperature
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    dtTemp.VariableName = value;
                }
            }
        }
        public string isDT
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    VWN_isLTB = VS.GetVariable(value);
                    VWN_isLTB.Change += IsDT_Change;
                }
            }
        }
        private void IsDT_Change(object sender, VariableEventArgs e)
        {
            if (e.Quality.Data == DataQuality.Good)
            {
                if ((bool)e.Value)
                {
                    new ObjectAnimator().ShowMOElement(DT);
                }
                else
                {
                    new ObjectAnimator().HideMOElement(DT);
                }
            }
        }
        public string DoorStatus
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    doorStatus = VS.GetVariable(value);
                    doorStatus.Change += doorStatus_ValueChanged;
                }
            }
        }
        private void doorStatus_ValueChanged(object sender, VariableEventArgs e)
        {
            if (e.Quality.Data == DataQuality.Good)
            {
                if ((bool)e.Value)
                {
                    //Door.SymbolResourceKey = "SCDDO";
                }
                else
                {
                  //  Door.SymbolResourceKey = "SCDDC";
                }
            }
        }
        public string PurgeStatus
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    VWN_PT = VS.GetVariable(value);
                    VWN_PT.Change += PurgeStatus_ValueChanged;
                }
            }
        }
        private void PurgeStatus_ValueChanged(object sender, VariableEventArgs e)
        {
            if (e.Quality.Data == DataQuality.Good)
            {
                if ((bool)e.Value)
                {
                    PT.Visibility = Visibility.Visible;
                }
                else
                {
                    PT.Visibility = Visibility.Hidden;
                }
            }
        }
        public string ViscoCheckL1
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    VWN_ViscoCheckL1 = VS.GetVariable(value);
                    VWN_ViscoCheckL1.Change += ViscoCheckL1_ValueChanged;
                }
            }
        }
        private void ViscoCheckL1_ValueChanged(object sender, VariableEventArgs e)
        {
            if (e.Quality.Data == DataQuality.Good)
            {
                if ((bool)e.Value)
                {
                    Visco.Visibility = Visibility.Visible;
                }
                else
                {
                    Visco.Visibility = Visibility.Hidden;
                }
            }
        }
        public string ViscoCheckL2
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    VWN_ViscoCheckL2 = VS.GetVariable(value);
                    VWN_ViscoCheckL2.Change += ViscoCheckL2_ValueChanged;
                }
            }
        }
        private void ViscoCheckL2_ValueChanged(object sender, VariableEventArgs e)
        {
            if (e.Quality.Data == DataQuality.Good)
            {
                if ((bool)e.Value)
                {
                    Visco.IsBlinkEnabled = true;
                }
                else
                {
                    Visco.IsBlinkEnabled = false;
                }
            }
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            new ObjectAnimator().ShowMOElement(this);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ApplicationService.SetView("MainRegion", "MO_CD");
        }
    }
}
