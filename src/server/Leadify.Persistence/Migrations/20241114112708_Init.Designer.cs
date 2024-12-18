﻿// <auto-generated />
using System;
using Leadify.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Leadify.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241114112708_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Leadify.Domain.Auditable.Audit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Operation")
                        .HasColumnType("text");

                    b.Property<string>("RecordId")
                        .IsRequired()
                        .HasColumnType("character varying(26)");

                    b.Property<string>("TableName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SysAudits", (string)null);
                });

            modelBuilder.Entity("Leadify.Domain.Auditable.AuditEntry", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character varying(26)");

                    b.Property<int>("AuditId")
                        .HasColumnType("integer");

                    b.Property<string>("FieldName")
                        .HasColumnType("text");

                    b.Property<string>("NewValue")
                        .HasColumnType("text");

                    b.Property<string>("OldValue")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AuditId");

                    b.ToTable("SysAuditEntries", (string)null);
                });

            modelBuilder.Entity("Leadify.Domain.ClientAppLayout.NgFormLayout", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character varying(26)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("ObjectType")
                        .HasColumnType("text");

                    b.Property<string>("Placeholder")
                        .HasColumnType("text");

                    b.Property<bool>("ReadOnly")
                        .HasColumnType("boolean");

                    b.Property<bool>("Required")
                        .HasColumnType("boolean");

                    b.Property<string>("SmallText")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("NgFormLayouts", (string)null);
                });

            modelBuilder.Entity("Leadify.Domain.ClientAppLayout.NgMenu", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character varying(26)");

                    b.Property<bool>("CanDelete")
                        .HasColumnType("boolean");

                    b.Property<int>("Hierarchy")
                        .HasColumnType("integer");

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<string>("Label")
                        .HasColumnType("text");

                    b.Property<string>("ParentId")
                        .HasColumnType("character varying(26)");

                    b.Property<string>("RouterLinkArray")
                        .HasColumnType("text");

                    b.Property<string>("UrlArray")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("NgMenus", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "01JCN6TMCNA7H38EPS5AFE6B4N",
                            CanDelete = true,
                            Hierarchy = 0,
                            Icon = "pi pi-fw pi-wallet",
                            Label = "Sales"
                        },
                        new
                        {
                            Id = "01JCN6TMCN4G12R8RYQSD04JXD",
                            CanDelete = false,
                            Hierarchy = 1,
                            Icon = "pi pi-fw pi-cog",
                            Label = "Setup"
                        },
                        new
                        {
                            Id = "01JCN6TMCNYRSD4VN2BPNBDQ3F",
                            CanDelete = true,
                            Hierarchy = 0,
                            Icon = "pi pi-fw pi-id-card",
                            Label = "Leads",
                            ParentId = "01JCN6TMCNA7H38EPS5AFE6B4N"
                        },
                        new
                        {
                            Id = "01JCN6TMCNA56J6QV69SFK2SK2",
                            CanDelete = true,
                            Hierarchy = 1,
                            Icon = "pi pi-fw pi-address-book",
                            Label = "Contacts",
                            ParentId = "01JCN6TMCNA7H38EPS5AFE6B4N"
                        },
                        new
                        {
                            Id = "01JCN6TMCN8HN60A8ZM55DJEZT",
                            CanDelete = true,
                            Hierarchy = 2,
                            Icon = "pi pi-fw pi-building",
                            Label = "Accounts",
                            ParentId = "01JCN6TMCNA7H38EPS5AFE6B4N"
                        },
                        new
                        {
                            Id = "01JCN6TMCNNKEEJWR46WBV5X9N",
                            CanDelete = true,
                            Hierarchy = 3,
                            Icon = "pi pi-fw pi-bookmark",
                            Label = "Opportunities",
                            ParentId = "01JCN6TMCNA7H38EPS5AFE6B4N"
                        },
                        new
                        {
                            Id = "01JCN6TMCNN8CMSE8B6J5AKTBA",
                            CanDelete = true,
                            Hierarchy = 0,
                            Icon = "pi pi-fw pi-plus",
                            Label = "New Lead",
                            ParentId = "01JCN6TMCNYRSD4VN2BPNBDQ3F",
                            RouterLinkArray = "/r/Leads/new"
                        },
                        new
                        {
                            Id = "01JCN6TMCNRFT8K3VT2ENE8207",
                            CanDelete = true,
                            Hierarchy = 1,
                            Icon = "pi pi-fw pi-list",
                            Label = "List View",
                            ParentId = "01JCN6TMCNYRSD4VN2BPNBDQ3F",
                            RouterLinkArray = "/r/Leads/list-view"
                        },
                        new
                        {
                            Id = "01JCN6TMCNNHAYVRW553Y2ZCGY",
                            CanDelete = true,
                            Hierarchy = 0,
                            Icon = "pi pi-fw pi-plus",
                            Label = "New Contact",
                            ParentId = "01JCN6TMCNA56J6QV69SFK2SK2",
                            RouterLinkArray = "/r/Contacts/new"
                        },
                        new
                        {
                            Id = "01JCN6TMCNCWQTKXR9367C1HC4",
                            CanDelete = true,
                            Hierarchy = 1,
                            Icon = "pi pi-fw pi-list",
                            Label = "List View",
                            ParentId = "01JCN6TMCNA56J6QV69SFK2SK2",
                            RouterLinkArray = "/r/Contacts/list-view"
                        },
                        new
                        {
                            Id = "01JCN6TMCN73DDQBJGYQTVPYPD",
                            CanDelete = true,
                            Hierarchy = 0,
                            Icon = "pi pi-fw pi-plus",
                            Label = "New Account",
                            ParentId = "01JCN6TMCN8HN60A8ZM55DJEZT",
                            RouterLinkArray = "/r/Accounts/new"
                        },
                        new
                        {
                            Id = "01JCN6TMCNQ90386AE5X0DX2BZ",
                            CanDelete = true,
                            Hierarchy = 1,
                            Icon = "pi pi-fw pi-list",
                            Label = "List View",
                            ParentId = "01JCN6TMCN8HN60A8ZM55DJEZT",
                            RouterLinkArray = "/r/Accounts/list-view"
                        },
                        new
                        {
                            Id = "01JCN6TMCNEPH3KWV7VJASF3H6",
                            CanDelete = true,
                            Hierarchy = 0,
                            Icon = "pi pi-fw pi-plus",
                            Label = "New Opportunity",
                            ParentId = "01JCN6TMCNNKEEJWR46WBV5X9N",
                            RouterLinkArray = "/r/Opportunities/new"
                        },
                        new
                        {
                            Id = "01JCN6TMCNHTG7VEWAV1BC0SWV",
                            CanDelete = true,
                            Hierarchy = 1,
                            Icon = "pi pi-fw pi-list",
                            Label = "List View",
                            ParentId = "01JCN6TMCNNKEEJWR46WBV5X9N",
                            RouterLinkArray = "/r/Opportunities/list-view"
                        },
                        new
                        {
                            Id = "01JCN6TMCNFZQ9FSP8XEM6RXV1",
                            CanDelete = false,
                            Hierarchy = 0,
                            Icon = "pi pi-fw pi-users",
                            Label = "Administrations",
                            ParentId = "01JCN6TMCN4G12R8RYQSD04JXD"
                        },
                        new
                        {
                            Id = "01JCN6TMCNR5R4K4QVGZ6KHHMC",
                            CanDelete = false,
                            Hierarchy = 1,
                            Icon = "pi pi-fw pi-wrench",
                            Label = "Settings",
                            ParentId = "01JCN6TMCN4G12R8RYQSD04JXD"
                        },
                        new
                        {
                            Id = "01JCN6TMCNJAQT22H56P79JT1S",
                            CanDelete = false,
                            Hierarchy = 0,
                            Icon = "pi pi-fw",
                            Label = "Permissions",
                            ParentId = "01JCN6TMCNFZQ9FSP8XEM6RXV1",
                            RouterLinkArray = "/setup/administrations/permission"
                        },
                        new
                        {
                            Id = "01JCN6TMCN1J54N5XWP82S66HW",
                            CanDelete = false,
                            Hierarchy = 1,
                            Icon = "pi pi-fw ",
                            Label = "Roles",
                            ParentId = "01JCN6TMCNFZQ9FSP8XEM6RXV1",
                            RouterLinkArray = "/setup/administrations/role"
                        },
                        new
                        {
                            Id = "01JCN6TMCNTD4R7CM4D2EDKQCM",
                            CanDelete = false,
                            Hierarchy = 2,
                            Icon = "pi pi-fw ",
                            Label = "Users",
                            ParentId = "01JCN6TMCNFZQ9FSP8XEM6RXV1",
                            RouterLinkArray = "/setup/administrations/user"
                        },
                        new
                        {
                            Id = "01JCN6TMCNZAEWM8YBYG9VP9EW",
                            CanDelete = false,
                            Hierarchy = 0,
                            Icon = "pi pi-fw",
                            Label = "Menu Settings",
                            ParentId = "01JCN6TMCNR5R4K4QVGZ6KHHMC",
                            RouterLinkArray = "/setup/settings/menu"
                        });
                });

            modelBuilder.Entity("Leadify.Domain.Entities.Contact", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character varying(26)");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Mobile")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("ModifiedOnUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Contacts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "01JCN6TMCF61N8JJXX4HS8A4SF",
                            CreatedOnUtc = new DateTime(2024, 11, 14, 11, 27, 7, 663, DateTimeKind.Utc).AddTicks(5913),
                            Email = "john.doe@example.com",
                            Mobile = "+123456789",
                            Name = "John Doe",
                            Phone = "+987654321"
                        },
                        new
                        {
                            Id = "01JCN6TMCF9T1NRNJ8PQ7FZPZ7",
                            CreatedOnUtc = new DateTime(2024, 11, 14, 11, 27, 7, 663, DateTimeKind.Utc).AddTicks(5920),
                            Email = "jane.smith@example.com",
                            Mobile = "+987654321",
                            Name = "Jane Smith",
                            Phone = "+123456789"
                        },
                        new
                        {
                            Id = "01JCN6TMCFW34QRZKRPJB19A8T",
                            CreatedOnUtc = new DateTime(2024, 11, 14, 11, 27, 7, 663, DateTimeKind.Utc).AddTicks(5923),
                            Email = "alice.brown@example.com",
                            Mobile = "+1029384756",
                            Name = "Alice Brown",
                            Phone = "+5647382910"
                        },
                        new
                        {
                            Id = "01JCN6TMCFVHHSMN45GNNPW1AC",
                            CreatedOnUtc = new DateTime(2024, 11, 14, 11, 27, 7, 663, DateTimeKind.Utc).AddTicks(5926),
                            Email = "bob.johnson@example.com",
                            Mobile = "+567890123",
                            Name = "Bob Johnson",
                            Phone = "+210987654"
                        },
                        new
                        {
                            Id = "01JCN6TMCF2T7D8R316FPMM5G4",
                            CreatedOnUtc = new DateTime(2024, 11, 14, 11, 27, 7, 663, DateTimeKind.Utc).AddTicks(5929),
                            Email = "charlie.davis@example.com",
                            Mobile = "+789012345",
                            Name = "Charlie Davis",
                            Phone = "+321654987"
                        });
                });

            modelBuilder.Entity("Leadify.Domain.Users.Permission", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character varying(26)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("PermissionNameIndex");

                    b.ToTable("SysPermissions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "01JCN6TMCPN5NZDV5HDPCTMY41",
                            Name = "Permissions.Contacts.Create",
                            NormalizedName = "PERMISSIONS.CONTACTS.CREATE"
                        },
                        new
                        {
                            Id = "01JCN6TMCP7MT2GAFHN815QPD4",
                            Name = "Permissions.Contacts.View",
                            NormalizedName = "PERMISSIONS.CONTACTS.VIEW"
                        },
                        new
                        {
                            Id = "01JCN6TMCPYT7MS4EMKGWCT060",
                            Name = "Permissions.Contacts.Edit",
                            NormalizedName = "PERMISSIONS.CONTACTS.EDIT"
                        },
                        new
                        {
                            Id = "01JCN6TMCPAXWKXZR40BFDCNP3",
                            Name = "Permissions.Contacts.Delete",
                            NormalizedName = "PERMISSIONS.CONTACTS.DELETE"
                        },
                        new
                        {
                            Id = "01JCN6TMCPHSEM7C2WD3KMQV3C",
                            Name = "Permissions.Users.Create",
                            NormalizedName = "PERMISSIONS.USERS.CREATE"
                        },
                        new
                        {
                            Id = "01JCN6TMCPHE9J0R9G41TWX5KR",
                            Name = "Permissions.Users.View",
                            NormalizedName = "PERMISSIONS.USERS.VIEW"
                        },
                        new
                        {
                            Id = "01JCN6TMCPB3RQCBZ6V6XZ93E7",
                            Name = "Permissions.Users.Edit",
                            NormalizedName = "PERMISSIONS.USERS.EDIT"
                        },
                        new
                        {
                            Id = "01JCN6TMCPQKPEAEWBJ9N2S8XT",
                            Name = "Permissions.Users.Delete",
                            NormalizedName = "PERMISSIONS.USERS.DELETE"
                        },
                        new
                        {
                            Id = "01JCN6TMCP051A0V207TKD892B",
                            Name = "Permissions.Roles.Create",
                            NormalizedName = "PERMISSIONS.ROLES.CREATE"
                        },
                        new
                        {
                            Id = "01JCN6TMCPQR3X5SD5EETM85J8",
                            Name = "Permissions.Roles.View",
                            NormalizedName = "PERMISSIONS.ROLES.VIEW"
                        },
                        new
                        {
                            Id = "01JCN6TMCPAJKN4SY6SG96XCY9",
                            Name = "Permissions.Roles.Edit",
                            NormalizedName = "PERMISSIONS.ROLES.EDIT"
                        },
                        new
                        {
                            Id = "01JCN6TMCPPMT04CJTMAQDJD8P",
                            Name = "Permissions.Roles.Delete",
                            NormalizedName = "PERMISSIONS.ROLES.DELETE"
                        });
                });

            modelBuilder.Entity("Leadify.Domain.Users.RefreshToken", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character varying(26)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Token")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("character varying(26)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SysRefreshTokens", (string)null);
                });

            modelBuilder.Entity("Leadify.Domain.Users.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character varying(26)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("SysRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "01JCN6TMCRKE9F9ECMP8QYJQV3",
                            Name = "SystemAdministrator",
                            NormalizedName = "SYSTEMADMINISTRATOR"
                        },
                        new
                        {
                            Id = "01JCN6TMCRTMKV67MBKQ7T63DA",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "01JCN6TMCR212QD20CSC9F9TZ9",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Leadify.Domain.Users.RolePermission", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("character varying(26)");

                    b.Property<string>("PermissionId")
                        .HasColumnType("character varying(26)");

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasColumnType("character varying(26)");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("SysRolePermissions", (string)null);
                });

            modelBuilder.Entity("Leadify.Domain.Users.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character varying(26)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Fax")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ManagerId")
                        .HasColumnType("character varying(26)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<string>("Mobile")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Salutation")
                        .HasColumnType("text");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("Suffix")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("SysUsers", (string)null);
                });

            modelBuilder.Entity("Leadify.Domain.Users.UserActivity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character varying(26)");

                    b.Property<string>("ActivityData")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("ActivityType")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DeviceInfo")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("IpAddress")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("character varying(26)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SysUserActivities", (string)null);
                });

            modelBuilder.Entity("Leadify.Domain.Users.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("character varying(26)");

                    b.Property<string>("RoleId")
                        .HasColumnType("character varying(26)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("SysUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Ulid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("character varying(26)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Ulid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("character varying(26)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Ulid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("character varying(26)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Ulid>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("character varying(26)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Leadify.Domain.Auditable.AuditEntry", b =>
                {
                    b.HasOne("Leadify.Domain.Auditable.Audit", "Audit")
                        .WithMany("Changes")
                        .HasForeignKey("AuditId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Audit");
                });

            modelBuilder.Entity("Leadify.Domain.ClientAppLayout.NgMenu", b =>
                {
                    b.HasOne("Leadify.Domain.ClientAppLayout.NgMenu", "Parent")
                        .WithMany("Items")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Leadify.Domain.Users.RefreshToken", b =>
                {
                    b.HasOne("Leadify.Domain.Users.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Leadify.Domain.Users.RolePermission", b =>
                {
                    b.HasOne("Leadify.Domain.Users.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Leadify.Domain.Users.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Leadify.Domain.Users.User", b =>
                {
                    b.HasOne("Leadify.Domain.Users.User", "Manager")
                        .WithMany("Members")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Leadify.Domain.Users.UserActivity", b =>
                {
                    b.HasOne("Leadify.Domain.Users.User", "User")
                        .WithMany("UserActivities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Leadify.Domain.Users.UserRole", b =>
                {
                    b.HasOne("Leadify.Domain.Users.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Leadify.Domain.Users.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Ulid>", b =>
                {
                    b.HasOne("Leadify.Domain.Users.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Ulid>", b =>
                {
                    b.HasOne("Leadify.Domain.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Ulid>", b =>
                {
                    b.HasOne("Leadify.Domain.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Ulid>", b =>
                {
                    b.HasOne("Leadify.Domain.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Leadify.Domain.Auditable.Audit", b =>
                {
                    b.Navigation("Changes");
                });

            modelBuilder.Entity("Leadify.Domain.ClientAppLayout.NgMenu", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Leadify.Domain.Users.Permission", b =>
                {
                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("Leadify.Domain.Users.Role", b =>
                {
                    b.Navigation("RolePermissions");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Leadify.Domain.Users.User", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("RefreshTokens");

                    b.Navigation("UserActivities");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
