dotnet ef migrations add AddCategoryTableToDb -s WizLib -p WizLib_DataAccess
dotnet ef Database Update -s WizLib -p WizLib_DataAccess
git commit -m "Create migration and Update Database"
dotnet ef Database Update RemoveGenreOrderFromGenreTable -s WizLib -p WizLib_DataAccess
