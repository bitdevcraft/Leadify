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
                Label = "Sales",
                Icon = "pi pi-fw pi-wallet",
                ParentId = null,
                Hierarchy = 1
            },
        };

        builder.HasData(menus);


        var sales = new List<NgMenu>
        {
            new NgMenu
            {
                Label = "Leads",
                Icon = "pi pi-fw pi-id-card",
                ParentId = menus[0].Id,
                Hierarchy = 0
            },
            new NgMenu
            {
                Label = "Contacts",
                Icon = "pi pi-fw pi-address-book",
                ParentId = menus[0].Id,
                Hierarchy = 1
            },
            new NgMenu
            {
                Label = "Accounts",
                Icon = "pi pi-fw pi-building",
                ParentId = menus[0].Id,
                Hierarchy = 2
            },
            new NgMenu
            {
                Label = "Opportunities",
                Icon = "pi pi-fw pi-bookmark",
                ParentId = menus[0].Id,
                Hierarchy = 3
            },
        };

        builder.HasData(sales);


        var leadMenu = new List<NgMenu>
        {
            new NgMenu
            {
                Label = "New Lead",
                Icon = "pi pi-fw pi-plus",
                RouterLinkArray = "/r/Leads/new",
                ParentId = sales[0].Id,
                Hierarchy = 0
            },
            new NgMenu
            {
                Label = "List View",
                Icon = "pi pi-fw pi-list",
                RouterLinkArray = "/r/Leads/list-view",
                ParentId = sales[0].Id,
                Hierarchy = 1
            },
        };

        builder.HasData(leadMenu);


        var contactMenu = new List<NgMenu>
        {
            new NgMenu
            {
                Label = "New Contact",
                Icon = "pi pi-fw pi-plus",
                RouterLinkArray = "/r/Contacts/new",
                ParentId = sales[1].Id,
                Hierarchy = 0
            },
            new NgMenu
            {
                Label = "List View",
                Icon = "pi pi-fw pi-list",
                RouterLinkArray = "/r/Contacts/list-view",
                ParentId = sales[1].Id,
                Hierarchy = 1
            },
        };

        builder.HasData(contactMenu);


        var accountMenu = new List<NgMenu>
        {
            new NgMenu
            {
                Label = "New Account",
                Icon = "pi pi-fw pi-plus",
                RouterLinkArray = "/r/Accounts/new",
                ParentId = sales[2].Id,
                Hierarchy = 0
            },
            new NgMenu
            {
                Label = "List View",
                Icon = "pi pi-fw pi-list",
                RouterLinkArray = "/r/Accounts/list-view",
                ParentId = sales[2].Id,
                Hierarchy = 1
            },
        };

        builder.HasData(accountMenu);


        var oppMenu = new List<NgMenu>
        {
            new NgMenu
            {
                Label = "New Opportunity",
                Icon = "pi pi-fw pi-plus",
                RouterLinkArray = "/r/Opportunities/new",
                ParentId = sales[3].Id,
                Hierarchy = 0
            },
            new NgMenu
            {
                Label = "List View",
                Icon = "pi pi-fw pi-list",
                RouterLinkArray = "/r/Opportunities/list-view",
                ParentId = sales[3].Id,
                Hierarchy = 1
            },
        };

        builder.HasData(oppMenu);
    }
}