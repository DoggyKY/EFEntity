﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntitySrvr.Models;

[Table("returnlettersubjects")]
public partial class Returnlettersubject
{
    [Key]
    [Column("ctr")]
    public int Ctr { get; set; }

    [Column("group")]
    [StringLength(4)]
    [Unicode(false)]
    public string Group { get; set; }

    [Column("returnemail")]
    [StringLength(255)]
    [Unicode(false)]
    public string Returnemail { get; set; }

    [Column("returnsubject")]
    [StringLength(255)]
    [Unicode(false)]
    public string Returnsubject { get; set; }
}