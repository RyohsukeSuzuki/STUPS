﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 11/9/2012
 * Time: 6:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Tmx
{
    /// <summary>
    /// Description of TLSrvAddTestCaseCommand.
    /// </summary>
    internal class TLSrvAddTestCaseCommand : TLSrvCommand
    {
        internal TLSrvAddTestCaseCommand(TLSCmdletBase cmdlet) : base (cmdlet)
        {
        }
        
        internal override void Execute()
        {
            var cmdlet = (AddTLTestCaseCommand)Cmdlet;
            
            foreach (Meyn.TestLink.TestSuite testSuite in cmdlet.InputObject) {
                TLHelper.AddTestCase(
                    Cmdlet, 
                    cmdlet.Name,
                    cmdlet.AuthorLogin,
                    testSuite.id,
                    TLAddinData.CurrentTestProject.id,
                    cmdlet.Summary,
                    cmdlet.Keyword,
                    cmdlet.Order,
                    cmdlet.CheckDuplicatedName,
                    cmdlet.ActionDuplicatedName,
                    cmdlet.ExecutionType,
                    cmdlet.Importance);
            }
        }
    }
}
