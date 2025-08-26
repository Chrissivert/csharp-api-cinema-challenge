
# C# Docker Day 1 Exercise

## Learning Objectives

- Complete & Deploy the exercise.wwwapi API project to a Docker Container

## Instructions

1. Fork this repository
2. Clone your fork to your machine
3. Open the project

## Core and Extension

Dockerize an existing .NET Core Web API project, you may use this project, an existing webapi project or start a new one. If you use an existing one, just remove this project and delete from the directory, copy the project into the root and add to the solution.
- Ensure your application has at least  a GET, POST, PUT and DELETE 
- Ensure your application has at least 2 Entities and 2 tables in the database
- Your API should connect to an [Neon](https://neon.tech) database instance that can be used for storing the data.
- Be consistant and choose one of the following as a response from your endpoints:
	- an anonymous object
	- a custom DTO
	- Automapper with DTO

Create a `Dockerfile` and any other associated files to allow you to deploy the application using a Docker Container.

Make sure your `appsettings.json` file is on `.gitignore` so that it doesn't contain your private database connection strings.

