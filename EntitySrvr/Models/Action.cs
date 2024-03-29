﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntitySrvr.Models;

public partial class Action
{
    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string Code { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; }

    [Column("interactive")]
    [StringLength(1)]
    [Unicode(false)]
    public string Interactive { get; set; }

    public bool Termination { get; set; }
}