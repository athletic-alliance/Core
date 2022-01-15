## Getting started

### Database Configuration

Add a new Migration:
 `dotnet-ef add "Initial" --project Infrastructure --startup-project Api --output-dir Persistence/Migrations`

Update the database:
 `dotnet ef database update --project Infrastructure --startup-project Api`