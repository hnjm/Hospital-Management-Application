﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MedLifeDAL.Entities
{
    public partial class Status
    {
        public Status()
        {
            AppoinmentBooking = new HashSet<AppoinmentBooking>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AppoinmentBooking> AppoinmentBooking { get; set; }
    }
}