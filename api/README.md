# Inventory system REST API

## information

The REST API is powered by [ASP.NET](https://dotnet.microsoft.com/en-us/apps/aspnet "Micosoft ASP.NET website").

[ASP.NET web API documentation](https://learn.microsoft.com/en-us/aspnet/core/web-api/?WT.mc_id=dotnet-35129-website&view=aspnetcore-6.0 "Microsoft ASP.NET documentation")


## usage

### initialize MariaDB

I would recommend using the shell.nix file in the maria folder.
The file will immediately create a database for you, if it hasn't already been created.

Otherwise you may choose to create the database however you'd like.

### create the database

At the moment, the REST API expects that the name of your database is "db_testing".
You may create this database by connecting to it over cli, and then using the command "CREATE DATABASE db_testing;".

If you are using the nix-shell, you may connect to the database by simply typing mariadb db_testing~.

### synchronize the database with the REST API

Use the command "dotnet ef database update", afterwards you may choose to run the database, and it should figure it out.
