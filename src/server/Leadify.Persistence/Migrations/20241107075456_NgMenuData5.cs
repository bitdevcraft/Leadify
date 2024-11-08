using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NgMenuData5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC7583MP9HW1C8ZA6X8D");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75BS2EPGXZKQRE4B28");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75FZRXHQAZKJVW25B6");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75H9801T45E72CV7F8");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75HG3ASBVXZD75EFMW");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75J2PE5JZJXBNAPZ99");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75YH8E3AQC7XF3EY5J");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75YRXDCMVSQFXDCF72");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC763AASCGVQCH4TTKHF");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC7662WT0M12FJXHJ6V7");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC766PCK9PK0X4F4F5HA");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76FPB2KSH5Y69Y9QNB");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76G1S1J0H51380WFE5");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76GK4G30S3WN9WXE6M");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76KSE1E44N1DXPT0MG");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76M0EWD5V3N3WFCX4T");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76M22RNAN6K7QAXT4V");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76T0CJG14S1SJ9SWG3");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76TH3C4VDWM29D6QD3");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC2NZC76ZJG9615AZ89FBQMF");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC2NZC778PENNCQE7ZJ06KFV");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC2NZC77JQ2D5NKZJ3SA5FXC");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC2NZC77T9HSFVM7H59XA3D6");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC752KGJ2FXNZNYNPXRX");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC753TZGDVPGVPX5J0QJ");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75SHXC4K9XK3PFT0ZX");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC75Y0ZD7NZ2VQAVFWJR");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC2NZC759NAK9KSKERT7TH7V");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "NgMenus",
                columns: new[] { "Id", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[] { "01JC2NZC759NAK9KSKERT7TH7V", 1, "pi pi-fw pi-wallet", "Sales", null, "/", null });

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC2NZC763AASCGVQCH4TTKHF", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JC2NZC7662WT0M12FJXHJ6V7", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JC2NZC766PCK9PK0X4F4F5HA", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JC2NZC76FPB2KSH5Y69Y9QNB", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JC2NZC76G1S1J0H51380WFE5", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JC2NZC76GK4G30S3WN9WXE6M", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JC2NZC76KSE1E44N1DXPT0MG", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JC2NZC76M0EWD5V3N3WFCX4T", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JC2NZC76M22RNAN6K7QAXT4V", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JC2NZC76T0CJG14S1SJ9SWG3", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JC2NZC76TH3C4VDWM29D6QD3", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JC2NZC76ZJG9615AZ89FBQMF", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC2NZC778PENNCQE7ZJ06KFV", null, "Administrator", "ADMINISTRATOR" },
                    { "01JC2NZC77JQ2D5NKZJ3SA5FXC", null, "User", "USER" },
                    { "01JC2NZC77T9HSFVM7H59XA3D6", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "01JC2NZC752KGJ2FXNZNYNPXRX", 3, "pi pi-fw pi-bookmark", "Opportunities", "01JC2NZC759NAK9KSKERT7TH7V", "/", null },
                    { "01JC2NZC753TZGDVPGVPX5J0QJ", 0, "pi pi-fw pi-id-card", "Leads", "01JC2NZC759NAK9KSKERT7TH7V", "/", null },
                    { "01JC2NZC75SHXC4K9XK3PFT0ZX", 2, "pi pi-fw pi-building", "Accounts", "01JC2NZC759NAK9KSKERT7TH7V", "/", null },
                    { "01JC2NZC75Y0ZD7NZ2VQAVFWJR", 1, "pi pi-fw pi-address-book", "Contacts", "01JC2NZC759NAK9KSKERT7TH7V", "/", null },
                    { "01JC2NZC7583MP9HW1C8ZA6X8D", 0, "pi pi-fw pi-plus", "New Opportunity", "01JC2NZC752KGJ2FXNZNYNPXRX", "/", null },
                    { "01JC2NZC75BS2EPGXZKQRE4B28", 1, "pi pi-fw pi-list", "List View", "01JC2NZC752KGJ2FXNZNYNPXRX", "/", null },
                    { "01JC2NZC75FZRXHQAZKJVW25B6", 1, "pi pi-fw pi-list", "List View", "01JC2NZC75SHXC4K9XK3PFT0ZX", "/", null },
                    { "01JC2NZC75H9801T45E72CV7F8", 1, "pi pi-fw pi-list", "List View", "01JC2NZC753TZGDVPGVPX5J0QJ", "/", null },
                    { "01JC2NZC75HG3ASBVXZD75EFMW", 1, "pi pi-fw pi-list", "List View", "01JC2NZC75Y0ZD7NZ2VQAVFWJR", "/", null },
                    { "01JC2NZC75J2PE5JZJXBNAPZ99", 0, "pi pi-fw pi-plus", "New Account", "01JC2NZC75SHXC4K9XK3PFT0ZX", "/", null },
                    { "01JC2NZC75YH8E3AQC7XF3EY5J", 0, "pi pi-fw pi-plus", "New Contact", "01JC2NZC75Y0ZD7NZ2VQAVFWJR", "/", null },
                    { "01JC2NZC75YRXDCMVSQFXDCF72", 0, "pi pi-fw pi-plus", "New Lead", "01JC2NZC753TZGDVPGVPX5J0QJ", "/", null }
                });
        }
    }
}
