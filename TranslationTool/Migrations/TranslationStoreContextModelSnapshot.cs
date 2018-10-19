﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TranslationTool.Models;

namespace TranslationTool.Migrations
{
    [DbContext(typeof(TranslationStoreContext))]
    partial class TranslationStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TranslationTool.Models.Text", b =>
                {
                    b.Property<string>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OriginalText");

                    b.Property<string>("TranslatorNotes");

                    b.HasKey("Key");

                    b.HasAlternateKey("Id");

                    b.ToTable("Text");
                });

            modelBuilder.Entity("TranslationTool.Models.Translation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lang");

                    b.Property<string>("Text");

                    b.Property<string>("TextKey");

                    b.HasKey("Id");

                    b.HasIndex("TextKey");

                    b.ToTable("Translation");
                });

            modelBuilder.Entity("TranslationTool.Models.Translation", b =>
                {
                    b.HasOne("TranslationTool.Models.Text")
                        .WithMany("Translations")
                        .HasForeignKey("TextKey");
                });
#pragma warning restore 612, 618
        }
    }
}