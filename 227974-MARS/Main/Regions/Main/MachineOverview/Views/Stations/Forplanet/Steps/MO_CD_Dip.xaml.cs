using HMI.CO.General;
using System.Windows;
using VisiWin.ApplicationFramework;

namespace HMI.MainRegion.MO.Views
{

    [ExportView("MO_CD_Dip")]
	public partial class MO_CD_Dip
    {
 

        public MO_CD_Dip()
		{
			this.InitializeComponent();
        }

  
        private void _Loaded(object sender, RoutedEventArgs e)
        {
            new ObjectAnimator().ShowUIElement(this);
        }

        private void NumericVarOut_ValueChanged(object sender, VisiWin.DataAccess.VariableEventArgs e)
        {
            if ((float)e.Value == 0.0f)
            {
                setdtime.VariableName = "CPU1.PLC.Blocks.03 Basket coating.00 Main.Stepchains.DB Coating Program control.Set active Step.Data.Dipping.Time Straight";
                actdtime.VariableName = "CPU1.PLC.Blocks.03 Basket coating.00 Main.Stepchains.DB Coating Program control.Actual active Step.Dipping.Time Straight";
                pack.Visibility = Visibility.Collapsed;
                border1.Visibility = Visibility.Collapsed;
            }

            if ((float)e.Value == 40.0f)
            {
                setdtime.VariableName = "CPU1.PLC.Blocks.03 Basket coating.00 Main.Stepchains.DB Coating Program control.Set active Step.Data.Dipping.Dip Time";
                actdtime.VariableName = "CPU1.PLC.Blocks.03 Basket coating.00 Main.Stepchains.DB Coating Program control.Actual active Step.Dipping.Dip Time";
                pack.Visibility = Visibility.Visible;
                border1.Visibility = Visibility.Visible;
            }

            if ((float)e.Value == 50.0f)
            {
                setdtime.VariableName = "CPU1.PLC.Blocks.03 Basket coating.00 Main.Stepchains.DB Coating Program control.Set active Step.Data.Dipping.Dip Time";
                actdtime.VariableName = "CPU1.PLC.Blocks.03 Basket coating.00 Main.Stepchains.DB Coating Program control.Actual active Step.Dipping.Dip Time";
                pack.Visibility = Visibility.Collapsed;
                border1.Visibility = Visibility.Collapsed;
            }
        }
    }
}