using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leadify.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NewMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreatedOnUtc", "Email", "FirstName", "LastName", "Mobile", "ModifiedOnUtc", "Name", "Phone" },
                values: new object[,]
                {
                    { "01JC5DCDQF0BNFEQQFJ3QFHWFC", new DateTime(2024, 11, 8, 8, 13, 51, 215, DateTimeKind.Utc).AddTicks(9154), "jane.smith@example.com", null, null, "+987654321", null, "Jane Smith", "+123456789" },
                    { "01JC5DCDQF1YHDVRYDXGAVEKGA", new DateTime(2024, 11, 8, 8, 13, 51, 215, DateTimeKind.Utc).AddTicks(9220), "charlie.davis@example.com", null, null, "+789012345", null, "Charlie Davis", "+321654987" },
                    { "01JC5DCDQF8BYYSAHRZ8YQZEKT", new DateTime(2024, 11, 8, 8, 13, 51, 215, DateTimeKind.Utc).AddTicks(9149), "john.doe@example.com", null, null, "+123456789", null, "John Doe", "+987654321" },
                    { "01JC5DCDQF8TR8ZHX7C076WJMZ", new DateTime(2024, 11, 8, 8, 13, 51, 215, DateTimeKind.Utc).AddTicks(9160), "bob.johnson@example.com", null, null, "+567890123", null, "Bob Johnson", "+210987654" },
                    { "01JC5DCDQFCP2QXKV7T1KZHP5Q", new DateTime(2024, 11, 8, 8, 13, 51, 215, DateTimeKind.Utc).AddTicks(9157), "alice.brown@example.com", null, null, "+1029384756", null, "Alice Brown", "+5647382910" }
                });

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "01JC5DCDQMBC9R81HKCZ26B3NC", 0, "pi pi-fw pi-wallet", "Sales", null, null, null },
                    { "01JC5DCDQMMRE02BWGF5VK2RGF", 1, "pi pi-fw pi-cog", "Setup", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SysPermissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC5DCDQN5SC0KK173ZD4018V", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JC5DCDQN6551GSFEF5G8MHRX", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JC5DCDQN985SVK5R4HB2D8W9", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JC5DCDQNA55J09W0GJS88J37", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JC5DCDQNBKPQV2A1QHTVYFAP", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JC5DCDQNCM4VHKYMK1KTV4NF", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JC5DCDQNCSTRBFG7X8EXXT9B", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JC5DCDQNCXBSAXAJF0NXHBFQ", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JC5DCDQNDJ3Q97DE0QP6PJ6G", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JC5DCDQNDPM24XZ13QFXA83D", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JC5DCDQNETQ3RBB203ZRZZV9", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JC5DCDQNZFZ3N11CGG5Q9Z3P", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" }
                });

            migrationBuilder.InsertData(
                table: "SysRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JC5DCDQP2Y2D1GM4NPGGAK4J", null, "User", "USER" },
                    { "01JC5DCDQPD4V6GJTKYNH9A1GK", null, "Administrator", "ADMINISTRATOR" },
                    { "01JC5DCDQPFC8EVZW1NJ3Q7XBB", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "NgMenus",
                columns: new[] { "Id", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "01JC5DCDQM52H76R1VHVHQTX0T", 0, "pi pi-fw pi-users", "Administrations", "01JC5DCDQMMRE02BWGF5VK2RGF", null, null },
                    { "01JC5DCDQMASPFBCWMH7E0ZA5C", 0, "pi pi-fw pi-id-card", "Leads", "01JC5DCDQMBC9R81HKCZ26B3NC", null, null },
                    { "01JC5DCDQMBYE8DXDWE4Q9Y20D", 1, "pi pi-fw pi-wrench", "Settings", "01JC5DCDQMMRE02BWGF5VK2RGF", null, null },
                    { "01JC5DCDQMGC3A1Y60DZCVKQCW", 2, "pi pi-fw pi-building", "Accounts", "01JC5DCDQMBC9R81HKCZ26B3NC", null, null },
                    { "01JC5DCDQMT6QZ56G7DSQ0CG4H", 1, "pi pi-fw pi-address-book", "Contacts", "01JC5DCDQMBC9R81HKCZ26B3NC", null, null },
                    { "01JC5DCDQMYHVF5B32N61SWDEE", 3, "pi pi-fw pi-bookmark", "Opportunities", "01JC5DCDQMBC9R81HKCZ26B3NC", null, null },
                    { "01JC5DCDQM15TZ2HVDFW0DJH1E", 0, "pi pi-fw", "Menu Settings", "01JC5DCDQMBYE8DXDWE4Q9Y20D", "/setup/settings/menu", null },
                    { "01JC5DCDQM6Z2SGP48FYFP4QNN", 1, "pi pi-fw pi-list", "List View", "01JC5DCDQMT6QZ56G7DSQ0CG4H", "/r/Contacts/list-view", null },
                    { "01JC5DCDQM920XN22B855PBENT", 1, "pi pi-fw pi-list", "List View", "01JC5DCDQMYHVF5B32N61SWDEE", "/r/Opportunities/list-view", null },
                    { "01JC5DCDQMC58534XBSC0X4T5K", 1, "pi pi-fw pi-list", "List View", "01JC5DCDQMGC3A1Y60DZCVKQCW", "/r/Accounts/list-view", null },
                    { "01JC5DCDQMJB3DA0QH0R1ZCYHB", 0, "pi pi-fw pi-plus", "New Account", "01JC5DCDQMGC3A1Y60DZCVKQCW", "/r/Accounts/new", null },
                    { "01JC5DCDQMK37HKV38BYZDX3WW", 0, "pi pi-fw pi-plus", "New Lead", "01JC5DCDQMASPFBCWMH7E0ZA5C", "/r/Leads/new", null },
                    { "01JC5DCDQMKQAS09GDHKRGKMG8", 0, "pi pi-fw", "Permissions", "01JC5DCDQM52H76R1VHVHQTX0T", "/setup/administrations/permission", null },
                    { "01JC5DCDQMMWGXX5RNBXCMH8MJ", 1, "pi pi-fw ", "Roles", "01JC5DCDQM52H76R1VHVHQTX0T", "/setup/administrations/role", null },
                    { "01JC5DCDQMPZ8V5MZPK1TJGG5S", 0, "pi pi-fw pi-plus", "New Contact", "01JC5DCDQMT6QZ56G7DSQ0CG4H", "/r/Contacts/new", null },
                    { "01JC5DCDQMSG5FM6250W8M2T46", 0, "pi pi-fw pi-plus", "New Opportunity", "01JC5DCDQMYHVF5B32N61SWDEE", "/r/Opportunities/new", null },
                    { "01JC5DCDQMWABN26857PRNYB1G", 2, "pi pi-fw ", "Users", "01JC5DCDQM52H76R1VHVHQTX0T", "/setup/administrations/user", null },
                    { "01JC5DCDQMX5QJ9D9QETP17ETX", 1, "pi pi-fw pi-list", "List View", "01JC5DCDQMASPFBCWMH7E0ZA5C", "/r/Leads/list-view", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JC5DCDQF0BNFEQQFJ3QFHWFC");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JC5DCDQF1YHDVRYDXGAVEKGA");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JC5DCDQF8BYYSAHRZ8YQZEKT");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JC5DCDQF8TR8ZHX7C076WJMZ");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JC5DCDQFCP2QXKV7T1KZHP5Q");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQM15TZ2HVDFW0DJH1E");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQM6Z2SGP48FYFP4QNN");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQM920XN22B855PBENT");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMC58534XBSC0X4T5K");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMJB3DA0QH0R1ZCYHB");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMK37HKV38BYZDX3WW");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMKQAS09GDHKRGKMG8");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMMWGXX5RNBXCMH8MJ");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMPZ8V5MZPK1TJGG5S");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMSG5FM6250W8M2T46");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMWABN26857PRNYB1G");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMX5QJ9D9QETP17ETX");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC5DCDQN5SC0KK173ZD4018V");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC5DCDQN6551GSFEF5G8MHRX");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC5DCDQN985SVK5R4HB2D8W9");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC5DCDQNA55J09W0GJS88J37");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC5DCDQNBKPQV2A1QHTVYFAP");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC5DCDQNCM4VHKYMK1KTV4NF");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC5DCDQNCSTRBFG7X8EXXT9B");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC5DCDQNCXBSAXAJF0NXHBFQ");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC5DCDQNDJ3Q97DE0QP6PJ6G");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC5DCDQNDPM24XZ13QFXA83D");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC5DCDQNETQ3RBB203ZRZZV9");

            migrationBuilder.DeleteData(
                table: "SysPermissions",
                keyColumn: "Id",
                keyValue: "01JC5DCDQNZFZ3N11CGG5Q9Z3P");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC5DCDQP2Y2D1GM4NPGGAK4J");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC5DCDQPD4V6GJTKYNH9A1GK");

            migrationBuilder.DeleteData(
                table: "SysRoles",
                keyColumn: "Id",
                keyValue: "01JC5DCDQPFC8EVZW1NJ3Q7XBB");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQM52H76R1VHVHQTX0T");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMASPFBCWMH7E0ZA5C");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMBYE8DXDWE4Q9Y20D");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMGC3A1Y60DZCVKQCW");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMT6QZ56G7DSQ0CG4H");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMYHVF5B32N61SWDEE");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMBC9R81HKCZ26B3NC");

            migrationBuilder.DeleteData(
                table: "NgMenus",
                keyColumn: "Id",
                keyValue: "01JC5DCDQMMRE02BWGF5VK2RGF");

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
    }
}
