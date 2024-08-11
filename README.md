# My attempt of making an online chess app

ASP.NET Core Web Api. Uses Auth0 and a MySQL server. Will make frontend with Angular later.

### Add appsettings.json in chess-api
Sample file structure
```
romeo-chess
├── chess-api
│   ├── appsettings.json
│   ├── Controllers/
│   ├── Data/
│   ├── Models/
└── └── Properties/
```
```json
appsettings.json file
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "Default": "{yourConnectionString}"
  },

  "Auth0": {
    "Domain": "{yourDomain}",
    "Audience": "{yourAudience}"
  }
}

```

### Running chess-api
Run with ```dotnet watch run -lp https```
or with ```dotnet watch run -lp https allowAnon=true``` to allow anonymous.