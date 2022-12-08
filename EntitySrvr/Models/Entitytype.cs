﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntitySrvr.Models;

[Table("entitytypes")]
[Index("Code", Name = "Code")]
[Index("Comptyp", Name = "comptyp")]
public partial class Entitytype
{
    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string Code { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; }

    [Column("comptyp")]
    [StringLength(2)]
    [Unicode(false)]
    public string Comptyp { get; set; }
}