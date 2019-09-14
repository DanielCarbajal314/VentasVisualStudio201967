namespace Ventas.Infraestructura.ContextoDeDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Primeraversion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Precio = c.Double(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categoria", t => t.CategoriaId, cascadeDelete: true)
                .Index(t => t.CategoriaId);
            
            CreateTable(
                "dbo.DetalleVenta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        SubTotal = c.Double(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        VentaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Producto", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Venta", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.ProductoId)
                .Index(t => t.VentaId);
            
            CreateTable(
                "dbo.Venta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoDeVenta = c.Int(nullable: false),
                        Total = c.Double(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        VendedorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Vendedor", t => t.VendedorId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.VendedorId);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Sexo = c.Int(nullable: false),
                        NombreCompleto = c.String(),
                        DNI = c.String(),
                        Direccion = c.String(),
                        UBIGEO = c.String(),
                        Correo = c.String(),
                        Celular = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vendedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PorcentajeDeComision = c.Double(nullable: false),
                        NombreCompleto = c.String(),
                        DNI = c.String(),
                        Direccion = c.String(),
                        UBIGEO = c.String(),
                        Correo = c.String(),
                        Celular = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreCompleto = c.String(),
                        Alias = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UsuarioRol",
                c => new
                    {
                        Usuario_Id = c.Int(nullable: false),
                        Rol_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Usuario_Id, t.Rol_Id })
                .ForeignKey("dbo.Usuario", t => t.Usuario_Id, cascadeDelete: true)
                .ForeignKey("dbo.Rol", t => t.Rol_Id, cascadeDelete: true)
                .Index(t => t.Usuario_Id)
                .Index(t => t.Rol_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsuarioRol", "Rol_Id", "dbo.Rol");
            DropForeignKey("dbo.UsuarioRol", "Usuario_Id", "dbo.Usuario");
            DropForeignKey("dbo.Venta", "VendedorId", "dbo.Vendedor");
            DropForeignKey("dbo.DetalleVenta", "VentaId", "dbo.Venta");
            DropForeignKey("dbo.Venta", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.DetalleVenta", "ProductoId", "dbo.Producto");
            DropForeignKey("dbo.Producto", "CategoriaId", "dbo.Categoria");
            DropIndex("dbo.UsuarioRol", new[] { "Rol_Id" });
            DropIndex("dbo.UsuarioRol", new[] { "Usuario_Id" });
            DropIndex("dbo.Venta", new[] { "VendedorId" });
            DropIndex("dbo.Venta", new[] { "ClienteId" });
            DropIndex("dbo.DetalleVenta", new[] { "VentaId" });
            DropIndex("dbo.DetalleVenta", new[] { "ProductoId" });
            DropIndex("dbo.Producto", new[] { "CategoriaId" });
            DropTable("dbo.UsuarioRol");
            DropTable("dbo.Usuario");
            DropTable("dbo.Rol");
            DropTable("dbo.Vendedor");
            DropTable("dbo.Cliente");
            DropTable("dbo.Venta");
            DropTable("dbo.DetalleVenta");
            DropTable("dbo.Producto");
            DropTable("dbo.Categoria");
        }
    }
}
