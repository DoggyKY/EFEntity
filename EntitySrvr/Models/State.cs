﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntitySrvr.Models;

[Table("states")]
[Index("Code", Name = "code")]
public partial class State
{
    [Key]
    [Column("code")]
    [StringLength(2)]
    [Unicode(false)]
    public string Code { get; set; }

    [Column("name")]
    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; }

    [Column("us")]
    public bool Us { get; set; }

    [Column("countrycode")]
    [StringLength(3)]
    public string Countrycode { get; set; }
}