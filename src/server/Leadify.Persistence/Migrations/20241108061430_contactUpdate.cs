using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class contactUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Contacts",
                type: "TEXT",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Contacts",
                type: "TEXT",
                maxLength: 50,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreatedOnUtc", "Email", "FirstName", "LastName", "Mobile", "ModifiedOnUtc", "Name", "Phone" },
                values: new object[,]
                {
                    { "01JC56HW9P45980GM105FPD1JN", new DateTime(2024, 11, 8, 6, 14, 29, 942, DateTimeKind.Utc).AddTicks(1324), "charlie.davis@example.com", null, null, "+789012345", null, "Charlie Davis", "+321654987" },
                    { "01JC56HW9P75TWVTBJVAE39M3K", new DateTime(2024, 11, 8, 6, 14, 29, 942, DateTimeKind.Utc).AddTicks(1319), "alice.brown@example.com", null, null, "+1029384756", null, "Alice Brown", "+5647382910" },
                    { "01JC56HW9P8G05BF26VEQCG9QY", new DateTime(2024, 11, 8, 6, 14, 29, 942, DateTimeKind.Utc).AddTicks(1312), "john.doe@example.com", null, null, "+123456789", null, "John Doe", "+987654321" },
                    { "01JC56HW9P9A69XCC1M2YNTS2R", new DateTime(2024, 11, 8, 6, 14, 29, 942, DateTimeKind.Utc).AddTicks(1322), "bob.johnson@example.com", null, null, "+567890123", null, "Bob Johnson", "+210987654" },
                    { "01JC56HW9PKTD788EC5DYET43Q", new DateTime(2024, 11, 8, 6, 14, 29, 942, DateTimeKind.Utc).AddTicks(1316), "jane.smith@example.com", null, null, "+987654321", null, "Jane Smith", "+123456789" }
                });

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[] { "01JC56HW9TG69EH5NE70XNB0Z9", 1, "pi pi-fw pi-wallet", "Sales", null, null, null });

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC56HW9V0FEJTDCZ1C9SD7YB", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JC56HW9V2265405Q0A96JAXV", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JC56HW9VF8ZKQVDD3CDPPJSN", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JC56HW9VFJGZ6H792DSDY6SF", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JC56HW9VHMSBEGBA48SPWHND", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JC56HW9VJQ2D5G32W8EAK8EF", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JC56HW9VQN6Z8E8JDFSWC475", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JC56HW9VRTSAWW7C71P33JKA", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JC56HW9VTSKH020W4DXMC9GD", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JC56HW9VXP99Z27Z0GDJE3YR", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JC56HW9VXPC1N51QJJWJTMZG", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JC56HW9VZHD6WWAHKXB24MH6", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC56HW9W2P1S3737M9K3MJ6R", null, "Administrator", "ADMINISTRATOR" },
                    { "01JC56HW9WGRM36N1QYVYQGSD2", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" },
                    { "01JC56HW9WZC0CA3FW455JFKQ9", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "01JC56HW9T3489FCEGZCHS9J1P", 0, "pi pi-fw pi-id-card", "Leads", "01JC56HW9TG69EH5NE70XNB0Z9", null, null },
                    { "01JC56HW9T34R0FMN659VAMMV8", 3, "pi pi-fw pi-bookmark", "Opportunities", "01JC56HW9TG69EH5NE70XNB0Z9", null, null },
                    { "01JC56HW9T5AZ7Z100SMKJWJG7", 1, "pi pi-fw pi-address-book", "Contacts", "01JC56HW9TG69EH5NE70XNB0Z9", null, null },
                    { "01JC56HW9TM8D0FFT63DBVWNX4", 2, "pi pi-fw pi-building", "Accounts", "01JC56HW9TG69EH5NE70XNB0Z9", null, null },
                    { "01JC56HW9V23JJD169A96CH1RX", 1, "pi pi-fw pi-list", "List View", "01JC56HW9T34R0FMN659VAMMV8", "/r/Opportunities/list-view", null },
                    { "01JC56HW9V2CZWHN216SWGPJNR", 0, "pi pi-fw pi-plus", "New Opportunity", "01JC56HW9T34R0FMN659VAMMV8", "/r/Opportunities/new", null },
                    { "01JC56HW9VDAGY05XTH0GRWM5Y", 1, "pi pi-fw pi-list", "List View", "01JC56HW9TM8D0FFT63DBVWNX4", "/r/Accounts/list-view", null },
                    { "01JC56HW9VDRVJWFRHD9FG3GSE", 1, "pi pi-fw pi-list", "List View", "01JC56HW9T3489FCEGZCHS9J1P", "/r/Leads/list-view", null },
                    { "01JC56HW9VDWVEZX8G2SP01HMJ", 0, "pi pi-fw pi-plus", "New Lead", "01JC56HW9T3489FCEGZCHS9J1P", "/r/Leads/new", null },
                    { "01JC56HW9VFBQN6XHC2DZ207FX", 0, "pi pi-fw pi-plus", "New Contact", "01JC56HW9T5AZ7Z100SMKJWJG7", "/r/Contacts/new", null },
                    { "01JC56HW9VFKA8KXCNMZTWK359", 1, "pi pi-fw pi-list", "List View", "01JC56HW9T5AZ7Z100SMKJWJG7", "/r/Contacts/list-view", null },
                    { "01JC56HW9VJ637D0ZKPBP4CZ40", 0, "pi pi-fw pi-plus", "New Account", "01JC56HW9TM8D0FFT63DBVWNX4", "/r/Accounts/new", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JC56HW9P45980GM105FPD1JN");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JC56HW9P75TWVTBJVAE39M3K");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JC56HW9P8G05BF26VEQCG9QY");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JC56HW9P9A69XCC1M2YNTS2R");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JC56HW9PKTD788EC5DYET43Q");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC56HW9V23JJD169A96CH1RX");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC56HW9V2CZWHN216SWGPJNR");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC56HW9VDAGY05XTH0GRWM5Y");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC56HW9VDRVJWFRHD9FG3GSE");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC56HW9VDWVEZX8G2SP01HMJ");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC56HW9VFBQN6XHC2DZ207FX");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC56HW9VFKA8KXCNMZTWK359");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC56HW9VJ637D0ZKPBP4CZ40");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC56HW9V0FEJTDCZ1C9SD7YB");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC56HW9V2265405Q0A96JAXV");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC56HW9VF8ZKQVDD3CDPPJSN");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC56HW9VFJGZ6H792DSDY6SF");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC56HW9VHMSBEGBA48SPWHND");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC56HW9VJQ2D5G32W8EAK8EF");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC56HW9VQN6Z8E8JDFSWC475");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC56HW9VRTSAWW7C71P33JKA");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC56HW9VTSKH020W4DXMC9GD");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC56HW9VXP99Z27Z0GDJE3YR");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC56HW9VXPC1N51QJJWJTMZG");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC56HW9VZHD6WWAHKXB24MH6");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC56HW9W2P1S3737M9K3MJ6R");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC56HW9WGRM36N1QYVYQGSD2");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC56HW9WZC0CA3FW455JFKQ9");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC56HW9T3489FCEGZCHS9J1P");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC56HW9T34R0FMN659VAMMV8");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC56HW9T5AZ7Z100SMKJWJG7");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC56HW9TM8D0FFT63DBVWNX4");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC56HW9TG69EH5NE70XNB0Z9");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Contacts");

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
    }
}
