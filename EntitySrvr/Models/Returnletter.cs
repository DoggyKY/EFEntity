﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntitySrvr.Models;

public partial class Returnletter
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(140)]
    [Unicode(false)]
    public string Name { get; set; }

    [Column("address")]
    [StringLength(255)]
    [Unicode(false)]
    public string Address { get; set; }

    [Column("city")]
    [StringLength(50)]
    [Unicode(false)]
    public string City { get; set; }

    [Column("state")]
    [StringLength(2)]
    [Unicode(false)]
    public string State { get; set; }

    [Column("zip")]
    [StringLength(10)]
    [Unicode(false)]
    public string Zip { get; set; }

    [Column("re")]
    [StringLength(140)]
    [Unicode(false)]
    public string Re { get; set; }

    [Column("dt", TypeName = "datetime")]
    public DateTime? Dt { get; set; }

    [Column("userid")]
    [StringLength(22)]
    [Unicode(false)]
    public string Userid { get; set; }

    [Column("other")]
    [StringLength(2048)]
    [Unicode(false)]
    public string Other { get; set; }

    [Column("certauth")]
    public int Certauth { get; set; }

    [Column("assname")]
    public int Assname { get; set; }

    [Column("amend")]
    public int Amend { get; set; }

    [Column("artinc")]
    public int Artinc { get; set; }

    [Column("reinst")]
    public int Reinst { get; set; }

    [Column("merger")]
    public int Merger { get; set; }

    [Column("lpart")]
    public int Lpart { get; set; }

    [Column("llcpo")]
    public int Llcpo { get; set; }

    [Column("llcsoc")]
    public int Llcsoc { get; set; }

    [Column("diss")]
    public int Diss { get; set; }

    [Column("corpsoc")]
    public int Corpsoc { get; set; }

    [Column("fee", TypeName = "money")]
    public decimal? Fee { get; set; }

    [Column("fee2", TypeName = "money")]
    public decimal? Fee2 { get; set; }

    [Column("llcfcofa")]
    public int Llcfcofa { get; set; }

    [Column("artorg")]
    public int Artorg { get; set; }

    [Column("resreg")]
    public int Resreg { get; set; }

    [Column("image")]
    [StringLength(255)]
    [Unicode(false)]
    public string Image { get; set; }

    [Column("undeliverablemail")]
    public int? Undeliverablemail { get; set; }
}