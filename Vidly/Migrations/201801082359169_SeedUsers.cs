namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7e494ee8-b3c5-4066-bd7e-c8930cd60828', N'guest@vidly.com', 0, N'ALS4s0FxXvmFNlE0ttiALB65TdMVhOA7GM2OKHeFgd4WzgYQpSR+jz82hKHGBDX0QA==', N'44183c13-27bd-41e4-b729-fea52ce23b61', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9f48988e-c2d5-48a9-a3ce-788ebcfe53fb', N'admin@vidly.com', 0, N'AEsqGm4ODk3WbzQp4Zcb2K18ICp91YWpL+Tge1OLTwiEtr2XmAoH+lI3q/gBhrHXHw==', N'8b10a286-a2e0-454a-b164-64282b85e609', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'612e4e26-a948-4d67-8991-0fac48beee2c', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9f48988e-c2d5-48a9-a3ce-788ebcfe53fb', N'612e4e26-a948-4d67-8991-0fac48beee2c')");
        }
        
        public override void Down()
        {
        }
    }
}
