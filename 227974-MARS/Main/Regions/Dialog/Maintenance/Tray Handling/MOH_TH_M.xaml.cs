﻿using HMI.CO.General;
using HMI.MessageBoxRegion.Views;
using HMI.Resources;
using System;
using System.Threading.Tasks;
using System.Windows;
using VisiWin.ApplicationFramework;
using VisiWin.Logging;

namespace HMI.DialogRegion.Maintenance.Views
{
    [ExportView("MOH_TH_M")]
    public partial class MOH_TH_M
    {

        public MOH_TH_M()
        {
            this.InitializeComponent();
        }

        private void Close_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            new ObjectAnimator().CloseDialog1(this, border);

        }

        private void Reset_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (MessageBoxView.Show("@Maintenance.Text15", "@Maintenance.Text16", MessageBoxButton.YesNo, MessageBoxResult.No, MessageBoxIcon.Question) == MessageBoxResult.Yes)
            {
                ILoggingService loggingService = ApplicationService.GetService<ILoggingService>();
                if (btn1.IsSelected)
                {
                    loggingService.Log("Machine", "Maintenance", "@Logging.Machine.Maintenance.Text33", DateTime.Now);
                    Task taskA = Task.Run(() =>
                    {
                        ApplicationService.SetVariableValue("CPU2.PLC.Blocks.01 Tray Handling.02 TH.03 Arm.DB TH Arm HMI.Actual.Arm.Operating hours.Reset", true);
                    });
                    taskA.ContinueWith(async x =>
                    {
                        await Task.Delay(1000);
                        ApplicationService.SetVariableValue("CPU2.PLC.Blocks.01 Tray Handling.02 TH.03 Arm.DB TH Arm HMI.Actual.Arm.Operating hours.Reset", false);

                    }, TaskContinuationOptions.OnlyOnRanToCompletion);
                }
                if (btn2.IsSelected)
                {
                    loggingService.Log("Machine", "Maintenance", "@Logging.Machine.Maintenance.Text34", DateTime.Now);
                    Task taskA = Task.Run(() =>
                    {
                        ApplicationService.SetVariableValue("CPU2.PLC.Blocks.01 Tray Handling.02 TH.04 Chain.DB TH Chain HMI.Actual.Chain.Operating hours.Reset", true);
                    });
                    taskA.ContinueWith(async x =>
                    {
                        await Task.Delay(1000);
                        ApplicationService.SetVariableValue("CPU2.PLC.Blocks.01 Tray Handling.02 TH.04 Chain.DB TH Chain HMI.Actual.Chain.Operating hours.Reset", false);

                    }, TaskContinuationOptions.OnlyOnRanToCompletion);
                }
                if (btn3.IsSelected)
                {
                    loggingService.Log("Machine", "Maintenance", "@Logging.Machine.Maintenance.Text35", DateTime.Now);
                    Task taskA = Task.Run(() =>
                    {
                        ApplicationService.SetVariableValue("CPU2.PLC.Blocks.01 Tray Handling.02 TH.02 Lift.DB TH Lift HMI.Actual.Lift.Operating hours.Reset", true);
                    });
                    taskA.ContinueWith(async x =>
                    {
                        await Task.Delay(1000);
                        ApplicationService.SetVariableValue("CPU2.PLC.Blocks.01 Tray Handling.02 TH.02 Lift.DB TH Lift HMI.Actual.Lift.Operating hours.Reset", false);

                    }, TaskContinuationOptions.OnlyOnRanToCompletion);
                }
                if (btn4.IsSelected)
                {
                    loggingService.Log("Machine", "Maintenance", "@Logging.Machine.Maintenance.Text36", DateTime.Now);
                    Task taskA = Task.Run(() =>
                    {
                        ApplicationService.SetVariableValue("CPU2.PLC.Blocks.01 Tray Handling.02 TH.01 Traction.DB TH Traction HMI.Actual.Traction.Operating hours.Reset", true);
                    });
                    taskA.ContinueWith(async x =>
                    {
                        await Task.Delay(1000);
                        ApplicationService.SetVariableValue("CPU2.PLC.Blocks.01 Tray Handling.02 TH.01 Traction.DB TH Traction HMI.Actual.Traction.Operating hours.Reset", false);

                    }, TaskContinuationOptions.OnlyOnRanToCompletion);
                }
                new ObjectAnimator().CloseDialog1(this, border);
            }


        }

        private void _Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            new ObjectAnimator().OpenDialog(this, border);
        }
    }
}