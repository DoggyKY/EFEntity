﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntitySrvr.Models;

[Table("ReturnLetterText")]
public partial class ReturnLetterText
{
    [Key]
    [Column("ctr")]
    public int Ctr { get; set; }

    [Column("ispanel")]
    public bool? Ispanel { get; set; }

    [Column("isactive")]
    public bool? Isactive { get; set; }

    [Column("panel")]
    [StringLength(24)]
    [Unicode(false)]
    public string Panel { get; set; }

    [Column("title")]
    [StringLength(255)]
    [Unicode(false)]
    public string Title { get; set; }

    [Column("field")]
    [StringLength(24)]
    [Unicode(false)]
    public string Field { get; set; }

    [Column("mask")]
    public int? Mask { get; set; }

    [Column("text")]
    [Unicode(false)]
    public string Text { get; set; }

    [Column("comment")]
    [StringLength(255)]
    [Unicode(false)]
    public string Comment { get; set; }

    [Column("timestamp")]
    public byte[] Timestamp { get; set; }

    [Column("min")]
    public int? Min { get; set; }

    [Column("max")]
    public int? Max { get; set; }
}