﻿using System;
using System.Collections.Generic;

namespace KindergartenAppService.Models
{
    public class Kid: UniqueEntity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        //public Guid TutorId { get; set; }
        public Tutor Tutor { get; set; }
        public virtual ICollection<MedicalRecord> MedicalRecords { get; set; }
        public virtual ICollection<FeedingKid> FeedingKids { get; set; }
        public virtual ICollection<Precense> Precenses { get; set; }

    }
}