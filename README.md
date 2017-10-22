# Trabalho do tio cacio


Antes de rodar os comandos do projeto, criar um banco chamado "ContaLuz" (Sql Server) e trocar a connection string no appsettings.json
```json
{
  "ConnectionStrings" : {
    "DefaultConnection" : "Server=localhost;Database=ContaLuz;User Id={seuid};Password={suasenha};"
  },
  "Logging": {
    "IncludeScopes": false,
    "LogLevel": {
      "Default": "Warning"
    }
  }
}
```