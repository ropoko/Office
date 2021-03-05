# Coursework - Office

Project developed as coursework for Etec - Comendador João Rays High School.

## About
Website for a fictional store, where users can reserve a product for later buy it in the physical store.

### Features
- Levels of users (Administrator, commom user - customer)
- Users management
- Products management
- Define categories by products

## Technologies
- MVC Design Pattern
- C#
- MySql
- Javascript

## Development
Before starting, you should have MySql and the dotnet-ef tool to the development.

[Install MySql](https://www.mysql.com), then create a database called "office", to change the name of the database, you also have to change it on appsettings.json,
passing the respective data.

dotnet-ef tool: `$ dotnet tool install --global dotnet-ef`.

Clone: `$ git clone https://github.com/ropoko/Office.git`.

On project: `$ dotnet restore` then `$ dotnet build`.
Obs: some new folders should appear.

Run migrations to create the tables: `$ dotnet-ef migrations add Initial` then `$ dotnet-ef database update`.
Obs: check if the tables were created.

Run the project: `$ dotnet run`.
