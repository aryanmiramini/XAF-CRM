using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace SimpleCRM.Module.BusinessObjects
{
    [DefaultClassOptions]
    [MapInheritance(MapInheritanceType.ParentTable)]

    public class Meeting : Event
    {
        public Meeting(Session session)
             : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private Company _Company;
        [ImmediatePostData]
        public Company Company
        {
            get { return _Company; }
            set { SetPropertyValue<Company>(nameof(Company), ref _Company, value); }
        }

        private CompanyContact _PrimaryContact;
        [DataSourceProperty("Company.Contacts")]
        public CompanyContact PrimaryContact
        {
            get { return _PrimaryContact; }
            set { SetPropertyValue<CompanyContact>(nameof(PrimaryContact), ref _PrimaryContact, value); }
        }
    }
}