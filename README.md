# NexGen Innovations
> [!NOTE]
This is a CRUD system developed in ASP.NET CORE MVC, which is connected to a Sqlite3 database. It uses Scaffold to automatically generate the code needed for create, read, update, and delete operations. The frontend is designed with Bootstrap for a responsive and modern user interface.

- Explanatory video on YouTube: https://www.youtube.com/watch?v=FRRp64l4Df4
  
<!-- En resumen, solo se sube la imagen y se toma el URL para editarlo, y se utiliza display flex para agregarlas una al lado de la otra ajustando el width -->
<div style="display: flex;">
  <img src="https://github.com/K3ury99/Nexgen-Innovations/assets/128008789/245eb144-89e4-42ba-b249-5b764e91354e" width="49%"></img>
  <img src="https://github.com/K3ury99/Nexgen-Innovations/assets/128008789/90592af9-5057-4b42-8a20-590b4acf3c31" width="49%"></img>
</div>

## Requirements

- ASP.NET Core SDK
- Visual Studio or Visual Studio Code (or another text editor of your choice)

## Facility

1. Clone this repository to your local machine:
- git clone https://github.com/K3ury99/Nexgen-Innovations.git

3. Open the project in Visual Studio or Visual Studio Code.

4. Open the terminal in the project location and run the following commands to install the dependencies: dotnet restore

## Database configuration

1. Make sure you have Sqlite3 installed on your system.

2. Open the `appsettings.json` file and check the database connection string. Make sure it is pointing correctly to the Sqlite3 database file.

3. Run the migrations to create the database: dotnet ef database update

## Use

1. Run the application: dotnet run

## Contribute

If you wish to contribute to this project, please follow the following steps:

1. Fork this repository.

2. Create a new branch for your feature: git checkout -b feature/new-feature

3. Make your changes and commit:
- git add .
- git commit -m "Description of your changes"

4. Push your branch: git push origin feature/new-feature

5. Create a pull request on GitHub and describe your changes in detail.

> [!IMPORTANT]
This project was developed by: **Keury Ramírez, Victor Sanchez.**

