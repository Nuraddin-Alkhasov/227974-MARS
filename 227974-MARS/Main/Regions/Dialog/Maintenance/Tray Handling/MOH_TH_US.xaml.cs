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
    [ExportView("MOH_TH_US")]
    public partial class MOH_TH_US
    {

        public MOH_TH_US()
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
                    loggingService.Log("Machine", "Maintenance", "@Logging.Machine.Maintenance.Text39", DateTime.Now);

                    Task taskA = Task.Run(() =>
                    {
                        ApplicationService.SetVariableValue("CPU2.PLC.Blocks.01 Tray Handling.05 PO.04 Unload 1.Belt.DB US 1 Belt HMI.Actual.Belt.Operating hours.Reset", true);
                    });
                    taskA.ContinueWith(async x =>
                    {
                        await Task.Delay(1000);
                        ApplicationService.SetVariableValue("CPU2.PLC.Blocks.01 Tray Handling.05 PO.04 Unload 1.Belt.DB US 1 Belt HMI.Actual.Belt.Operating hours.Reset", false);

                    }, TaskContinuationOptions.OnlyOnRanToCompletion);
                }
                if (btn2.IsSelected)
                {
                    loggingService.Log("Machine", "Maintenance", "@Logging.Machine.Maintenance.Text40", DateTime.Now);
                    Task taskA = Task.Run(() =>
                    {
                        ApplicationService.SetVariableValue("CPU2.PLC.Blocks.01 Tray Handling.05 PO.05 Unload 2.Belt.DB US 2 Belt HMI.Actual.Belt.Operating hours.Reset", true);
                    });
                    taskA.ContinueWith(async x =>
                    {
                        await Task.Delay(1000);
                        ApplicationService.SetVariableValue("CPU2.PLC.Blocks.01 Tray Handling.05 PO.05 Unload 2.Belt.DB US 2 Belt HMI.Actual.Belt.Operating hours.Reset", false);

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