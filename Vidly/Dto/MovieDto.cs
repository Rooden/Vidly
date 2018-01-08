﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dto
{
    public class MovieDto
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public byte GenreId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}