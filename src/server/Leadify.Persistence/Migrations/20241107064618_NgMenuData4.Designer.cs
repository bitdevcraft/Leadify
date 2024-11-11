﻿// <auto-generated />
using System;
using Leadify.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Leadify.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241107064618_NgMenuData4")]
    partial class NgMenuData4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Leadify.Domain.Auditable.Audit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Operation")
                        .HasColumnType("TEXT");

                    b.Property<string>("RecordId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TableName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SysAudits", (string)null);
                });

            modelBuilder.Entity("Leadify.Domain.Auditable.AuditEntry", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AuditId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FieldName")
                        .HasColumnType("TEXT");

                    b.Property<string>("NewValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("OldValue")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuditId");

                    b.ToTable("SysAuditEntries", (string)null);
                });

            modelBuilder.Entity("Leadify.Domain.ClientAppLayout.NgFormLayout", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjectType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Placeholder")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ReadOnly")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Required")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SmallText")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("NgFormLayouts", (string)null);
                });

            modelBuilder.Entity("Leadify.Domain.ClientAppLayout.NgMenu", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Hierarchy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT");

                    b.Property<string>("Label")
                        .HasColumnType("TEXT");

                    b.Property<string>("ParentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RouterLinkArray")
                        .HasColumnType("TEXT");

                    b.Property<string>("UrlArray")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("NgMenus", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "01JC2NZC759NAK9KSKERT7TH7V",
                            Hierarchy = 1,
                            Icon = "pi pi-fw pi-wallet",
                            Label = "Sales",
                            RouterLinkArray = "/"
                        },
                        new
                        {
                            Id = "01JC2NZC753TZGDVPGVPX5J0QJ",
                            Hierarchy = 0,
                            Icon = "pi pi-fw pi-id-card",
                            Label = "Leads",
                            ParentId = "01JC2NZC759NAK9KSKERT7TH7V",
                            RouterLinkArray = "/"
                        },
                        new
                        {
                            Id = "01JC2NZC75Y0ZD7NZ2VQAVFWJR",
                            Hierarchy = 1,
                            Icon = "pi pi-fw pi-address-book",
                            Label = "Contacts",
                            ParentId = "01JC2NZC759NAK9KSKERT7TH7V",
                            RouterLinkArray = "/"
                        },
                        new
                        {
                            Id = "01JC2NZC75SHXC4K9XK3PFT0ZX",
                            Hierarchy = 2,
                            Icon = "pi pi-fw pi-building",
                            Label = "Accounts",
                            ParentId = "01JC2NZC759NAK9KSKERT7TH7V",
                            RouterLinkArray = "/"
                        },
                        new
                        {
                            Id = "01JC2NZC752KGJ2FXNZNYNPXRX",
                            Hierarchy = 3,
                            Icon = "pi pi-fw pi-bookmark",
                            Label = "Opportunities",
                            ParentId = "01JC2NZC759NAK9KSKERT7TH7V",
                            RouterLinkArray = "/"
                        },
                        new
                        {
                            Id = "01JC2NZC75YRXDCMVSQFXDCF72",
                            Hierarchy = 0,
                            Icon = "pi pi-fw pi-plus",
                            Label = "New Lead",
                            ParentId = "01JC2NZC753TZGDVPGVPX5J0QJ",
                            RouterLinkArray = "/"
                        },
                        new
                        {
                            Id = "01JC2NZC75H9801T45E72CV7F8",
                            Hierarchy = 1,
                            Icon = "pi pi-fw pi-list",
                            Label = "List View",
                            ParentId = "01JC2NZC753TZGDVPGVPX5J0QJ",
                            RouterLinkArray = "/"
                        },
                        new
                        {
                            Id = "01JC2NZC75YH8E3AQC7XF3EY5J",
                            Hierarchy = 0,
                            Icon = "pi pi-fw pi-plus",
                            Label = "New Contact",
                            ParentId = "01JC2NZC75Y0ZD7NZ2VQAVFWJR",
                            RouterLinkArray = "/"
                        },
                        new
                        {
                            Id = "01JC2NZC75HG3ASBVXZD75EFMW",
                            Hierarchy = 1,
                            Icon = "pi pi-fw pi-list",
                            Label = "List View",
                            ParentId = "01JC2NZC75Y0ZD7NZ2VQAVFWJR",
                            RouterLinkArray = "/"
                        },
                        new
                        {
                            Id = "01JC2NZC75J2PE5JZJXBNAPZ99",
                            Hierarchy = 0,
                            Icon = "pi pi-fw pi-plus",
                            Label = "New Account",
                            ParentId = "01JC2NZC75SHXC4K9XK3PFT0ZX",
                            RouterLinkArray = "/"
                        },
                        new
                        {
                            Id = "01JC2NZC75FZRXHQAZKJVW25B6",
                            Hierarchy = 1,
                            Icon = "pi pi-fw pi-list",
                            Label = "List View",
                            ParentId = "01JC2NZC75SHXC4K9XK3PFT0ZX",
                            RouterLinkArray = "/"
                        },
                        new
                        {
                            Id = "01JC2NZC7583MP9HW1C8ZA6X8D",
                            Hierarchy = 0,
                            Icon = "pi pi-fw pi-plus",
                            Label = "New Opportunity",
                            ParentId = "01JC2NZC752KGJ2FXNZNYNPXRX",
                            RouterLinkArray = "/"
                        },
                        new
                        {
                            Id = "01JC2NZC75BS2EPGXZKQRE4B28",
                            Hierarchy = 1,
                            Icon = "pi pi-fw pi-list",
                            Label = "List View",
                            ParentId = "01JC2NZC752KGJ2FXNZNYNPXRX",
                            RouterLinkArray = "/"
                        });
                });

            modelBuilder.Entity("Leadify.Domain.Entities.Contact", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Mobile")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedOnUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contacts", (string)null);
                });

            modelBuilder.Entity("Leadify.Domain.Users.Permission", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("PermissionNameIndex");

                    b.ToTable("SysPermissions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "01JC2NZC7662WT0M12FJXHJ6V7",
                            Name = "Permissions.Contacts.Create",
                            NormalizedName = "PERMISSIONS.CONTACTS.CREATE"
                        },
                        new
                        {
                            Id = "01JC2NZC76M22RNAN6K7QAXT4V",
                            Name = "Permissions.Contacts.View",
                            NormalizedName = "PERMISSIONS.CONTACTS.VIEW"
                        },
                        new
                        {
                            Id = "01JC2NZC76FPB2KSH5Y69Y9QNB",
                            Name = "Permissions.Contacts.Edit",
                            NormalizedName = "PERMISSIONS.CONTACTS.EDIT"
                        },
                        new
                        {
                            Id = "01JC2NZC76T0CJG14S1SJ9SWG3",
                            Name = "Permissions.Contacts.Delete",
                            NormalizedName = "PERMISSIONS.CONTACTS.DELETE"
                        },
                        new
                        {
                            Id = "01JC2NZC76M0EWD5V3N3WFCX4T",
                            Name = "Permissions.Users.Create",
                            NormalizedName = "PERMISSIONS.USERS.CREATE"
                        },
                        new
                        {
                            Id = "01JC2NZC76ZJG9615AZ89FBQMF",
                            Name = "Permissions.Users.View",
                            NormalizedName = "PERMISSIONS.USERS.VIEW"
                        },
                        new
                        {
                            Id = "01JC2NZC766PCK9PK0X4F4F5HA",
                            Name = "Permissions.Users.Edit",
                            NormalizedName = "PERMISSIONS.USERS.EDIT"
                        },
                        new
                        {
                            Id = "01JC2NZC76TH3C4VDWM29D6QD3",
                            Name = "Permissions.Users.Delete",
                            NormalizedName = "PERMISSIONS.USERS.DELETE"
                        },
                        new
                        {
                            Id = "01JC2NZC76GK4G30S3WN9WXE6M",
                            Name = "Permissions.Roles.Create",
                            NormalizedName = "PERMISSIONS.ROLES.CREATE"
                        },
                        new
                        {
                            Id = "01JC2NZC76G1S1J0H51380WFE5",
                            Name = "Permissions.Roles.View",
                            NormalizedName = "PERMISSIONS.ROLES.VIEW"
                        },
                        new
                        {
                            Id = "01JC2NZC76KSE1E44N1DXPT0MG",
                            Name = "Permissions.Roles.Edit",
                            NormalizedName = "PERMISSIONS.ROLES.EDIT"
                        },
                        new
                        {
                            Id = "01JC2NZC763AASCGVQCH4TTKHF",
                            Name = "Permissions.Roles.Delete",
                            NormalizedName = "PERMISSIONS.ROLES.DELETE"
                        });
                });

            modelBuilder.Entity("Leadify.Domain.Users.RefreshToken", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SysRefreshTokens", (string)null);
                });

            modelBuilder.Entity("Leadify.Domain.Users.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("SysRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "01JC2NZC77T9HSFVM7H59XA3D6",
                            Name = "SystemAdministrator",
                            NormalizedName = "SYSTEMADMINISTRATOR"
                        },
                        new
                        {
                            Id = "01JC2NZC778PENNCQE7ZJ06KFV",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "01JC2NZC77JQ2D5NKZJ3SA5FXC",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Leadify.Domain.Users.RolePermission", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.Property<string>("PermissionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("SysRolePermissions", (string)null);
                });

            modelBuilder.Entity("Leadify.Domain.Users.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

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
                        .HasColumnType("TEXT");

                    b.Property<string>("ActivityData")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("ActivityType")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceInfo")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("IpAddress")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SysUserActivities", (string)null);
                });

            modelBuilder.Entity("Leadify.Domain.Users.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("SysUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Ulid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Ulid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Ulid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Ulid>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

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
                    b.Navigation("RefreshTokens");

                    b.Navigation("UserActivities");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}