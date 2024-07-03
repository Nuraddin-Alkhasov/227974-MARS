using HMI.CO.General;
using VisiWin.ApplicationFramework;

namespace HMI.DialogRegion.MO.Views
{

	[ExportView("MO_Sheduler")]
	public partial class MO_Sheduler
    {

        public MO_Sheduler()
		{
			this.InitializeComponent();
          
        }

        private void CancelButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            new ObjectAnimator().CloseDialog1(this, border);
        }

        private void LeftButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ApplicationService.SetVariableValue("CPU2.PLC.Blocks.05 Airflow Heating.00 Main.DB Timer HMI.Aktiv", true);
        }

        private void RightButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ApplicationService.SetVariableValue("CPU2.PLC.Blocks.05 Airflow Heating.00 Main.DB Timer HMI.Aktiv", false);
        }

        private void View_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            new ObjectAnimator().OpenDialog(this, border);
        }
    }
}