﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntitySrvr.Models;

[Table("lettertype")]
[Index("Type", Name = "IX_lettertype", IsUnique = true)]
public partial class Lettertype
{
    [Key]
    [Column("type")]
    [StringLength(24)]
    [Unicode(false)]
    public string Type { get; set; }

    [Column("description")]
    [StringLength(255)]
    [Unicode(false)]
    public string Description { get; set; }

    [InverseProperty("TypeNavigation")]
    public virtual ICollection<Letter> Letters { get; } = new List<Letter>();
}