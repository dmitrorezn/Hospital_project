namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hahaha : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "DName", c => c.String());
            AddColumn("dbo.Doctors", "DSurname", c => c.String());
            DropColumn("dbo.Doctors", "Name");
            DropColumn("dbo.Doctors", "Surname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "Surname", c => c.String());
            AddColumn("dbo.Doctors", "Name", c => c.String());
            DropColumn("dbo.Doctors", "DSurname");
            DropColumn("dbo.Doctors", "DName");
        }
    }
}
