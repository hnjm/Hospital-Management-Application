﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MedLifeDAL.Entities
{
    public partial class AppUserLogins
    {
        public Guid LoginProvider { get; set; }
        public Guid ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public Guid UserId { get; set; }

        public virtual AppUser User { get; set; }
    }
}