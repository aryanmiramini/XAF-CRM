using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;

namespace SimpleCRM.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("BO_Task")]
    public class Task : BaseObject
    {
        public Task(Session session)
            : base(session) { }


        public override void AfterConstruction()
        {
            base.AfterConstruction();

            Status = StatusEnum.ToDo;

        }

        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { SetPropertyValue("Subject", ref _subject, value); }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get { return _startDate; }
            set { SetPropertyValue("StartDate", ref _startDate, value); }
        }
        
        private DateTime _EndDate;
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { SetPropertyValue("EndDate", ref _EndDate, value); }
        }

        private Employee _assignedTo;
        [Association("Employee-Task")]
        public Employee AssignedTo
        {
            get { return _assignedTo; }
            set { SetPropertyValue("AssignedTo", ref _assignedTo, value); }
        }

        private Project _project;

        [Association("Project-Task")]
        public Project Project
        {
            get
            {
                return _project;
            }
            set
            {
                SetPropertyValue(nameof(Project), ref _project, value);
            }
        }

        private StatusEnum _status;
        public StatusEnum Status
        {
            get { return _status; }
            set { SetPropertyValue(nameof(Status), ref _status, value); }
        }

        public enum StatusEnum
        {
            ToDo = 0 ,
            InProgress = 1,
            Completed = 2,
            Canceled = 3
        }

    }
}
