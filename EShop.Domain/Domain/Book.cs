﻿using EShop.Domain.Domain;

namespace Eshop.Domain.Domain
{
    public class Book : BaseEntity
    {
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        public float? Price { get; set; }
        public string? PictureUrl { get; set; } 
        public ICollection<Author>? Authors { get; set; }
        public Publisher? Publisher { get; set; }
    }
}
