﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 17.02.2012
 * Time: 13:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Tmx.Commands
{
    using System.Management.Automation;
    using Interfaces;

    /// <summary>
    /// Description of AddTmxTestResultDetailCommand.
    /// </summary>
    [Cmdlet(VerbsCommon.Add, "TmxTestResultDetail")]
    public class AddTmxTestResultDetailCommand : TestResultDetailCmdletBase
    {
        protected override void BeginProcessing()
        {
            CheckCmdletParameters();
            
            WriteVerbose(this, TestResultDetail);
            // 20140317
            // turning off the logger
            // Tmx.Logger.TmxLogger.Info(this.TestResultDetail);
            if (Echo)
                WriteObject(TestResultDetail);
            
            var dataObject = new TestResultDetailCmdletBaseDataObject {
                Finished = Finished,
                TestResultStatus = TestResultStatus
            };
            
            TestData.AddTestResultTextDetail(dataObject, TestResultDetail);
        }
    }
}
