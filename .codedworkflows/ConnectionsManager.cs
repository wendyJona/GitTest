using UiPath.CodedWorkflows;
using System;

namespace examPrep
{
    public class ConnectionsManager
    {
        public ExcelFactory Excel { get; set; }
        public O365MailFactory O365Mail { get; set; }
        public Office365Factory Office365 { get; set; }
        public OneDriveFactory OneDrive { get; set; }

        public ConnectionsManager(ICodedWorkflowsServiceContainer resolver)
        {
            Excel = new ExcelFactory(resolver);
            O365Mail = new O365MailFactory(resolver);
            Office365 = new Office365Factory(resolver);
            OneDrive = new OneDriveFactory(resolver);
        }
    }
}