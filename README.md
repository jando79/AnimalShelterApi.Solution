## Animal Shelter Api

#### By David Jandron

#### An API for a ficticious animal shelter.

## Technologies Used

* C#
* .NET
* ASP.Net
* Entity Framework

## Description

An API providing information about animals currently residing in a ficticious animal shelter. 

## How To Run This Project

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

If you have not already, install the `dotnet-ef` tool by running the following command in your terminal:

```
dotnet tool install --global dotnet-ef --version 6.0.0
```

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "AnimalShelter".
3. Within the production directory "AnimalShelter", create two new files: `appsettings.json` and `appsettings.Development.json`.
4. Within `appsettings.json`, put in the following code. Make sure to replacing the `uid` and `pwd` values in the MySQL database connection string with your own username and password for MySQL. For the LearnHowToProgram.com lessons, we always assume the `uid` is `root` and the `pwd` is `epicodus`.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter_api;uid=root;pwd=epicodus;"
  }
}
```


## Planetary Dictionary

#### By Sarah Andyshak, David Jandron, Ashe Urban, Asia Kaplanyan, Mesha Devan, Jackson Levine

#### An API for interstellar exploration.

## Technologies Used

* C#
* .NET
* ASP.Net
* Entity Framework

## Description

An API providing vital facts about the universe. 

## How To Run This Project

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

If you have not already, install the `dotnet-ef` tool by running the following command in your terminal:

```
dotnet tool install --global dotnet-ef --version 6.0.0
```

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "PlanetaryDictionary".
3. Within the production directory "PlanetaryDictionary", create two new files: `appsettings.json` and `appsettings.Development.json`.
4. Within `appsettings.json`, put in the following code. Make sure to replacing the `uid` and `pwd` values in the MySQL database connection string with your own username and password for MySQL. For the LearnHowToProgram.com lessons, we always assume the `uid` is `root` and the `pwd` is `epicodus`.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=planetary_dictionary;uid=root;pwd=epicodus;"
  }
}
```

5. Within `appsettings.Development.json`, add the following code:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```
6. Create the database using the migrations in the Animal Shelter API project. Open your shell (e.g., Terminal or GitBash) to the production directory "AnimalShelter", and run `dotnet ef database update`. You may need to run this command for each of the branches in this repo. 
    - To optionally create a migration, run the command `dotnet ef migrations add MigrationName` where `MigrationName` is your custom name for the migration in UpperCamelCase. To learn more about migrations, visit the LHTP lesson [Code First Development and Migrations](https://www.learnhowtoprogram.com/c-and-net-part-time/many-to-many-relationships/code-first-development-and-migrations).
7. Within the production directory "AnimalShelter", run `dotnet watch run --launch-profile "PlanetaryDictionary-Production"` in the command line to start the project in production mode with a watcher. 
8. To optionally further build out this project in development mode, start the project with `dotnet watch run` in the production directory "AnimalShelter".
9. Use your program of choice to make API calls. In your API calls, use the domain _http://localhost:5000_. Keep reading to learn about all of the available endpoints.

## Testing the API Endpoints

You are welcome to test this API via [Postman](https://www.postman.com/) or [curl](https://curl.se/).

### Available Endpoints

```
GET http://localhost:5000/api/animals/
GET http://localhost:5000/api/animals/{id}
POST http://localhost:5000/api/animals/
PUT http://localhost:5000/api/animals/{id}
DELETE http://localhost:5000/api/animals/{id}
```

Note: `{id}` is a variable and it should be replaced with the id number of the animal you want to GET, PUT, or DELETE.

#### Optional Query String Parameters for GET Request

GET requests to `http://localhost:5000/api/animals/` can optionally include query strings to filter or search animals. For example:

| Parameter   | Type        |  Required    | Description |
| ----------- | ----------- | -----------  | ----------- |
| breed        | String      | not required | Returns animals with a matching breed value |
| age          | Number      | not required | Returns animals with a matching age value |



The following query will return all animals with the breed "Cat":

```
GET http://localhost:5000/api/animals?breed=Cat
```

You can include multiple query strings by separating them with an `&`:

```
GET http://localhost:5000/api/animals?name=steve&age=40
```

#### Additional Requirements for POST Request

When making a POST request to `http://localhost:5000/api/animals/`, you need to include a **body**. Here's an example body in JSON:

```json
{
  "breed": "Cat",
  "name": "Steve",
  "age": 40,
  "funFact": "Actually human, but pretends to be a cat. Could use a nice home, psychiatrist, and medication."
}
```

#### Additional Requirements for PUT Request

When making a PUT request to `http://localhost:5000/api/animal/{id}`, you need to include a **body** that includes the animals's `animalId` property. Here's an example body in JSON:

```json
{
  "animalId": 6,
  "breed": "Tiger",
  "name": "Lion",
  "age": 1,
  "funFacts": "Previous owner was terrible at animal identification. Gluten-free. Flys"
}
```

And here's the PUT request we would send the previous body to:

```
http://localhost:5000/api/animal/6
```

Notice that the value of `animalId` needs to match the id number in the URL. In this example, they are both 6.

## Known Bugs

* No known issues.

## License
Enjoy the site!

[MIT](https://github.com/git/git-scm.com/blob/main/MIT-LICENSE.txt)

Copyright (c) 2023 David Jandron