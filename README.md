# Template for ASP .netcore MVC Website 
> hosted in a docker container using EntityFramework Core to connect with SQL Server database
---
## Componenets
### ASP .netcore MVC
### EntityFramework Core
### MS SQL Server
### Docker
### Angular
### Bootstrap
### AutoMapper

## Debugging
In order to run the app in debug mode and be albe to connect to the database, the connection string needs to be added as a **user** environment variable with key name `DB_CONNECTION_STRING` and the following value:
`Server=.,11433;Database=ApplicationsDb;User=sa;Password=ThiIsReallySecure!3;MultipleActiveResultSets=true`
e.g. using PowerShell cpmmand:
`setx DB_CONNECTION_STRING "Server=.,11433;Database=ApplicationsDb;User=sa;Password=ThiIsReallySecure!3;MultipleActiveResultSets=true"`