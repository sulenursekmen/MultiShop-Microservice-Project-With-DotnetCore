🚀# MultiShop Microservice Project With .NET Core 8.0

## Overview
This project is developed with ASP.NET Core 8.0, utilizing modern technologies and a microservices architecture. With Docker integration, it offers a portable, secure, and scalable infrastructure. The project is configured to work seamlessly with both SQL and NoSQL databases such as MSSQL, MongoDB, Redis, and PostgreSQL.

## Project Features

⚪ Microservices Architecture: Built using Layered and Onion architectures, providing a flexible and extensible structure adhering to SOLID principles.
⚪ Design Patterns: Repository, CQRS, and Mediator design patterns enhance scalability and modularity.
⚪ Security: Identity Server and JWT provide user authentication and authorization.
⚪ Database Management: Optimized data handling with MSSQL, MongoDB, Redis, and PostgreSQL.
⚪ API Management: Ocelot Gateway handles API routing, with documentation generated via Swagger.
⚪ Real-Time Notifications: SignalR integration enables real-time notifications without page refreshes.
⚪ Testing: API endpoints are tested and verified with Postman.

## Technologies Used

⚪ Backend: ASP.NET Core 8.0 Web API
⚪ Databases: MSSQL, MongoDB, Redis, PostgreSQL
⚪ Container Management: Docker
⚪ Database Tools: DBeaver, Dapper
⚪ API Testing: Postman, Swagger
⚪ Messaging: RabbitMQ
⚪ Storage: Google Cloud Storage
⚪ Architectural Patterns: Onion Architecture, CQRS, Mediator, Repository Design Pattern
⚪ Security: Identity Server, JWT
⚪ API Gateway: Ocelot Gateway
⚪ Real-Time Notifications: SignalR
⚪ Frontend Technologies: HTML, CSS, JavaScript, Bootstrap

## System Requirements
To run this project locally or in a production environment, ensure that you have the following installed:

⚪ .NET Core SDK 8.0 or later
⚪ Docker (latest version recommended for container management)
⚪ Redis Server (for caching, if running locally)
⚪ RabbitMQ Server (for messaging, if running locally)
⚪ PostgreSQL or MSSQL Server (or any SQL database compatible with the project’s configuration)
⚪ MongoDB (for NoSQL database support)

## Package Dependencies
Below are the main libraries and packages used within the project:

## NuGet Packages
These should be added via NuGet Package Manager or the dotnet add package command.

⚪ Microsoft.EntityFrameworkCore - ORM for SQL database management
⚪ Microsoft.EntityFrameworkCore.SqlServer - SQL Server provider for Entity Framework Core
⚪ Dapper - Lightweight ORM for data access
⚪ MediatR - Mediator pattern implementation for CQRS
⚪ IdentityServer4 - Authentication and Authorization
⚪ System.IdentityModel.Tokens.Jwt - JWT token handling for secure API access
⚪ SwaggerGen - API documentation generation
⚪ Ocelot - API Gateway
⚪ SignalR - Real-time communication for notifications

## Additional Libraries
These libraries are suggested if your project includes frontend work or testing tools.

Postman - Recommended for API testing (not a direct dependency but useful for development)

## Installation

To clone the project:

git clone https://github.com/sulenursekmen/MultiShop-Microservice-Project-With-DotnetCore.git


## Some UI Pages

![Ekran görüntüsü 2024-10-25 093142](https://github.com/user-attachments/assets/ac88d75a-8274-4008-835a-583dc50fbf6a)
![Ekran görüntüsü 2024-10-25 092734](https://github.com/user-attachments/assets/e9fe5498-fd4d-4dd1-a3e8-7b97cc04ba10)
![Ekran görüntüsü 2024-10-25 092506](https://github.com/user-attachments/assets/065e3863-bf22-4725-b64c-60cc9ca85538)
![Ekran görüntüsü 2024-10-25 091931](https://github.com/user-attachments/assets/5627ba56-a967-4652-8298-50460f8e5787)
![Ekran görüntüsü 2024-10-25 091748](https://github.com/user-attachments/assets/f79eb2e9-fa23-46be-b5b3-5b3ded02718e)
![Ekran görüntüsü 2024-10-25 091606](https://github.com/user-attachments/assets/3771ba32-a794-4e5a-8b94-33622d5d8cf5)
![Ekran görüntüsü 2024-10-25 091451](https://github.com/user-attachments/assets/a532b9b2-3219-4292-8ba7-c0e8b8e1a259)
![Ekran görüntüsü 2024-10-25 091232](https://github.com/user-attachments/assets/39913cb2-923e-454f-bbe2-cbe2629b42ca)
![Ekran görüntüsü 2024-10-25 091016](https://github.com/user-attachments/assets/f18ebcce-b3e3-4b63-815c-070534bbdcf6)
![Ekran görüntüsü 2024-10-25 090244](https://github.com/user-attachments/assets/c23886d4-8dd8-423c-8a93-f25c7bce3848)
![Ekran görüntüsü 2024-10-25 090014](https://github.com/user-attachments/assets/6599da64-eb3d-4598-8f8f-48fe05f88b2f)
![Ekran görüntüsü 2024-10-25 085633](https://github.com/user-attachments/assets/993dcc2b-936b-40b8-b72b-3249b12532cf)
![Ekran görüntüsü 2024-10-25 085446](https://github.com/user-attachments/assets/e22ac0f6-6a4d-4267-9a71-9bc7b18ff65f)
![Ekran görüntüsü 2024-10-25 084802](https://github.com/user-attachments/assets/8d781a11-fc85-43a3-8d9c-0a347c4ef2af)
![Ekran görüntüsü 2024-10-25 083621](https://github.com/user-attachments/assets/69b5334c-1e7e-4b89-aa67-428d105f95e7)


