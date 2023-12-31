﻿using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Title = "karagöz ve hacivat", Price = 90 },
                new Book { Id = 2, Title = "mesneviden seçmeler", Price = 130 },
                new Book { Id = 3, Title = "dede korkut", Price = 140 }
                );
        }
    }
}
