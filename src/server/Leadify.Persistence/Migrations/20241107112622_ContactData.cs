using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ContactData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2SX2B91KZF06RS9BH1A3H4");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2SX2B92KD7SWGCHBWR0DG6");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2SX2B9CQR89D1FSFTDRE3R");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2SX2B9FY62CZC1BQZ7T2AP");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2SX2B9G6MVA61WNMWYZWN9");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2SX2B9KBVCEQRDHVW4P2X1");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2SX2B9RHDHG95YERNGPM0F");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2SX2B9T5RSTZBFQ31THZ0X");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2SX2BA37PTJTF2GE3F9WBT");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2SX2BA6V7HR5PW88HND9S9");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2SX2BA8GBHXK05BN5KVV28");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2SX2BA9HZ61VAFZDRGEXBT");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2SX2BAEZB83BWQ1J51AM07");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2SX2BAJ1SWT1ZYMTFZKC62");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2SX2BAJ4FZMZ42MQ0NN2CS");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2SX2BAQMFNTKG5WCAPYH6T");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2SX2BASHDD5VP7P9TXZJGK");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2SX2BASR0KTVBZBS47F89B");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2SX2BAXPRMW8K7YPT2F7QZ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2SX2BAZWSDKHW0JKJKPEA8");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC2SX2BBF2GZDS501QR46CA8");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC2SX2BBQ5VARTDVCJNMDHRC");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC2SX2BBZ9FJQCJMESQR0CPR");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2SX2B9Y1RV9GK98B3KZXF0");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2SX2B9YXE690ANDS0EEHE4");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2SX2B9Z3E2H3GK16E895W9");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2SX2B9ZNWVXGHSE6R162C4");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2SX2B9DQ99Y7RPZJA6J8CX");

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreatedOnUtc", "Email", "Mobile", "ModifiedOnUtc", "Name", "Phone" },
                values: new object[,]
                {
                    { "01JC3606PF9B8Z184HM4X779TM", new DateTime(2024, 11, 7, 11, 26, 21, 903, DateTimeKind.Utc).AddTicks(3500), "charlie.davis@example.com", "+789012345", null, "Charlie Davis", "+321654987" },
                    { "01JC3606PFCAFQBPJ1XB26W61P", new DateTime(2024, 11, 7, 11, 26, 21, 903, DateTimeKind.Utc).AddTicks(3485), "john.doe@example.com", "+123456789", null, "John Doe", "+987654321" },
                    { "01JC3606PFFT4YAN65SNT09XW9", new DateTime(2024, 11, 7, 11, 26, 21, 903, DateTimeKind.Utc).AddTicks(3494), "alice.brown@example.com", "+1029384756", null, "Alice Brown", "+5647382910" },
                    { "01JC3606PFGPV7ZFE9S4Z1YBH3", new DateTime(2024, 11, 7, 11, 26, 21, 903, DateTimeKind.Utc).AddTicks(3491), "jane.smith@example.com", "+987654321", null, "Jane Smith", "+123456789" },
                    { "01JC3606PFYT8W6WHX2MZPAS2M", new DateTime(2024, 11, 7, 11, 26, 21, 903, DateTimeKind.Utc).AddTicks(3497), "bob.johnson@example.com", "+567890123", null, "Bob Johnson", "+210987654" }
                });

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[] { "01JC3606PK3HWAE4KTQX23KTC9", 1, "pi pi-fw pi-wallet", "Sales", null, null, null });

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC3606PM09PB9X2EMR4YMEJ7", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JC3606PM0HFANSZZMBTH2NBR", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JC3606PM8AWWXZMM2X1ZSBQH", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JC3606PM8BA3H86X4WDC3DSD", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JC3606PM9FDB9ES2VW4KP49T", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JC3606PMDG673QYJ61EGWFDV", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JC3606PMDHHRDPR0GEH1MQ2Q", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JC3606PMPET4BWA78N03D8H8", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JC3606PMWCT42WM57FTFR8YB", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JC3606PMWRXC5WZ83P8VYVZ0", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JC3606PMX36B8TWGVC9BZ592", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JC3606PMXX3VECB49B49AQZW", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC3606PN1AQDZXKSKCFTXTVF", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" },
                    { "01JC3606PN2DC3PKZYYKD2KZX2", null, "Administrator", "ADMINISTRATOR" },
                    { "01JC3606PNA8ZDKNG90B3GX4JZ", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "01JC3606PK8D1V5VPH4XABXJWK", 2, "pi pi-fw pi-building", "Accounts", "01JC3606PK3HWAE4KTQX23KTC9", null, null },
                    { "01JC3606PKGXW1MQ3N7STAFDYR", 0, "pi pi-fw pi-id-card", "Leads", "01JC3606PK3HWAE4KTQX23KTC9", null, null },
                    { "01JC3606PKP8Y011J9RESY9YGH", 1, "pi pi-fw pi-address-book", "Contacts", "01JC3606PK3HWAE4KTQX23KTC9", null, null },
                    { "01JC3606PKX4JC2YCNY6VPHM31", 3, "pi pi-fw pi-bookmark", "Opportunities", "01JC3606PK3HWAE4KTQX23KTC9", null, null },
                    { "01JC3606PK0746A1GYXHMB3RQZ", 0, "pi pi-fw pi-plus", "New Account", "01JC3606PK8D1V5VPH4XABXJWK", "/r/Accounts/new", null },
                    { "01JC3606PK7ENE1YBDA102DWJG", 1, "pi pi-fw pi-list", "List View", "01JC3606PKGXW1MQ3N7STAFDYR", "/r/Leads/list-view", null },
                    { "01JC3606PKCH0HTCM3M81G8SYK", 0, "pi pi-fw pi-plus", "New Contact", "01JC3606PKP8Y011J9RESY9YGH", "/r/Contacts/new", null },
                    { "01JC3606PKFYX3V78W9Y0NWEAG", 1, "pi pi-fw pi-list", "List View", "01JC3606PK8D1V5VPH4XABXJWK", "/r/Accounts/list-view", null },
                    { "01JC3606PKGERVQA9CJMXEGTRA", 1, "pi pi-fw pi-list", "List View", "01JC3606PKP8Y011J9RESY9YGH", "/r/Contacts/list-view", null },
                    { "01JC3606PKHM6PH4PHS8PRNV2S", 0, "pi pi-fw pi-plus", "New Lead", "01JC3606PKGXW1MQ3N7STAFDYR", "/r/Leads/new", null },
                    { "01JC3606PKPKTE7TABKE70QCS0", 1, "pi pi-fw pi-list", "List View", "01JC3606PKX4JC2YCNY6VPHM31", "/r/Opportunities/list-view", null },
                    { "01JC3606PKQJN4CHR25EG8S40M", 0, "pi pi-fw pi-plus", "New Opportunity", "01JC3606PKX4JC2YCNY6VPHM31", "/r/Opportunities/new", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JC3606PF9B8Z184HM4X779TM");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JC3606PFCAFQBPJ1XB26W61P");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JC3606PFFT4YAN65SNT09XW9");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JC3606PFGPV7ZFE9S4Z1YBH3");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JC3606PFYT8W6WHX2MZPAS2M");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC3606PK0746A1GYXHMB3RQZ");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC3606PK7ENE1YBDA102DWJG");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC3606PKCH0HTCM3M81G8SYK");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC3606PKFYX3V78W9Y0NWEAG");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC3606PKGERVQA9CJMXEGTRA");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC3606PKHM6PH4PHS8PRNV2S");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC3606PKPKTE7TABKE70QCS0");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC3606PKQJN4CHR25EG8S40M");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC3606PM09PB9X2EMR4YMEJ7");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC3606PM0HFANSZZMBTH2NBR");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC3606PM8AWWXZMM2X1ZSBQH");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC3606PM8BA3H86X4WDC3DSD");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC3606PM9FDB9ES2VW4KP49T");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC3606PMDG673QYJ61EGWFDV");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC3606PMDHHRDPR0GEH1MQ2Q");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC3606PMPET4BWA78N03D8H8");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC3606PMWCT42WM57FTFR8YB");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC3606PMWRXC5WZ83P8VYVZ0");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC3606PMX36B8TWGVC9BZ592");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC3606PMXX3VECB49B49AQZW");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC3606PN1AQDZXKSKCFTXTVF");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC3606PN2DC3PKZYYKD2KZX2");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC3606PNA8ZDKNG90B3GX4JZ");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC3606PK8D1V5VPH4XABXJWK");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC3606PKGXW1MQ3N7STAFDYR");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC3606PKP8Y011J9RESY9YGH");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC3606PKX4JC2YCNY6VPHM31");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC3606PK3HWAE4KTQX23KTC9");

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[] { "01JC2SX2B9DQ99Y7RPZJA6J8CX", 1, "pi pi-fw pi-wallet", "Sales", null, null, null });

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC2SX2BA37PTJTF2GE3F9WBT", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JC2SX2BA6V7HR5PW88HND9S9", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JC2SX2BA8GBHXK05BN5KVV28", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JC2SX2BA9HZ61VAFZDRGEXBT", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JC2SX2BAEZB83BWQ1J51AM07", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JC2SX2BAJ1SWT1ZYMTFZKC62", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JC2SX2BAJ4FZMZ42MQ0NN2CS", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JC2SX2BAQMFNTKG5WCAPYH6T", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JC2SX2BASHDD5VP7P9TXZJGK", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JC2SX2BASR0KTVBZBS47F89B", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JC2SX2BAXPRMW8K7YPT2F7QZ", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JC2SX2BAZWSDKHW0JKJKPEA8", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC2SX2BBF2GZDS501QR46CA8", null, "Administrator", "ADMINISTRATOR" },
                    { "01JC2SX2BBQ5VARTDVCJNMDHRC", null, "User", "USER" },
                    { "01JC2SX2BBZ9FJQCJMESQR0CPR", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "01JC2SX2B9Y1RV9GK98B3KZXF0", 2, "pi pi-fw pi-building", "Accounts", "01JC2SX2B9DQ99Y7RPZJA6J8CX", null, null },
                    { "01JC2SX2B9YXE690ANDS0EEHE4", 0, "pi pi-fw pi-id-card", "Leads", "01JC2SX2B9DQ99Y7RPZJA6J8CX", null, null },
                    { "01JC2SX2B9Z3E2H3GK16E895W9", 3, "pi pi-fw pi-bookmark", "Opportunities", "01JC2SX2B9DQ99Y7RPZJA6J8CX", null, null },
                    { "01JC2SX2B9ZNWVXGHSE6R162C4", 1, "pi pi-fw pi-address-book", "Contacts", "01JC2SX2B9DQ99Y7RPZJA6J8CX", null, null },
                    { "01JC2SX2B91KZF06RS9BH1A3H4", 0, "pi pi-fw pi-plus", "New Account", "01JC2SX2B9Y1RV9GK98B3KZXF0", "/r/Accounts/new", null },
                    { "01JC2SX2B92KD7SWGCHBWR0DG6", 0, "pi pi-fw pi-plus", "New Opportunity", "01JC2SX2B9Z3E2H3GK16E895W9", "/r/Opportunities/new", null },
                    { "01JC2SX2B9CQR89D1FSFTDRE3R", 0, "pi pi-fw pi-plus", "New Lead", "01JC2SX2B9YXE690ANDS0EEHE4", "/r/Leads/new", null },
                    { "01JC2SX2B9FY62CZC1BQZ7T2AP", 1, "pi pi-fw pi-list", "List View", "01JC2SX2B9YXE690ANDS0EEHE4", "/r/Leads/list-view", null },
                    { "01JC2SX2B9G6MVA61WNMWYZWN9", 1, "pi pi-fw pi-list", "List View", "01JC2SX2B9Y1RV9GK98B3KZXF0", "/r/Accounts/list-view", null },
                    { "01JC2SX2B9KBVCEQRDHVW4P2X1", 1, "pi pi-fw pi-list", "List View", "01JC2SX2B9Z3E2H3GK16E895W9", "/r/Opportunities/list-view", null },
                    { "01JC2SX2B9RHDHG95YERNGPM0F", 1, "pi pi-fw pi-list", "List View", "01JC2SX2B9ZNWVXGHSE6R162C4", "/r/Contacts/list-view", null },
                    { "01JC2SX2B9T5RSTZBFQ31THZ0X", 0, "pi pi-fw pi-plus", "New Contact", "01JC2SX2B9ZNWVXGHSE6R162C4", "/r/Contacts/new", null }
                });
        }
    }
}
