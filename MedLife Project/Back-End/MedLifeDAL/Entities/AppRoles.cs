﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MedLifeDAL.Entities
{
    public partial class AppRoles
    {
        public AppRoles()
        {
            AppRoleClaims = new HashSet<AppRoleClaims>();
            AppUserRoles = new HashSet<AppUserRoles>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }

        public virtual ICollection<AppRoleClaims> AppRoleClaims { get; set; }
        public virtual ICollection<AppUserRoles> AppUserRoles { get; set; }
    }
}