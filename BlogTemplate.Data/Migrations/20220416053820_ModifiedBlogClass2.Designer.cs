﻿// <auto-generated />
using System;
using BlogTemplate.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogTemplate.Data.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20220416053820_ModifiedBlogClass2")]
    partial class ModifiedBlogClass2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogTemplate.Domain.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("HeadImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("BlogID");

                    b.HasIndex("UserID");

                    b.ToTable("Blog");

                    b.HasData(
                        new
                        {
                            BlogID = 1,
                            Content = "",
                            Date = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            HeadImage = "mic.jpg",
                            Published = true,
                            Summary = "This is a blog post",
                            Title = "Pajamas",
                            Url = "bZxXU",
                            UserID = 1
                        },
                        new
                        {
                            BlogID = 2,
                            Content = "",
                            Date = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            HeadImage = "../images/climbing.jpg",
                            Published = false,
                            Summary = "This is a blog post",
                            Title = "Bananas",
                            Url = "lTidE",
                            UserID = 1
                        },
                        new
                        {
                            BlogID = 3,
                            Content = "",
                            Date = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            HeadImage = "../images/climbing.jpg",
                            Published = false,
                            Summary = "This is a blog post",
                            Title = "Biscuits",
                            Url = "Vlg9B",
                            UserID = 1
                        },
                        new
                        {
                            BlogID = 4,
                            Content = "",
                            Date = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            HeadImage = "../images/climbing.jpg",
                            Published = true,
                            Summary = "This is a blog post",
                            Title = "Puppies",
                            Url = "IuIy3",
                            UserID = 1
                        },
                        new
                        {
                            BlogID = 5,
                            Content = "",
                            Date = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            HeadImage = "../images/climbing.jpg",
                            Published = true,
                            Summary = "This is a blog post",
                            Title = "Death and despair",
                            Url = "rHlCJ",
                            UserID = 1
                        });
                });

            modelBuilder.Entity("BlogTemplate.Domain.PicContent", b =>
                {
                    b.Property<int>("PicContentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PicContentID");

                    b.ToTable("PicContent");

                    b.HasData(
                        new
                        {
                            PicContentID = 1,
                            Picture = "../images/ramen.jpg"
                        },
                        new
                        {
                            PicContentID = 2,
                            Picture = "../images/mic.jpg"
                        });
                });

            modelBuilder.Entity("BlogTemplate.Domain.TextContent", b =>
                {
                    b.Property<int>("TextContentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TextContentID");

                    b.ToTable("TextContent");

                    b.HasData(
                        new
                        {
                            TextContentID = 1,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce lobortis id mauris placerat imperdiet. Cras efficitur nisl tortor, sed lacinia eros viverra nec. Etiam vel finibus quam. Integer ac dictum augue. Nunc ac diam sed eros ullamcorper vehicula in eu tellus. Aenean mollis erat eros, id varius mi accumsan a. Nullam vel metus eget sem suscipit malesuada id ut lorem. In hac habitasse platea dictumst. Aliquam ut mauris a purus semper interdum. Aenean tempus arcu vulputate nisi venenatis mattis. Suspendisse sollicitudin semper quam non tristique."
                        },
                        new
                        {
                            TextContentID = 2,
                            Text = "Suspendisse eu sollicitudin odio, quis commodo tellus. Sed blandit ornare porttitor. Vestibulum in tristique tellus. Mauris sit amet dignissim ante. Curabitur accumsan laoreet consectetur. In accumsan cursus metus, cursus molestie turpis mattis sed. Suspendisse potenti. Vestibulum vel porta orci. Donec a laoreet orci. Etiam cursus odio id sollicitudin dapibus. Pellentesque rutrum pellentesque est, id tincidunt risus commodo id. Donec placerat ex ac faucibus sollicitudin. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos."
                        },
                        new
                        {
                            TextContentID = 3,
                            Text = "In eu quam id arcu iaculis consectetur quis ut eros. Curabitur luctus pellentesque lobortis. Vivamus laoreet et neque a rutrum. Aenean ac augue augue. Praesent placerat in est et malesuada. Aliquam ut cursus tortor, vel vulputate risus. Morbi id orci eget ipsum cursus luctus. Vestibulum sed magna feugiat, consectetur libero ut, laoreet dui. Etiam vel elit cursus, aliquam enim eu, dignissim nunc. Morbi consectetur eget dui sit amet aliquam. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque non dui egestas, malesuada arcu vel, tincidunt odio. Nullam nec elit nibh."
                        },
                        new
                        {
                            TextContentID = 4,
                            Text = "Vestibulum vehicula, nibh non finibus pretium, felis arcu efficitur sapien, at feugiat erat arcu non metus. Sed venenatis ac tortor nec ultricies. Nam felis ex, suscipit at malesuada sit amet, dictum vel urna. Phasellus nunc metus, ornare quis feugiat nec, vulputate vitae odio. Nullam in euismod erat, id ornare neque. Vivamus pellentesque, sapien quis imperdiet congue, massa turpis tincidunt elit, a dictum ex libero sodales nunc. Sed eget aliquet metus. Mauris quis suscipit massa, a porta tortor. Aenean semper ex est, vitae placerat ligula egestas at. Aenean eleifend pharetra elit et scelerisque. Cras imperdiet felis ut feugiat placerat. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nunc fermentum finibus eros id auctor. Quisque maximus mi sagittis efficitur mattis. In a congue velit. Nam tincidunt viverra gravida."
                        },
                        new
                        {
                            TextContentID = 5,
                            Text = "Aenean tempus ultricies tortor quis lacinia. Sed pretium, urna ac elementum volutpat, risus sem ultricies massa, eget dapibus orci ligula nec nulla. Praesent ut quam tortor. Praesent consectetur velit vel posuere aliquet. Ut aliquam, velit et cursus placerat, lectus nulla ultrices quam, sed convallis tortor libero nec orci. Vivamus in tristique nisi. Phasellus velit erat, faucibus nec congue at, pulvinar eu leo. Proin sed placerat justo. Integer lacinia lacinia tellus, ut bibendum eros. Curabitur vestibulum euismod tincidunt. Etiam condimentum molestie magna, at pulvinar arcu feugiat in. Aliquam dictum placerat mauris, vel mollis leo feugiat egestas. Donec pellentesque vestibulum mollis."
                        },
                        new
                        {
                            TextContentID = 6,
                            Text = "Cras varius, dolor in auctor finibus, felis nibh iaculis est, at fermentum purus est sit amet felis. Maecenas in ultrices elit, non congue turpis. Ut porta lacus justo, non convallis ex tincidunt ac. Sed ac erat augue. Aliquam pellentesque ultrices suscipit. Sed faucibus quam vitae molestie molestie. Integer vel pharetra nulla. Nulla tempus ac odio quis luctus. Mauris blandit lectus orci, a varius felis viverra in. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Vestibulum sed varius tortor."
                        });
                });

            modelBuilder.Entity("BlogTemplate.Domain.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessLevel")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            AccessLevel = 1,
                            FirstName = "Holly",
                            LastName = "Tim",
                            Password = "password",
                            Username = "AskingForArrays"
                        },
                        new
                        {
                            UserID = 2,
                            AccessLevel = 2,
                            FirstName = "Kirsten",
                            LastName = "Mills",
                            Password = "BPF80NIJ5WJ",
                            Username = "eleifend"
                        },
                        new
                        {
                            UserID = 3,
                            AccessLevel = 2,
                            FirstName = "Yoshio",
                            LastName = "Valentine",
                            Password = "JYR71ENW8KM",
                            Username = "accumsan"
                        },
                        new
                        {
                            UserID = 4,
                            AccessLevel = 2,
                            FirstName = "Mia",
                            LastName = "Lawson",
                            Password = "HPQ26TMD3IW",
                            Username = "fermentum"
                        },
                        new
                        {
                            UserID = 5,
                            AccessLevel = 2,
                            FirstName = "Wynter",
                            LastName = "Cabrera",
                            Password = "BBM78CFY6TJ",
                            Username = "Aliquam"
                        });
                });

            modelBuilder.Entity("BlogTemplate.Domain.UserComment", b =>
                {
                    b.Property<int>("UserCommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserCommentID");

                    b.HasIndex("BlogID");

                    b.HasIndex("UserID");

                    b.ToTable("UserComment");

                    b.HasData(
                        new
                        {
                            UserCommentID = 1,
                            BlogID = 1,
                            Comment = "LOL",
                            TimeStamp = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            UserID = 2
                        },
                        new
                        {
                            UserCommentID = 2,
                            BlogID = 2,
                            Comment = "Hahhahhahah",
                            TimeStamp = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            UserID = 3
                        },
                        new
                        {
                            UserCommentID = 3,
                            BlogID = 3,
                            Comment = "Damnnnnnn, this is awesome",
                            TimeStamp = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            UserID = 4
                        },
                        new
                        {
                            UserCommentID = 4,
                            BlogID = 4,
                            Comment = "Y U write dis?",
                            TimeStamp = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            UserID = 5
                        },
                        new
                        {
                            UserCommentID = 5,
                            BlogID = 5,
                            Comment = "So informative, thank you!",
                            TimeStamp = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            UserID = 2
                        });
                });

            modelBuilder.Entity("BlogTemplate.Domain.Blog", b =>
                {
                    b.HasOne("BlogTemplate.Domain.User", "User")
                        .WithMany("Blogs")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogTemplate.Domain.UserComment", b =>
                {
                    b.HasOne("BlogTemplate.Domain.Blog", "Blog")
                        .WithMany("UserComments")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogTemplate.Domain.User", "User")
                        .WithMany("UserComments")
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}