﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntitySrvr.Models;

[Table("NewArpOfficer")]
[Index("Arpctr", "Office", Name = "IX_Arpctr")]
public partial class NewArpOfficer
{
    [Key]
    [Column("ctr")]
    public int Ctr { get; set; }

    /// <summary>
    /// Pointer to NewArponline record
    /// </summary>
    [Column("arpctr")]
    public int Arpctr { get; set; }

    [Column("office")]
    [StringLength(1)]
    [Unicode(false)]
    public string Office { get; set; }

    [Column("fname")]
    [StringLength(20)]
    [Unicode(false)]
    public string Fname { get; set; }

    [Column("mname")]
    [StringLength(20)]
    [Unicode(false)]
    public string Mname { get; set; }

    [Column("lname")]
    [StringLength(255)]
    [Unicode(false)]
    public string Lname { get; set; }

    [Column("addr")]
    [StringLength(255)]
    [Unicode(false)]
    public string Addr { get; set; }
}