using HMI.Resources.UserControls.MO;
using System;
using System.Threading.Tasks;
using System.Windows;
using VisiWin.ApplicationFramework;

namespace HMI.MainRegion.MO.Views
{

    [ExportView("MO_Paints_2")]
    public partial class MO_Paints_2
    {
        public MO_Paints_2()
        {
            InitializeComponent();
          
        }

        private void View_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Task obTask = Task.Run(async () =>
            {
                for (int i = 6; i <= 10; i++)
                {

                    await Application.Current.Dispatcher.InvokeAsync((Action)delegate
                    {
                        PaintType PT = new PaintType()
                        {
                            Header = "@Lists.Paint.Text" + (2 + i).ToString(),
                            Paint = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Name[" + i + "]",
                            Type = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Color[" + i + "]",
                            Type2 = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Base or Top Coat[" + i + "]",
                            // IsSolvent = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Solvent[" + i + "]",
                            WatchDog = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Level Monitoring[" + i + "]",
                            MaxCoatings = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Number of Basket Coatings[" + i + "]",
                            Pump = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Pump[" + i + "].On  Off",
                            PumpOn = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Pump[" + i + "].On Time",
                            PumpOff = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Pump[" + i + "].Off Time",
                            WZUL = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Oven Temp CD Start[" + i + "].Diff UL",
                            WZ = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Oven Temp CD Start[" + i + "].Process",
                            WZLL = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Oven Temp CD Start[" + i + "].Diff LL",
                            CZUL = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Paint Cooling[" + i + "].Diff UL",
                            CZ = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Paint Cooling[" + i + "].Process",
                            CZLL = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Paint Cooling[" + i + "].Diff LL",
                            ViscosityH = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Viscosity Check[" + i + "].Hours",
                            ViscosityM = "CPU1.PLC.Blocks.03 Basket coating.10 DT.DB DT Parameter.Viscosity Check[" + i + "].Minutes",
                        };
                        P.Children.Add(PT);
                    });
                    await Task.Delay(300);
                }
            });
        }

        private void View_Unloaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Task obTask = Task.Run(async () =>
            {
                await Dispatcher.InvokeAsync((Action)delegate
                {
                    P.Children.Clear();
                });
            });
        }
    }
}