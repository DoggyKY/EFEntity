﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntitySrvr.Models;

[Table("erslog")]
[Index("Cbi", Name = "IX_erslog_CBI")]
[Index("Id", Name = "IX_erslog_ID")]
[Index("Logdate", Name = "IX_erslog_logdate")]
[Index("Subid", Name = "IX_erslog_subid")]
[Index("Service", "Cbi", Name = "erslog_ServCBI")]
public partial class Erslog
{
    [Key]
    [Column("ctr")]
    public int Ctr { get; set; }

    [Column("service")]
    [StringLength(50)]
    public string Service { get; set; }

    [Column("logdate", TypeName = "datetime")]
    public DateTime? Logdate { get; set; }

    [Column("subid")]
    public int? Subid { get; set; }

    [Column("type")]
    [StringLength(50)]
    public string Type { get; set; }

    [Column("source")]
    [StringLength(10)]
    public string Source { get; set; }

    [Column("xml")]
    public string Xml { get; set; }

    [Column("ID")]
    [StringLength(7)]
    public string Id { get; set; }

    [Column("CBI")]
    [StringLength(10)]
    public string Cbi { get; set; }
}