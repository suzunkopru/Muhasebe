﻿using Microsoft.EntityFrameworkCore;
using Muhasebe.BankaHesaplar;
using Muhasebe.Bankalar;
using Muhasebe.BankaSubeler;
using Muhasebe.Birimler;
using Muhasebe.Cariler;
using Muhasebe.Depolar;
using Muhasebe.Donemler;
using Muhasebe.Faturalar;
using Muhasebe.Hizmetler;
using Muhasebe.Kasalar;
using Muhasebe.Makbuzlar;
using Muhasebe.Masraflar;
using Muhasebe.OzelKodlar;
using Muhasebe.Parametreler;
using Muhasebe.Stoklar;
using Muhasebe.Subeler;
using System.Data;
using static Muhasebe.Consts.EntityConsts;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using AbcYazilim.OnMuhasebe.Cofigurations;

namespace Muhasebe.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class MuhasebeDbContext :
    AbpDbContext<MuhasebeDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    #region Kartları Ekliyoruz
    public DbSet<Banka> Bankalar { get; set; }
    public DbSet<BankaSube> BankaSubeler { get; set; }
    public DbSet<BankaHesap> BankaHesaplar { get; set; }
    public DbSet<Birim> Birimler { get; set; }
    public DbSet<Cari> Cariler { get; set; }
    public DbSet<Depo> Depolar { get; set; }
    public DbSet<Donem> Donemler { get; set; }
    public DbSet<FirmaParametre> FirmaParametreler { get; set; }
    public DbSet<Fatura> Faturalar { get; set; }
    public DbSet<Hizmet> Hizmetler { get; set; }
    public DbSet<Kasa> Kasalar { get; set; }
    public DbSet<Makbuz> Makbuzlar { get; set; }
    public DbSet<Masraf> Masraflar { get; set; }
    public DbSet<OzelKod> OzelKodlar { get; set; }
    public DbSet<Stok> Stoklar { get; set; }
    public DbSet<Sube> Subeler { get; set; }
    #endregion Kartları Ekliyoruz
    public MuhasebeDbContext(DbContextOptions<MuhasebeDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        #region Builder Extend işlemi ile
        builder.ConfigureStoredProcedure();
        builder.ConfigureBanka();
        builder.ConfigureBankaSube();
        builder.ConfigureBankaHesap();
        builder.ConfigureBirim();
        builder.ConfigureCari();
        builder.ConfigureDepo();
        builder.ConfigureDonem();
        builder.ConfigureFatura();
        builder.ConfigureFaturaHareket();
        builder.ConfigureFirmaParametre();
        builder.ConfigureHizmet();
        builder.ConfigureKasa();
        builder.ConfigureMakbuz();
        builder.ConfigureMakbuzHareket();
        builder.ConfigureMasraf();
        builder.ConfigureOzelKod();
        builder.ConfigureStok();
        builder.ConfigureSube();
        #endregion Builder Extend işlemi ile
    }
}
