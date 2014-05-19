﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Application.Core.Data;
using LMPlatform.Models.DP;
using LMPlatform.Models.KnowledgeTesting;

namespace LMPlatform.Models
{
    public class Student : ModelBase
    {
        public string Email
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string MiddleName
        {
            get;
            set;
        }

        public User User
        {
            get;
            set;
        }

        public int GroupId
        {
            get;
            set;
        }

        public Group Group
        {
            get;
            set;
        }

        [NotMapped]
        public string FullName
        {
            get { return string.Format("{0} {1} {2}", LastName, FirstName, MiddleName); }
        }

        public ICollection<SubjectStudent> SubjectStudents
        {
            get;
            set;
        }

        public ICollection<TestUnlock> TestUnlocks
        {
            get;
            set;
        }

        public virtual ICollection<AssignedDiplomProject> AssignedDiplomProjects
        {
            get;
            set;
        } 

        public ICollection<LecturesVisitMark> LecturesVisitMarks { get; set; } 

        public ICollection<ScheduleProtectionLabMark> ScheduleProtectionLabMarks { get; set; } 

        public ICollection<StudentLabMark> StudentLabMarks { get; set; } 

        public ICollection<ScheduleProtectionPracticalMark> ScheduleProtectionPracticalMarks { get; set; }

        public ICollection<StudentPracticalMark> StudentPracticalMarks { get; set; } 
    }
}