﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model.DTO
{
    public class VillaDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public int Occupancy { get; set; }

        public int Sqft { get; set; }


    }
}
