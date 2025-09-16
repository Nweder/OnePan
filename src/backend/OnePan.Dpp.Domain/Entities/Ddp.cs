using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// src/backend/OnePan.Dpp.Domain/Entities/Dpp.cs
namespace OnePan.Dpp.Domain.Entities;

public class Dpp
{
    public string ProductId { get; set; } = "";
    public double Co2 { get; set; }
    public DateTime UpdatedAt { get; set; }
}
