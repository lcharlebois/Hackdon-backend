Update-Database -Migration {0} -Project Sherweb.HackDon.Models -StartupProject Sherweb.HackDon.Api
Get-ChildItem .\Sherweb.HackDon.Models\Migrations | Remove-Item -Force
Add-Migration -Name InitialMigration -Project Sherweb.HackDon.Models -StartupProject Sherweb.HackDon.Api
Update-Database -Project Sherweb.HackDon.Models -StartupProject Sherweb.HackDon.Api
