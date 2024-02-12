# FinancialTamkeen_BlogAPI
## Prerequisites
.NET 6.0 SDK
Your preferred database server (e.g., SQL Server)
How to Run
Clone the repository
Update the connection string in appsettings.json
Run the API using dotnet run

Database Name test_db
url 
"sqlConnection": "Data Source=03-TRI-TRAINING\\TEST3;Initial Catalog=test_db; Integrated Security=True;TrustServerCertificate=True"
## dotnet ef migrations add InitialCreate
   Creates a new migration, capturing changes to the database schema in code.
## dotnet ef database update
   Applies pending migrations, updating the database schema to match the code-defined model.

## Table Definition
```sql
CREATE TABLE YourTableName (
  id INT,
  name VARCHAR(255),
  description VARCHAR(255),
  price DECIMAL(18, 2)
  Quantity INT
);


use sawgger UI/OpeAPI to make test 
