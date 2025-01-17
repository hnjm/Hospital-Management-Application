﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MedLifeDAL.Entities
{
    public partial class AppoinmentBooking
    {
        public int Id { get; set; }
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public DateTime AppointmentOn { get; set; }
        public int HealthProblemId { get; set; }
        public string Others { get; set; }
        public string Priscription { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? ModifiedBy { get; set; }

        public virtual AppUser CreatedByNavigation { get; set; }
        public virtual AppUser Doctor { get; set; }
        public virtual HealthProblems HealthProblem { get; set; }
        public virtual AppUser ModifiedByNavigation { get; set; }
        public virtual AppUser Patient { get; set; }
        public virtual Status Status { get; set; }
    }
}