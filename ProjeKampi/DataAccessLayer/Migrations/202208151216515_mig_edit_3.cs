namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_edit_3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterSatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterSatus");
        }
    }
}
