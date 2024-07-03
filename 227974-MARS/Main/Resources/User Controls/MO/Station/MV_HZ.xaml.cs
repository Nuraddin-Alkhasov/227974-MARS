using HMI.CO.General;
using System.Windows;
using System.Windows.Controls;
using VisiWin.ApplicationFramework;
using VisiWin.DataAccess;

namespace HMI.Resources.UserControls.MO
{
    public partial class MV_HZ : UserControl
    {
        public MV_HZ()
        {
            InitializeComponent();
            HZTemp = "CPU2.PLC.Blocks.05 Airflow Heating.04 HZ.DB HZ Air HMI.Actual.Temperatur";
            HZRpm = "CPU2.PLC.Blocks.05 Airflow Heating.04 HZ.DB HZ Air HMI.Actual.Circulating air.Motor.Actual.Rotational speed in Units";
            HZCaster = "CPU2.PLC.Blocks.05 Airflow Heating.04 HZ.DB HZ Air HMI.Actual.Nachlauf Aktiv";
        }

        IVariableService VS = ApplicationService.GetService<IVariableService>();

        public string HZTemp
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    HZ1T.VariableName = value;
                }
            }
        }

        public string HZRpm
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    HZ1F.VariableName = value;
                }
            }
        }
        IVariable IVHZCaster;
        public string HZCaster
        {
            get { return ""; }
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    IVHZCaster = VS.GetVariable(value);
                    IVHZCaster.Change += IVHZCaster_Change;
                }
            }
        }
        private void IVHZCaster_Change(object sender, VariableEventArgs e)
        {
            if (e.Quality.Data == DataQuality.Good)
            {
                if ((bool)e.Value)
                {
                    hzNL.Visibility = Visibility.Visible;
                }
                else
                {
                    hzNL.Visibility = Visibility.Hidden;
                }
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            new ObjectAnimator().ShowMOElement(this);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ApplicationService.SetView("MainRegion", "MO_HZ");
        }
    }
}
