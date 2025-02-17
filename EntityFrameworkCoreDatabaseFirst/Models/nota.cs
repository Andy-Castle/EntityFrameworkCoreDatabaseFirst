﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreDatabaseFirst.Models;

public partial class nota
{
    [Key]
    public int idnota { get; set; }

    [StringLength(50)]
    public string titulo { get; set; } = null!;

    [StringLength(200)]
    public string? descripcion { get; set; }

    public DateOnly fecha { get; set; }

    public int? usuario_id { get; set; }
}
