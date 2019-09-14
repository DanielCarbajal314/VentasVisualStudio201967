namespace Ventas.Infraestructura.ContextoDeDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsuarioCorreo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuario", "Correo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuario", "Correo");
        }
    }
}
