using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using SimpleCRM.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCRM.Module.Controllers
{
    public partial class CreateMeetingFromCompany : ViewController
    {
        public CreateMeetingFromCompany()
        {
            InitializeComponent();
        }
        protected override void OnActivated()
        {
            base.OnActivated();
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
        }
        protected override void OnDeactivated()
        {
            base.OnDeactivated();
        }

        private void actionCreateMeeting_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            Company company = (Company)View.CurrentObject;

            IObjectSpace space = View.ObjectSpace.CreateNestedObjectSpace();

            Meeting meeting = space.CreateObject<Meeting>();
            meeting.Company = space.GetObject<Company>(company);
            e.View = Application.CreateDetailView(space, meeting);
        }

        private void actionCreateMeeting_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {

        }
    }
}
