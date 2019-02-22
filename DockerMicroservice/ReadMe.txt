Install-Package Microsoft.EntityFrameworkCore.InMemory
Install-Package Microsoft.EntityFrameworkCore.SqlServer

Enable-Migration
Update-Database

Build / dotnet Restore

Add-Migration 'Initial'
Update-database