# VideoGameOnlineShop - A work in Progress


# Project Overview

This project aims to develop a comprehensive Video Game Shop System with a backend built using ASP.NET, LINQ queries, and C#, and a frontend implemented in TypeScript and Angular. The system will manage video games, user profiles, and their relationships, including one-to-many and many-to-many relationships.


## Deployment




## Code Installation:

Clone or download the repo then in your Terminal run the following commands:


## The Brief



## Technologies used:

### Frontend (TypeScript, Angular):
* Angular
* Tailwind
* Axios
* CSS/HTML
* TypeScript/JavaScript

### Back end:
* C#
* ASP.net
* Microsoft SQL Server Management

### Dev Tools:
* VS code
* Yarn
* Insomnia
* Git
* Github
* Google Chrome dev tools
* Trello Board (planning and timeline)
* Excalidraw (wireframing)
* Zoom
* Slack

## Phase

This project consisted of four phase

### Planning the Project: Building a Solid Foundation:

In the inaugural phase of our exciting Video Game Management System project, we embarked on a journey to create a robust backend infrastructure. This journey was not just about code; it was about envisioning, designing, and organizing the very essence of our application. We turned to the digital canvas of Excalidraw to sketch out our dreams.

## Laying the Groundwork with Excalidraw:

Imagine the power of Excalidraw—a digital playground where we visualized the architecture of our application. It was here that we designed and meticulously organized the essential models and classes that would form the backbone of our system. We outlined the relationships between video games, user profiles, and more, ensuring that every piece would fit seamlessly into the puzzle.


## Embracing the Power of SQL Server:

For our data storage needs, we chose SQL Server—a dependable companion on our journey. With SQL Server, we could create and manage our local database, providing a stable foundation for our application's data.

## NuGet Packages and JWT:

To supercharge our backend, we harnessed the incredible capabilities of NuGet packages. These packages became our tools, empowering us to streamline tasks, enhance security, and accelerate development. Among them, JWT (JSON Web Tokens) stood out as our trusty guardian, ensuring the utmost security for user authentication.

Our journey was just beginning, but it was already filled with promise and potential. With a clear plan, a vision translated into Excalidraw sketches, and the technology stack we needed, we were ready to dive headfirst into the exciting world of backend development for our Video Game Management System.

### Phase 2 Designing the Database and Crafting Models:

In the second phase of our venture into building the Video Game Management System, the foundation and conceptualizations of the inaugural phase were put to the test. Here, we delved into the realms of database design and model creation.

Solidifying Our Database with MS SQL Server Management:
Our chosen technology, Microsoft SQL Server Management, played a pivotal role. Given the intricate relationships between video games and user profiles, it was crucial to ensure our database could handle complex queries and maintain data integrity.

Schema Creation: We designed tables keeping normalization in mind, ensuring data redundancy was minimized. Tables for video games, user profiles, and relational tables were meticulously crafted to cater to both one-to-many and many-to-many relationships.

Stored Procedures and Triggers: Leveraging the power of MS SQL Server Management, we set up stored procedures to streamline complex operations. Triggers were also designed to maintain consistency and prevent potential data anomalies.

Crafting Models and Classes with C# ASP.NET Entity Framework:
Entity Framework (EF) is a gem in the .NET ecosystem, allowing developers to interact with their databases using object-relational mapping (ORM). Our models became the representatives of our database tables, simplifying data operations and making them more intuitive.

Creating Entities: For every table in our database, a corresponding model was built in C#. These models, adorned with necessary attributes and annotations, made data validation and relationships seamless.

DBContext Creation: The DBContext is the bridge between our application and the database. We created a custom DBContext to manage our entities and their relationships.

LINQ Queries: With the power of LINQ, querying became a delightful experience. From fetching a particular video game's details to updating user profiles, LINQ brought clarity and efficiency to our database operations.

Upon creating the database, I employed seeding data as a method to test the application's responsiveness across both frontend and backend. I firmly hold the belief that if the backend functions optimally, it paves the way for a smoother frontend experience. This is especially true when executing HTTP requests for data retrieval, creation, updating, and deletion in a real-world application setting.


Managing and integrating the middleware was crucial for enabling CORS and ensuring smooth interactivity across different origins. Additionally, by utilizing tools like Swagger, we could efficiently test the API controllers and their HTTP requests. Insomnia further supplemented this process, allowing us to validate back-and-forth data exchanges seamlessly.


### Key Learnings from Phase 2:
Database Design: Understanding the intricacies of relationships and ensuring a scalable and efficient design is paramount. A good schema today can prevent many potential headaches in the future.

Entity Framework: Leveraging EF can drastically simplify database operations, but it's crucial to understand its inner workings to prevent inefficiencies.

The Power of LINQ: A potent tool in a developer's arsenal, LINQ is both versatile and expressive. However, one must be cautious to avoid over-complicating queries and affecting performance.

Phase 2, though challenging, was a testament to the importance of meticulous planning. The schemas, models, and classes we designed and implemented are now ready to support the next stages of our Video Game Management System. The road ahead is exciting, and we eagerly look forward to the challenges and triumphs that lie in wait.


### Phase 3: Integrating Backend and Frontend:

This phase was all about bringing our backend services and frontend interface together. Angular, a component-based framework, facilitated the smooth interaction between the user and our ASP.NET backend.

API Creation: Leveraging ASP.NET, we crafted RESTful APIs to enable communication between the frontend and backend. Every video game and user action had its corresponding API endpoint, ensuring full system functionality.








### Phase 4 Styling the Frontend





## Final Product 






## Wins & Challenges

### Win
* Successful Integration: Bringing together a C# backend and an Angular frontend was no small feat. However, my meticulous planning and design made integration smoother than anticipated.





### Challenges
* TypeScript Learning Curve: Transitioning from JS to TS presented initial hurdles, especially around strict typing and interfaces.





### Bugs
*  TypeScript Learning Curve: Transitioning from JS to TS presented initial hurdles, especially around strict typing and interfaces.

*  Debugging Cross-Platform Issues: As with any full-stack development, ensuring seamless interaction between different technologies had its moments of head-scratching.




## Future Content and Improvements:

* Authentication Flow: Initial iterations had some bugs around the JWT authentication flow, which were subsequently ironed out.

* Authentication Flow: Initial iterations had some bugs around the JWT authentication flow, which were subsequently ironed out.



## Key learnings

* Coming from a JavaScript background, TypeScript's nuances were both challenging and enlightening. Static typing, although initially restrictive, proved invaluable in catching errors early. Angular's component-based architecture presented a paradigm shift but enabled more organized and modular code.

Embracing continuous learning was pivotal. Every challenge faced was an opportunity to delve deeper into the technology stack and emerge with a clearer understanding. Iterative development, feedback, and a focus on the user experience were crucial to the project's success.
