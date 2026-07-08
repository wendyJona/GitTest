using examPrep.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace examPrep
{
    public class uiBank : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
           var homescreen = uiAutomation.Open("home");
           var loanApplicationScreen = uiAutomation.Attach("email address");
            
            loanApplicationScreen.TypeInto("Age", "10");
        }
    }
}