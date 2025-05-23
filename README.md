# Project Name

## Database Setup

This project uses Entity Framework Core with Code First approach for database management.

### Initial Setup

After cloning the repository, you need to set up the database using the following steps:

1. Open the Package Manager Console in Visual Studio (Tools > NuGet Package Manager > Package Manager Console)

2. Run the following commands in sequence:

```
Enable-Migration
Add-Migration migrationName
Update-Database
```

> **Note:** Replace `migrationName` with a descriptive name for your migration (e.g., `InitialCreate`, `AddUserTable`, etc.)

### What These Commands Do

- `Enable-Migration`: Prepares your project to use migrations (only needed for initial setup)
- `Add-Migration migrationName`: Creates a new migration with the changes detected in your model
- `Update-Database`: Applies the migrations to your database, creating/updating the schema

## Additional Information

For more detailed information about Entity Framework Core migrations, visit the [official documentation](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/).
