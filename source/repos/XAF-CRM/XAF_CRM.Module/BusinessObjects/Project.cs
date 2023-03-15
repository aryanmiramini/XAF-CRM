using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace SimpleCRM.Module.BusinessObjects
{
    [DefaultClassOptions]

    public class Project : BaseObject
    {
        public Project(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();

        }

        private string _ProjectName;
        public string ProjectName
        {
            get { return _ProjectName; }
            set { SetPropertyValue(nameof(ProjectName), ref _ProjectName, value); }
        }

        private Employee _assignedTo;
        [Association("Employee-Project")]
        public Employee AssignedTo
        {
            get { return _assignedTo; }
            set { SetPropertyValue(nameof(AssignedTo), ref _assignedTo, value); }
        }


        [Association("Project-Task")]

        public XPCollection<Task> Tasks
        {
            get
            {
                return GetCollection<Task>(nameof(Tasks));
            }
        }



    }
}