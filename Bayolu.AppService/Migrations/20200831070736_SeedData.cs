using Bayolu.SharedKernel;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bayolu.AppService.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = new StringBuilder(@"INSERT INTO [Bayolu].[User]([Id],[FullName],[Email],[Password],[Role],[Team],[StorageCapacity],[OriginalFolder],[Comment]) VALUES ");
            var ids = new List<Guid>();
            for (int i = 0; i < 10; i++)
            {
                ids.Add(Guid.NewGuid());
            }
            var userid = 0;
            ids.ForEach(item =>
            {
                sql.Append($"('{item}','User_{userid}','User_{userid}@gmail.com','{Cryptography.EncryptString("abc")}'" +
                    $",1,1,100,'C://Junk','this is sample project'),");
                userid++;
            });
            migrationBuilder.Sql(sql.ToString().Substring(0, sql.ToString().Length - 1));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
