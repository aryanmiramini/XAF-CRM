using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace SimpleCRM.Module.BusinessObjects
{
    //[ImageName("BO_Country")]
    [Appearance("OpenToWork", TargetItems = "*", FontStyle = System.Drawing.FontStyle.Bold)]
    public class Employee : BaseObject
    {
        public Employee(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set { SetPropertyValue<string>(nameof(FirstName), ref _FirstName, value); }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { SetPropertyValue<string>(nameof(LastName), ref _LastName, value); }
        }

        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        public string FullName
        {
            get
            {
                return ObjectFormatter.Format("{FirstName} {LastName}", this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty);
            }
        }

        private string _PhoneNumber;
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { SetPropertyValue<string>(nameof(PhoneNumber), ref _PhoneNumber, value); }
        }

        private string _EmailAddress;
        public string EmailAddress
        {
            get { return _FirstName; }
            set { SetPropertyValue<string>(nameof(EmailAddress), ref _EmailAddress, value); }
        }

        private bool _OpenToWork;
        public bool OpenToWork
        {
            get { return _OpenToWork; }
            set { SetPropertyValue<bool>(nameof(OpenToWork), ref _OpenToWork, value); }
        }

        private JobPosition _Job;

        [DataSourceProperty("Employee.JobPosition")]

        public JobPosition Job
        {
            get { return _Job; }
            set { SetPropertyValue<JobPosition>(nameof(Job), ref _Job, value); }
        }

        public enum JobPosition
        {
            Accountant,
            Programmer,
            Designer
        }

        [DevExpress.Xpo.Aggregated, Association("Employee-Project")]
        public XPCollection<Project> Projects
        {
            get { return GetCollection<Project>(nameof(Projects)); }
        }


        [Association("Employee-Task")]
        public XPCollection<Task> AssignedTo
        {
            get { return GetCollection<Task>(nameof(AssignedTo)); }
             
        }
       
    }
}