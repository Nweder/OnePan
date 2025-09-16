using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnePan.Dpp.Application.Dtos;

// Enkel DTO som används när man skickar nytt CO₂-värde från frontend
public class Co2UpdateDto
{
    public double Co2 { get; set; }

}


// If we want to recourd in the future: 

// public record Co2UpdateDto
// {
//     public double Co2 { get; set; }
// }
