using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ToolCatalog.Models;

namespace ToolCatalog.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180412091511_Initial2")]
    partial class Initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToolCatalog.Models.Country", b =>
                {
                    b.Property<int>("IdCountry")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryName");

                    b.HasKey("IdCountry");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("ToolCatalog.Models.SSCUnit", b =>
                {
                    b.Property<int>("IdSSCUnit")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SSCName");

                    b.Property<string>("UnitName");

                    b.HasKey("IdSSCUnit");

                    b.ToTable("SSCUnits");
                });

            modelBuilder.Entity("ToolCatalog.Models.Tool", b =>
                {
                    b.Property<int>("IdTool")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CurrentVersion");

                    b.Property<DateTime>("DateOfCreated");

                    b.Property<int>("IdCountry");

                    b.Property<int>("IdSSCUnit");

                    b.Property<string>("ImageThumbnailUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsNew");

                    b.Property<string>("Manual");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.Property<string>("Tag");

                    b.HasKey("IdTool");

                    b.HasIndex("IdCountry");

                    b.HasIndex("IdSSCUnit");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("ToolCatalog.Models.Tool", b =>
                {
                    b.HasOne("ToolCatalog.Models.Country", "Country")
                        .WithMany("Tools")
                        .HasForeignKey("IdCountry")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ToolCatalog.Models.SSCUnit", "SSCUnit")
                        .WithMany("Tools")
                        .HasForeignKey("IdSSCUnit")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
