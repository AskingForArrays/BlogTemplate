using BlogTemplate.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace BlogTemplate.Data
{
    public class BlogContext : DbContext
    {

        public BlogContext() : base() { }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<PicContent> PicContents { get; set; }
        public DbSet<TextContent> TextContent { get; set; }
        public DbSet<UserComment> UserComments { get; set; }
        public DbSet<User> Users { get; set; }


        public static byte[] ImageToByteConversion(string imageName)
        {


            //Initialize a file stream to read the image file
            FileStream fs = new FileStream(imageName, FileMode.Open, FileAccess.Read);

            //Initialize a byte array with size of stream
            byte[] imgByteArr = new byte[fs.Length];

            //Read data from the file stream and put into the byte array
            fs.Read(imgByteArr, 0, Convert.ToInt32(fs.Length));

            //Close a file stream
            fs.Close();

            return imgByteArr;
         }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\sqlexpress;Database=BlogTemplate;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserID = 1,
                    Username = "AskingForArrays",
                    Password = "password",
                    FirstName = "Holly",
                    LastName = "Tim",
                    AccessLevel = 1
                },
                new User
                {
                    UserID = 2,
                    Username = "eleifend",
                    Password = "BPF80NIJ5WJ",
                    FirstName = "Kirsten",
                    LastName = "Mills",
                    AccessLevel = 2
                },
                new User
                {
                    UserID = 3,
                    Username = "accumsan",
                    Password = "JYR71ENW8KM",
                    FirstName = "Yoshio",
                    LastName = "Valentine",
                    AccessLevel = 2
                },
                new User
                {
                    UserID = 4,
                    Username = "fermentum",
                    Password = "HPQ26TMD3IW",
                    FirstName = "Mia",
                    LastName = "Lawson",
                    AccessLevel = 2
                },
                new User
                {
                    UserID = 5,
                    Username = "Aliquam",
                    Password = "BBM78CFY6TJ",
                    FirstName = "Wynter",
                    LastName = "Cabrera",
                    AccessLevel = 2
                });


            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    BlogID = 1,
                    Title = "Pajamas",
                    Date = new DateTime(2008, 5, 1, 8, 30, 52),
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce lobortis id mauris placerat imperdiet. Cras efficitur nisl tortor, sed lacinia eros viverra nec. Etiam vel finibus quam. Integer ac dictum augue. Nunc ac diam sed eros ullamcorper vehicula in eu tellus. Aenean mollis erat eros, id varius mi accumsan a. Nullam vel metus eget sem suscipit malesuada id ut lorem. In hac habitasse platea dictumst. Aliquam ut mauris a purus semper interdum. Aenean tempus arcu vulputate nisi venenatis mattis. Suspendisse sollicitudin semper quam non tristique.",
                    UserID = 1,
                    Url = 1.ToString(),
                    MainImage = ImageToByteConversion("./images/ramen.jpg"),
                },
                new Blog
                {
                    BlogID = 2,
                    Title = "Bananas",
                    Date = new DateTime(2008, 5, 1, 8, 30, 52),
                    Content = "Suspendisse eu sollicitudin odio, quis commodo tellus. Sed blandit ornare porttitor. Vestibulum in tristique tellus. Mauris sit amet dignissim ante. Curabitur accumsan laoreet consectetur. In accumsan cursus metus, cursus molestie turpis mattis sed. Suspendisse potenti. Vestibulum vel porta orci. Donec a laoreet orci. Etiam cursus odio id sollicitudin dapibus. Pellentesque rutrum pellentesque est, id tincidunt risus commodo id. Donec placerat ex ac faucibus sollicitudin. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.",
                    UserID = 1,
                    Url = 2.ToString(),
                    MainImage = ImageToByteConversion("./images/ramen.jpg"),
                },
                new Blog
                {
                    BlogID = 3,
                    Title = "Biscuits",
                    Date = new DateTime(2008, 5, 1, 8, 30, 52),
                    Content = "In eu quam id arcu iaculis consectetur quis ut eros. Curabitur luctus pellentesque lobortis. Vivamus laoreet et neque a rutrum. Aenean ac augue augue. Praesent placerat in est et malesuada. Aliquam ut cursus tortor, vel vulputate risus. Morbi id orci eget ipsum cursus luctus. Vestibulum sed magna feugiat, consectetur libero ut, laoreet dui. Etiam vel elit cursus, aliquam enim eu, dignissim nunc. Morbi consectetur eget dui sit amet aliquam. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque non dui egestas, malesuada arcu vel, tincidunt odio. Nullam nec elit nibh.",
                    UserID = 1,
                    Url = 3.ToString(),
                    MainImage = ImageToByteConversion("./images/ramen.jpg"),
                },
                new Blog
                {
                    BlogID = 4,
                    Title = "Puppies",
                    Date = new DateTime(2008, 5, 1, 8, 30, 52),
                    Content = "Vestibulum vehicula, nibh non finibus pretium, felis arcu efficitur sapien, at feugiat erat arcu non metus. Sed venenatis ac tortor nec ultricies. Nam felis ex, suscipit at malesuada sit amet, dictum vel urna. Phasellus nunc metus, ornare quis feugiat nec, vulputate vitae odio. Nullam in euismod erat, id ornare neque. Vivamus pellentesque, sapien quis imperdiet congue, massa turpis tincidunt elit, a dictum ex libero sodales nunc. Sed eget aliquet metus. Mauris quis suscipit massa, a porta tortor. Aenean semper ex est, vitae placerat ligula egestas at. Aenean eleifend pharetra elit et scelerisque. Cras imperdiet felis ut feugiat placerat. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nunc fermentum finibus eros id auctor. Quisque maximus mi sagittis efficitur mattis. In a congue velit. Nam tincidunt viverra gravida.",
                    UserID = 1,
                    Url = 4.ToString(),
                    MainImage = ImageToByteConversion("./images/climbing.jpg"),
                },
                new Blog
                {
                    BlogID = 5,
                    Title = "Death and despair",
                    Date = new DateTime(2008, 5, 1, 8, 30, 52),
                    Content = "Aenean tempus ultricies tortor quis lacinia. Sed pretium, urna ac elementum volutpat, risus sem ultricies massa, eget dapibus orci ligula nec nulla. Praesent ut quam tortor. Praesent consectetur velit vel posuere aliquet. Ut aliquam, velit et cursus placerat, lectus nulla ultrices quam, sed convallis tortor libero nec orci. Vivamus in tristique nisi. Phasellus velit erat, faucibus nec congue at, pulvinar eu leo. Proin sed placerat justo. Integer lacinia lacinia tellus, ut bibendum eros. Curabitur vestibulum euismod tincidunt. Etiam condimentum molestie magna, at pulvinar arcu feugiat in. Aliquam dictum placerat mauris, vel mollis leo feugiat egestas. Donec pellentesque vestibulum mollis.",
                    UserID = 1,
                    Url = 5.ToString(),
                    MainImage = ImageToByteConversion("./images/climbing.jpg"),
                }
                );

            modelBuilder.Entity<UserComment>()
                .HasData(
                new UserComment
                {
                    UserCommentID = 1,
                    UserID = 2,
                    BlogID = 1,
                    Comment = "LOL",
                    TimeStamp = new DateTime(2008, 5, 1, 8, 30, 52)
                },
                new UserComment
                {
                    UserCommentID = 2,
                    UserID = 3,
                    BlogID = 2,
                    Comment = "Hahhahhahah",
                    TimeStamp = new DateTime(2008, 5, 1, 8, 30, 52)
                },
                new UserComment
                {
                    UserCommentID = 3,
                    UserID = 4,
                    BlogID = 3,
                    Comment = "Damnnnnnn, this is awesome",
                    TimeStamp = new DateTime(2008, 5, 1, 8, 30, 52)
                },
                new UserComment
                {
                    UserCommentID = 4,
                    UserID = 5,
                    BlogID = 4,
                    Comment = "Y U write dis?",
                    TimeStamp = new DateTime(2008, 5, 1, 8, 30, 52)
                },
                new UserComment
                {
                    UserCommentID = 5,
                    UserID = 2,
                    BlogID = 5,
                    Comment = "So informative, thank you!",
                    TimeStamp = new DateTime(2008, 5, 1, 8, 30, 52)
                });


            modelBuilder.Entity<TextContent>().HasData(
                new TextContent
                {
                    TextContentID = 1,
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce lobortis id mauris placerat imperdiet. Cras efficitur nisl tortor, sed lacinia eros viverra nec. Etiam vel finibus quam. Integer ac dictum augue. Nunc ac diam sed eros ullamcorper vehicula in eu tellus. Aenean mollis erat eros, id varius mi accumsan a. Nullam vel metus eget sem suscipit malesuada id ut lorem. In hac habitasse platea dictumst. Aliquam ut mauris a purus semper interdum. Aenean tempus arcu vulputate nisi venenatis mattis. Suspendisse sollicitudin semper quam non tristique."
                },
                new TextContent
                {
                    TextContentID = 2,
                    Text = "Suspendisse eu sollicitudin odio, quis commodo tellus. Sed blandit ornare porttitor. Vestibulum in tristique tellus. Mauris sit amet dignissim ante. Curabitur accumsan laoreet consectetur. In accumsan cursus metus, cursus molestie turpis mattis sed. Suspendisse potenti. Vestibulum vel porta orci. Donec a laoreet orci. Etiam cursus odio id sollicitudin dapibus. Pellentesque rutrum pellentesque est, id tincidunt risus commodo id. Donec placerat ex ac faucibus sollicitudin. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos."
                },
                new TextContent
                {
                    TextContentID = 3,
                    Text = "In eu quam id arcu iaculis consectetur quis ut eros. Curabitur luctus pellentesque lobortis. Vivamus laoreet et neque a rutrum. Aenean ac augue augue. Praesent placerat in est et malesuada. Aliquam ut cursus tortor, vel vulputate risus. Morbi id orci eget ipsum cursus luctus. Vestibulum sed magna feugiat, consectetur libero ut, laoreet dui. Etiam vel elit cursus, aliquam enim eu, dignissim nunc. Morbi consectetur eget dui sit amet aliquam. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque non dui egestas, malesuada arcu vel, tincidunt odio. Nullam nec elit nibh."
                },
                new TextContent
                {
                    TextContentID = 4,
                    Text = "Vestibulum vehicula, nibh non finibus pretium, felis arcu efficitur sapien, at feugiat erat arcu non metus. Sed venenatis ac tortor nec ultricies. Nam felis ex, suscipit at malesuada sit amet, dictum vel urna. Phasellus nunc metus, ornare quis feugiat nec, vulputate vitae odio. Nullam in euismod erat, id ornare neque. Vivamus pellentesque, sapien quis imperdiet congue, massa turpis tincidunt elit, a dictum ex libero sodales nunc. Sed eget aliquet metus. Mauris quis suscipit massa, a porta tortor. Aenean semper ex est, vitae placerat ligula egestas at. Aenean eleifend pharetra elit et scelerisque. Cras imperdiet felis ut feugiat placerat. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nunc fermentum finibus eros id auctor. Quisque maximus mi sagittis efficitur mattis. In a congue velit. Nam tincidunt viverra gravida."
                },
                new TextContent
                {
                    TextContentID = 5,
                    Text = "Aenean tempus ultricies tortor quis lacinia. Sed pretium, urna ac elementum volutpat, risus sem ultricies massa, eget dapibus orci ligula nec nulla. Praesent ut quam tortor. Praesent consectetur velit vel posuere aliquet. Ut aliquam, velit et cursus placerat, lectus nulla ultrices quam, sed convallis tortor libero nec orci. Vivamus in tristique nisi. Phasellus velit erat, faucibus nec congue at, pulvinar eu leo. Proin sed placerat justo. Integer lacinia lacinia tellus, ut bibendum eros. Curabitur vestibulum euismod tincidunt. Etiam condimentum molestie magna, at pulvinar arcu feugiat in. Aliquam dictum placerat mauris, vel mollis leo feugiat egestas. Donec pellentesque vestibulum mollis."

                },
                new TextContent
                {
                    TextContentID = 6,
                    Text = "Cras varius, dolor in auctor finibus, felis nibh iaculis est, at fermentum purus est sit amet felis. Maecenas in ultrices elit, non congue turpis. Ut porta lacus justo, non convallis ex tincidunt ac. Sed ac erat augue. Aliquam pellentesque ultrices suscipit. Sed faucibus quam vitae molestie molestie. Integer vel pharetra nulla. Nulla tempus ac odio quis luctus. Mauris blandit lectus orci, a varius felis viverra in. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Vestibulum sed varius tortor."
                });


            modelBuilder.Entity<PicContent>().HasData(
                new PicContent
                {
                    PicContentID = 1,
                    Picture = ImageToByteConversion("./images/climbing.jpg")

                },
                new PicContent
                {
                    PicContentID = 2,
                    Picture = ImageToByteConversion("./images/ramen.jpg")

                }); 
        }
    }
}
