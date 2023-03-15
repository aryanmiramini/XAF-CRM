using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System.ComponentModel;

namespace SimpleCRM.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Country")]
    [DefaultProperty("FullName")]
    [Appearance("ActiveContact", Criteria = "Active = true", TargetItems = "*", FontStyle = System.Drawing.FontStyle.Bold)]
    public class CompanyContact : BaseObject
    {
        public CompanyContact(Session session)
       : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Active = true;

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


        private bool _Active;
        [ImmediatePostData]
        public bool Active
        {
            get { return _Active; }
            set { SetPropertyValue<bool>(nameof(Active), ref _Active, value); }
        }

        
        private Company _Company;
        [Association]
        public Company Company
        {
            get { return _Company; }
            set { SetPropertyValue<Company>(nameof(Company), ref _Company, value); }
        }
    }
}