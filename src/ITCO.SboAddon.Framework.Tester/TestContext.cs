﻿using ITCO.SboAddon.Framework.Dialogs;
using ITCO.SboAddon.Framework.Dialogs.Inputs;
using ITCO.SboAddon.Framework.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ITCO.SboAddon.Framework.Tester
{
    internal class TestContext : ApplicationContext
    {
        public TestContext()
        {
            var connectionString = "0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056";

            try
            {
                SboApp.Connect(connectionString);

                Test_GetString();       
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Error: {0}\nExiting...", e.Message));
                Application.Exit();
            }
        }

        private void Test_GetString()
        {
            var s = InputHelper.GetInputs("Test", new List<IDialogInput>() {
                new TextDialogInput("t1", "Title 1"),
                new TextDialogInput("t2", "Title 2", "def 2"),
                new TextDialogInput("t3", "Title 3 Req", null, true),
                new DateDialogInput("t4", "Date 1"),
                new CheckboxDialogInput("t5", "Check 1", true),
                new CheckboxDialogInput("t6", "Check off", false)
            });
        }
    }
}
