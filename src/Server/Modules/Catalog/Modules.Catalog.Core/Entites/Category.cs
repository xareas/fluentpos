﻿using FluentPOS.Shared.Abstractions.Domain;

namespace FluentPOS.Modules.Catalogs.Core.Entites
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
