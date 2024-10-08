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
    [Migration("20240823113633_AddNewSeedPermission")]
    partial class AddNewSeedPermission
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

            modelBuilder.Entity("Leadify.Domain.Entities.Contact", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mobile")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedOnUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
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
                            Id = "01J5ZGC7N1H4WQEA4XSGHM231H",
                            Name = "Permissions.Contacts.Create",
                            NormalizedName = "PERMISSIONS.CONTACTS.CREATE"
                        },
                        new
                        {
                            Id = "01J5ZGC7N1FRBTNJ81N9AQNMGC",
                            Name = "Permissions.Contacts.View",
                            NormalizedName = "PERMISSIONS.CONTACTS.VIEW"
                        },
                        new
                        {
                            Id = "01J5ZGC7N14HQ9MFTY3H2B8JWB",
                            Name = "Permissions.Contacts.Edit",
                            NormalizedName = "PERMISSIONS.CONTACTS.EDIT"
                        },
                        new
                        {
                            Id = "01J5ZGC7N1CD954PVC7Z2PNQVD",
                            Name = "Permissions.Contacts.Delete",
                            NormalizedName = "PERMISSIONS.CONTACTS.DELETE"
                        },
                        new
                        {
                            Id = "01J5ZGC7N1ND92GMFZM32MHZMQ",
                            Name = "Permissions.Users.Create",
                            NormalizedName = "PERMISSIONS.USERS.CREATE"
                        },
                        new
                        {
                            Id = "01J5ZGC7N1S9Q4ZK4BQJ4J3GGZ",
                            Name = "Permissions.Users.View",
                            NormalizedName = "PERMISSIONS.USERS.VIEW"
                        },
                        new
                        {
                            Id = "01J5ZGC7N179EXNQSJBH1TPFX8",
                            Name = "Permissions.Users.Edit",
                            NormalizedName = "PERMISSIONS.USERS.EDIT"
                        },
                        new
                        {
                            Id = "01J5ZGC7N18EE1V9EQ6KTARYBF",
                            Name = "Permissions.Users.Delete",
                            NormalizedName = "PERMISSIONS.USERS.DELETE"
                        },
                        new
                        {
                            Id = "01J5ZGC7N112MHX4Q0YQ8E1QHG",
                            Name = "Permissions.Roles.Create",
                            NormalizedName = "PERMISSIONS.ROLES.CREATE"
                        },
                        new
                        {
                            Id = "01J5ZGC7N1T14G09GDCT93YRCZ",
                            Name = "Permissions.Roles.View",
                            NormalizedName = "PERMISSIONS.ROLES.VIEW"
                        },
                        new
                        {
                            Id = "01J5ZGC7N12DMY6V898RR5406V",
                            Name = "Permissions.Roles.Edit",
                            NormalizedName = "PERMISSIONS.ROLES.EDIT"
                        },
                        new
                        {
                            Id = "01J5ZGC7N1NQ1TEAMX1N8K01YS",
                            Name = "Permissions.Roles.Delete",
                            NormalizedName = "PERMISSIONS.ROLES.DELETE"
                        });
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
                            Id = "01J5ZGC7N23FYJ6YZSKDS3D603",
                            Name = "SystemAdministrator",
                            NormalizedName = "SYSTEMADMINISTRATOR"
                        },
                        new
                        {
                            Id = "01J5ZGC7N2TS44F2GJW46N779X",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "01J5ZGC7N22E1DC6JHS4F73G2N",
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
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
