﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutricareApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutricareApp.Data.Mapping
{
    class RecipeMap : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.ToTable("recipe").HasKey(c => c.RecipeId);
            builder.Property(c => c.RecipeId).HasColumnName("category_id");
            builder.Property(c => c.Name).HasColumnName("name").HasMaxLength(50).IsUnicode(false);
            builder.Property(c => c.Descripcion).HasColumnName("descripcion").HasMaxLength(250).IsUnicode(false);
            builder.Property(c => c.Preparation).HasColumnName("preparation").HasMaxLength(500);
            builder.Property(c => c.Ingredients).HasColumnName("ingredients").HasMaxLength(500);
            builder.Property(c => c.Favotite).HasColumnName("favorite").HasColumnType("int");
            builder.Property(c => c.CreatedAt).HasColumnName("created_At");
            builder.Property(c => c.LastModification).HasColumnName("Last_Modification");
            //FK con nutricionist
            //builder.HasOne(c => c.Nutricionist).WithMany(c => c.Nutricionist).HasForeignKey(c => c.NutricionistId).HasConstraintName("fk_nutricionist_recipe").IsRequired(true);
        }
    }
}

