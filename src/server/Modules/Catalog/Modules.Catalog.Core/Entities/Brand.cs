﻿using FluentPOS.Shared.Core.Domain;

namespace FluentPOS.Modules.Catalog.Core.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Detail { get; set; }
    }
}