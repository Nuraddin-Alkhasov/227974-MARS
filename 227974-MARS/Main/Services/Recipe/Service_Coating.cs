﻿using HMI.CO.General;
using HMI.CO.Recipe;
using HMI.Interfaces;
using HMI.Resources;
using System;
using System.ComponentModel.Composition;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using VisiWin.ApplicationFramework;
using VisiWin.DataAccess;

namespace HMI.Services
{
    [ExportService(typeof(ICoating))] 
    [Export(typeof(ICoating))]
    public class Service_H_Forplanet : ServiceBase, ICoating
    {
        IVariableService VS;
        IVariable CToPLC;


        public Service_H_Forplanet()
        {
            if (ApplicationService.IsInDesignMode)
                return;
        }

        #region - - - OnProject - - - 

  
        // Hier stehen noch keine VisiWin Funktionen zur Verfügung
        protected override void OnLoadProjectStarted()
        {
            base.OnLoadProjectStarted();
        }

        // Hier kann auf die VisiWin Funktionen zugegriffen werden
        protected override void OnLoadProjectCompleted()
        {
            VS = ApplicationService.GetService<IVariableService>();

            CToPLC = VS.GetVariable("CPU1.PLC.Blocks.03 Basket coating.00 Main.DB BC HMI.PC.Handshake.to PC.GetRecipe");
            CToPLC.Change += CToPLC_Change;

            base.OnLoadProjectCompleted();
        }

        // Hier stehen noch die VisiWin Funktionen zur Verfügung
        protected override void OnUnloadProjectStarted()
        {
            base.OnUnloadProjectStarted();
        }

        // Hier sind keine VisiWin Funktionen mehr verfügbar. Bei C/S ist die Verbindung zum Server schon getrennt.
        protected override void OnUnloadProjectCompleted()
        {
            base.OnUnloadProjectCompleted();
        }

        #endregion

        #region - - - Event Handlers - - -
        void CToPLC_Change(object sender, VariableEventArgs e)
        {
            if (e.Value != e.PreviousValue && bool.Parse(e.Value.ToString()))
            {
                CToPLC.Value = false;
                Task obTask = Task.Run(async () =>
                {
                    await C_To_PLCAsync();
                   // await C_To_PLCAsyncIBN();
                });
            }

        }

        #endregion

        #region - - - Methods - - -

        async Task C_To_PLCAsync()
        {

            try
            {
                long MR_Id = (uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.03 Basket coating.00 Main.DB BC PD.Header.MRId");

                DataTable DT = new MSSQLEAdapter("Recipes", "SELECT *  FROM Recipes_MR WHERE Id = " + MR_Id + "; ").DB_Output();

                int C_Id = (int)DT.Rows[0]["C1_Id"];


                if (C_Id == -1)
                {
                    ApplicationService.SetVariableValue("CPU1.PLC.Blocks.03 Basket coating.00 Main.DB BC HMI.PC.Handshake.from PC.Not loaded", true);
                    new MessageBoxTask("@RecipeSystem.Results.Text7", "@RecipeSystem.Results.Text2", MessageBoxIcon.Error);
                }
                else
                {
                    int C_P_Actual = (int)DT.Rows[0]["C1_P"];
                    int C_P_Next = -1;

                    ApplicationService.SetVariableValue("CPU1.PLC.Blocks.03 Basket coating.00 Main.DB BC PD.Charge.Paint.Actual", C_P_Actual);
                    ApplicationService.SetVariableValue("CPU1.PLC.Blocks.03 Basket coating.00 Main.DB BC PD.Charge.Paint.Next", C_P_Next);

                    Coating C = GetCoatingData(C_Id);
                    await C.LoadToPLC();


                }
            }
            catch (Exception ex)
            {
                ApplicationService.SetVariableValue("CPU1.PLC.Blocks.03 Basket coating.00 Main.DB BC HMI.PC.Handshake.from PC.Not loaded", true);
                new MessageBoxTask("@RecipeSystem.Results.Text8", "@RecipeSystem.Results.Text2", MessageBoxIcon.Error);
                string Message = "Error at line - " + new StackTrace(ex, true).GetFrame(new StackTrace(ex, true).FrameCount - 1).GetFileLineNumber().ToString() + " - " + Environment.NewLine;
                Message += "Message : " + ex.Message + Environment.NewLine;
                Message += "Stacktrace : " + ex.StackTrace + Environment.NewLine; 

                File.WriteAllText("C:\\VW_" + DateTime.Now.ToString()+".txt", Message);
            }








        }

        async Task C_To_PLCAsyncIBN()
        {
            uint C_Id = (uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.03 Basket coating.00 Main.DB BC PD.Header.Data.MRId");

            if (C_Id <= 0)
            {
                ApplicationService.SetVariableValue("CPU1.PLC.Blocks.03 Basket coating.00 Main.DB BC HMI.PC.Handshake.from PC.Not loaded", true);
                new MessageBoxTask("@RecipeSystem.Results.Text7", "@RecipeSystem.Results.Text2", MessageBoxIcon.Error);
            }
            else
            {
                Coating C = GetCoatingData(C_Id);
                await C.LoadToPLC();
            }

            



        }
        Coating GetCoatingData(long _id)
        {
            Coating temp = new Coating();
            if (_id != -1)
            {
                DataTable DT = new MSSQLEAdapter("Recipes", "SELECT *  FROM Recipes_Coating WHERE Id = " + _id + "; ").DB_Output();

                if (DT.Rows.Count > 0)
                {
                    temp = new Coating()
                    {
                        Header = new RecipeInfo()
                        {
                            Id = (int)_id,
                            Name = (string)DT.Rows[0]["Name"],
                            Description = (string)DT.Rows[0]["Description"],
                        },
                        VWRecipe = new VWRecipe("Coating", (string)DT.Rows[0]["VWRecipe"])
                    };
                }
            }
            return temp;
        }

        #endregion

    }
}
