# WebApi

* [Docker Quickstart on Visual Studio for Mac](https://docs.microsoft.com/en-us/visualstudio/mac/docker-quickstart?view=vsmac-2019)
* [Get started with Swashbuckle and ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=visual-studio)
* [Swagger Petstore](https://petstore.swagger.io/v2/swagger.json)
* [Medium > Dev Genius > Serilog vs NLog](https://medium.com/dev-genius/serilog-vs-nlog-7d0a322a4732)
* [Serilog.AspNetCore](https://github.com/serilog/serilog-aspnetcore)
* [Elastic.CommonSchema.Serilog](https://github.com/elastic/ecs-dotnet/tree/master/src/Elastic.CommonSchema.Serilog)
* [Serilog.Sinks.Elasticsearch](https://github.com/serilog/serilog-sinks-elasticsearch)

## Database

* [DockerHub > Microsoft SQL Server](https://hub.docker.com/_/microsoft-mssql-server)
    ```
    docker pull mcr.microsoft.com/mssql/server
    docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Passw0rd!' -p 1433:1433 -d mcr.microsoft.com/mssql/server:latest
    docker exec -it cf3f34b8be2b /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 'Passw0rd!'
    ```
* [Docker Docs > Quickstart: Compose and ASP.NET Core with SQL Server](https://docs.docker.com/compose/aspnet-mssql-compose/)
* [Working with the SQL Server command line (sqlcmd)](https://www.sqlshack.com/working-sql-server-command-line-sqlcmd/)
* [sqlcmd Utility](https://docs.microsoft.com/en-us/sql/tools/sqlcmd-utility?view=sql-server-ver15)

```
CREATE DATABASE PetStore;
```

## ELK

* [elastic Docs > Install Elasticsearch with Docker](https://www.elastic.co/guide/en/elasticsearch/reference/current/docker.html)
* [elastic Docs > Install Kibana with Docker](https://www.elastic.co/guide/en/kibana/current/docker.html)

```
cd support_cluster
docker-compose up -d
```
