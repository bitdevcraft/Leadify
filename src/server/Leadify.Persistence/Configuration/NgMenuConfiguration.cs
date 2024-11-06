using Leadify.Domain.ClientAppLayout;
using Leadify.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Leadify.Persistence.Configuration;

public class NgMenuConfiguration : IEntityTypeConfiguration<NgMenu>
{
    public void Configure(EntityTypeBuilder<NgMenu> builder)
    {
        builder.ToTable(TableNames.NgMenus);
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Parent)
            .WithMany(x => x.Items)
            .HasForeignKey(x => x.ParentId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Restrict);


        var menus = new List<NgMenu>
        {
            new NgMenu
            {
                Label = "Dashboard",
                Icon = "pi pi-fw pi-home",
                RouterLinkArray = "/",
                ParentId = null,
            },
            new NgMenu
            {
                Label = "Sales",
                Icon = "pi pi-fw pi-wallet",
                RouterLinkArray = "/",
                ParentId = null,
            },
        };

        builder.HasData(menus);


        var sales = new List<NgMenu>
        {
            new NgMenu
            {
                Label = "Leads",
                Icon = "pi pi-fw pi-id-card",
                RouterLinkArray = "/",
                ParentId = menus[1].Id,
            },
            new NgMenu
            {
                Label = "Contacts",
                Icon = "pi pi-fw pi-address-book",
                RouterLinkArray = "/",
                ParentId = menus[1].Id,
            },
            new NgMenu
            {
                Label = "Accounts",
                Icon = "pi pi-fw pi-building",
                RouterLinkArray = "/",
                ParentId = menus[1].Id,
            },
            new NgMenu
            {
                Label = "Opportunities",
                Icon = "pi pi-fw pi-bookmark",
                RouterLinkArray = "/",
                ParentId = menus[1].Id,
            },
        };

        builder.HasData(sales);


        var leadMenu = new List<NgMenu>
        {
            new NgMenu
            {
                Label = "New Lead",
                Icon = "pi pi-fw pi-plus",
                RouterLinkArray = "/",
                ParentId = sales[0].Id,
            },
            new NgMenu
            {
                Label = "List View",
                Icon = "pi pi-fw pi-list",
                RouterLinkArray = "/",
                ParentId = sales[0].Id,
            },
        };

        builder.HasData(leadMenu);


        var contactMenu = new List<NgMenu>
        {
            new NgMenu
            {
                Label = "New Contact",
                Icon = "pi pi-fw pi-plus",
                RouterLinkArray = "/",
                ParentId = sales[1].Id,
            },
            new NgMenu
            {
                Label = "List View",
                Icon = "pi pi-fw pi-list",
                RouterLinkArray = "/",
                ParentId = sales[1].Id,
            },
        };

        builder.HasData(contactMenu);


        var accountMenu = new List<NgMenu>
        {
            new NgMenu
            {
                Label = "New Account",
                Icon = "pi pi-fw pi-plus",
                RouterLinkArray = "/",
                ParentId = sales[2].Id,
            },
            new NgMenu
            {
                Label = "List View",
                Icon = "pi pi-fw pi-list",
                RouterLinkArray = "/",
                ParentId = sales[2].Id,
            },
        };

        builder.HasData(accountMenu);


        var oppMenu = new List<NgMenu>
        {
            new NgMenu
            {
                Label = "New Opportunity",
                Icon = "pi pi-fw pi-plus",
                RouterLinkArray = "/",
                ParentId = sales[3].Id,
            },
            new NgMenu
            {
                Label = "List View",
                Icon = "pi pi-fw pi-list",
                RouterLinkArray = "/",
                ParentId = sales[3].Id,
            },
        };

        builder.HasData(oppMenu);
    }
}