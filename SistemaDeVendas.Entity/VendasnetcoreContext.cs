using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SistemaDeVendas.Entity;

public partial class VendasnetcoreContext : DbContext
{
    public VendasnetcoreContext()
    {
    }

    public VendasnetcoreContext(DbContextOptions<VendasnetcoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<Configuracao> Configuracaos { get; set; }

    public virtual DbSet<DetalheVenda> DetalheVenda { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Negocio> Negocios { get; set; }

    public virtual DbSet<NumeroCorrelativo> NumeroCorrelativos { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<RolMenu> RolMenus { get; set; }

    public virtual DbSet<TipoDocumentoVenda> TipoDocumentoVenda { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Venda> Venda { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-RL96SQL;DataBase=VENDASNETCORE;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__8A3D240CAAC87CE8");

            entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IsActivo).HasColumnName("isActivo");
        });

        modelBuilder.Entity<Configuracao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Configuracao");

            entity.Property(e => e.Propriedade)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("propriedade");
            entity.Property(e => e.Recurso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("recurso");
            entity.Property(e => e.Valor)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<DetalheVenda>(entity =>
        {
            entity.HasKey(e => e.IdDetalheVenda).HasName("PK__DetalheV__61EFE30E7D378910");

            entity.Property(e => e.IdDetalheVenda).HasColumnName("idDetalheVenda");
            entity.Property(e => e.CategoriaProduto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("categoriaProduto");
            entity.Property(e => e.DescricaoProduto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricaoProduto");
            entity.Property(e => e.IdProduto).HasColumnName("idProduto");
            entity.Property(e => e.IdVenda).HasColumnName("idVenda");
            entity.Property(e => e.MarcaProduto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("marcaProduto");
            entity.Property(e => e.Preco)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("preco");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.IdVendaNavigation).WithMany(p => p.DetalheVenda)
                .HasForeignKey(d => d.IdVenda)
                .HasConstraintName("FK__DetalheVe__idVen__571DF1D5");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.IdMenu).HasName("PK__Menu__C26AF4839A436DCF");

            entity.ToTable("Menu");

            entity.Property(e => e.IdMenu).HasColumnName("idMenu");
            entity.Property(e => e.Controlador)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("controlador");
            entity.Property(e => e.Descricao)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Icone)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("icone");
            entity.Property(e => e.IdMenuPai).HasColumnName("idMenuPai");
            entity.Property(e => e.IsActivo).HasColumnName("isActivo");
            entity.Property(e => e.PaginaAcao)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("paginaAcao");

            entity.HasOne(d => d.IdMenuPaiNavigation).WithMany(p => p.InverseIdMenuPaiNavigation)
                .HasForeignKey(d => d.IdMenuPai)
                .HasConstraintName("FK__Menu__idMenuPai__37A5467C");
        });

        modelBuilder.Entity<Negocio>(entity =>
        {
            entity.HasKey(e => e.IdNegocio).HasName("PK__Negocio__70E1E1073E72EE9E");

            entity.ToTable("Negocio");

            entity.Property(e => e.IdNegocio)
                .ValueGeneratedNever()
                .HasColumnName("idNegocio");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("endereco");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.NomeLogo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nomeLogo");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numeroDocumento");
            entity.Property(e => e.PorcentagemImposto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("porcentagemImposto");
            entity.Property(e => e.SimboloMoeda)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("simboloMoeda");
            entity.Property(e => e.Telefone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefone");
            entity.Property(e => e.UrlLogo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("urlLogo");
        });

        modelBuilder.Entity<NumeroCorrelativo>(entity =>
        {
            entity.HasKey(e => e.IdNumeroCorrelativo).HasName("PK__NumeroCo__25FB547EA07B494C");

            entity.ToTable("NumeroCorrelativo");

            entity.Property(e => e.IdNumeroCorrelativo).HasColumnName("idNumeroCorrelativo");
            entity.Property(e => e.FechaActualizacion)
                .HasColumnType("datetime")
                .HasColumnName("fechaActualizacion");
            entity.Property(e => e.Gerenciamento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("gerenciamento");
            entity.Property(e => e.QuantidadeDigitos).HasColumnName("quantidadeDigitos");
            entity.Property(e => e.UltimoNumero).HasColumnName("ultimoNumero");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.IdProduto).HasName("PK__Produto__5EEDF7C3B5CBF44A");

            entity.ToTable("Produto");

            entity.Property(e => e.IdProduto).HasColumnName("idProduto");
            entity.Property(e => e.CodigoBarra)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codigoBarra");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");
            entity.Property(e => e.IsActivo).HasColumnName("isActivo");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.NomeImagen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nomeImagen");
            entity.Property(e => e.Preco)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("preco");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.UrlImagen)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("urlImagen");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__Produto__idCateg__49C3F6B7");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__Rol__3C872F76FC90137A");

            entity.ToTable("Rol");

            entity.Property(e => e.IdRol).HasColumnName("idRol");
            entity.Property(e => e.Descricao)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IsActivo).HasColumnName("isActivo");
        });

        modelBuilder.Entity<RolMenu>(entity =>
        {
            entity.HasKey(e => e.IdRolMenu).HasName("PK__RolMenu__CD2045D89B26A980");

            entity.ToTable("RolMenu");

            entity.Property(e => e.IdRolMenu).HasColumnName("idRolMenu");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdMenu).HasColumnName("idMenu");
            entity.Property(e => e.IdRol).HasColumnName("idRol");
            entity.Property(e => e.IsActivo).HasColumnName("isActivo");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.RolMenus)
                .HasForeignKey(d => d.IdMenu)
                .HasConstraintName("FK__RolMenu__idMenu__3F466844");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.RolMenus)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__RolMenu__idRol__3E52440B");
        });

        modelBuilder.Entity<TipoDocumentoVenda>(entity =>
        {
            entity.HasKey(e => e.IdTipoDocumentoVenda).HasName("PK__TipoDocu__A9D414E23BE69A9F");

            entity.Property(e => e.IdTipoDocumentoVenda).HasColumnName("idTipoDocumentoVenda");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IsActivo).HasColumnName("isActivo");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__645723A6B00CC4A5");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.Dica)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dica");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdRol).HasColumnName("idRol");
            entity.Property(e => e.IsActivo).HasColumnName("isActivo");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.NomeFoto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nomeFoto");
            entity.Property(e => e.Telefone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefone");
            entity.Property(e => e.UrlFoto)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("urlFoto");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__Usuario__idRol__4316F928");
        });

        modelBuilder.Entity<Venda>(entity =>
        {
            entity.HasKey(e => e.IdVenda).HasName("PK__Venda__077BEC28C03838E8");

            entity.Property(e => e.IdVenda).HasColumnName("idVenda");
            entity.Property(e => e.DocumentoCliente)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("documentoCliente");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdTipoDocumentoVenda).HasColumnName("idTipoDocumentoVenda");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.ImpuestoTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("impuestoTotal");
            entity.Property(e => e.NomeCliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nomeCliente");
            entity.Property(e => e.NumeroVenda)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("numeroVenda");
            entity.Property(e => e.SubTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subTotal");
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdTipoDocumentoVendaNavigation).WithMany(p => p.Venda)
                .HasForeignKey(d => d.IdTipoDocumentoVenda)
                .HasConstraintName("FK__Venda__idTipoDoc__52593CB8");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Venda)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Venda__idUsuario__534D60F1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
