namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'132d9882-08f9-4133-a8a5-dfe3b76673a7', N'admin@vidly.com', 0, N'AOdbSzq/myQN4H5ad33yn4puvPJXlnGwN10ZOAITDWdQymO6DoIRX63I3PZJ+Y6L1g==', N'f42cc741-5373-41c7-8d76-ce734f252347', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f0ea54b1-c566-43d5-a670-8881e6aa264e', N'guest@vidly.com', 0, N'AL8LM3b+lVJMpf6TWLpsqvQoU7REVrQDWIHYSQxlavLQCvXLgzTXcZjamzLH1USkxA==', N'f50bad1b-83dc-44c1-884a-c439992b03df', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'604de015-0727-482f-99b1-21e5ad6a7058', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1fba80a2-97ef-4ef7-a4b1-ed32ef2c8e29', N'604de015-0727-482f-99b1-21e5ad6a7058')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
