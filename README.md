# Garderie

## Introduction
Application web développée en [ASP.NET Core 2.1](https://docs.microsoft.com/fr-fr/aspnet/core/?view=aspnetcore-2.1) avec [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/index) en suivant une approche Code First sur une base de données existante.

## Configuration
Modifiez le fichier appsettings.json dans votre projet avec les informations de votre base de données Microsoft SQL Server :

```
{
  "ConnectionStrings": {
    "Garderie": "Server=(localdb)\\mssqllocaldb;Database=Garderie;User Id=;Password=;MultipleActiveResultSets=True;"
  },
}
```

## Contributeurs
* [Youness Dendane](https://github.com/yden063)
* [Maryline Yakan](https://github.com/marylineyk)
* [Fadoua Hamouachy](https://github.com/fhy01)
* [Louis Blasselle](https://github.com/louisbla)
