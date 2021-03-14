# RazvojSoftveraII
Vježbe iz predmeta Razvoj softvera 2 (2021)


* [Docker SQL image] (https://hub.docker.com/_/microsoft-mssql-server)

	```
	docker pull mcr.microsoft.com/mssql/server:2017-latest
	docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=yourStrong(!)Password' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest
	```

* Nugget: 

Micrososft.Aspnetcore.App (db, security, logging)
AutoMapper.Extensions.Microsoft.DependencyInjection

* DB Scaffold

	```
	Scaffold-DbContext 'Data Source=localhost;Initial Catalog=eProdaja;Trusted_Connection=True;' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Database
	```


* Helpful links

	[Git] (https://www.earthdatascience.org/workshops/intro-version-control-git/basic-git-commands/)

	[EF Core] (https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-5.0)

	[AutoMapper] (https://code-maze.com/automapper-net-core/)


