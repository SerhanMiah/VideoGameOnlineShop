# VideoGameOnlineShop - A work in Progress


# Project Overview

I'm building my first e-commerce app using ASP.NET, C#, TypeScript, and Angular. Security will be managed with JWT tokens on both the backend and frontend, using local storage. The system will handle various relationships between video games and users, planned out with Lucid Diagram and Excalidraw.

## Deployment

### 1. Environment Setup:
- Ensure [Node.js](https://nodejs.org/) is installed, as it's essential for Angular and TypeScript.
- Make sure you have the [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet) to compile and run the ASP.NET Core backend.
- Install the Angular Command Line Interface:
  ```bash
  npm install -g @angular/cli
  ```

### 2. Repository Setup:
- Either clone or download the source code from the provided GitHub repository link.
- Link to GitHub repository [https://github.com/SerhanMiah/VideoGameOnlineShop]
## Deployment Steps:

### 1. Backend Preparation:
- Navigate to the directory containing the ASP.NET Core solution or project file:
  ```bash
  cd Backend
  ```
- Restore the required .NET packages:
  ```bash
  dotnet restore
  ```

### 2. Frontend Preparation:
- Switch to the Angular application directory (commonly named "Frontend"):
  ```bash
  cd FrontendOrClientAppName
  ```
- Install the required Angular dependencies:
  ```bash
  npm install
  ```
### 3. Running the Backend:
- Ensure you're in the Backend directory, then start the application:
  ```bash
  cd ../Backend
  dotnet run
  ```
- This will initialize the backend, typically accessible at https://localhost:5177.

### 4. Launching the Frontend:
- Shift to the Frontend directory:
  ```bash
  cd Frontend
  ```
- Use Angular CLI to serve the application:
  ```bash
  ng serve
  ```
- This initiates the Angular app, generally available at http://localhost:4200.

### 5. Verification:
- Open your preferred web browser and enter the provided URLs to interact with the backend services and frontend interface.

---

To see the full features for Theatre, please feel free to log in using the following credentials:

 * email: test@email.com
 * password: Password@

# The Brief

* Build a full-stack application integrating both the backend and the frontend.
* Utilize an ASP.NET Core API to interact with data from a SQL Server database.
* Use Entity Framework Core for ORM and data access.
* Consume your API with a separate frontend built with Angular and TypeScript.
* Ensure a comprehensive product, which likely entails multiple relationships and CRUD functionality for at least a couple of models/entities.
* Draft thoughtful user stories/wireframes that are detailed enough to guide you in distinguishing between core MVP features and optional enhancements.
* Deploy your application online ensuring it's publicly accessible.

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

In first phase of the Video Game e-commerical project, I embarked on a journey to create a robust backend infrastructure, using C#, ASP.net and Enitity Framework. Installing all the necessary packages for the backend and frontend. I used nuget packag manager to install Enitity framework packages and linked the database to MS SQL server management studio. This journey was not just about code; it was about envisioning, designing, and organizing the very essence of the application. I turned to the digital canvas of Excalidraw to sketch out the gaming application and using EDR flowchart to have an idea on how the relationships were being made.


## Embracing the Power of SQL Server:

For data storage needs, I chose SQL Server—a dependable companion on this application journey. With SQL Server, I could create and manage our local database, providing a stable foundation for our application's data. MVC is used to create the model of the database which are constructed as classes, I started very basic and moved to add more and more classes often linking these classes with forigen keys and pairing these classes with ICollection method. Using C# OOP and understanding how public, private and readonly accessor will be used with the classes. As the bulk of the class relates to the gaming class, I decided to seperate some of the classes to small sections, making it more manageable. Also to have the option to reuse these classes for other object. Once the classes was created pairing the database to the backend locally. I want to have full flexibility when using an SQL package as SQL server offered a robust connection to online database like Azure, AWS and others. I felt confident with using SQL Server for this project and as a new learning experience since I used Table Plus and MySQL for local databases. 

## NuGet Packages and JWT:

To supercharge the backend, I harnessed the incredible capabilities of NuGet packages. These packages became our tools, empowering us to streamline tasks, enhance security, and accelerate development. Among them, JWT (JSON Web Tokens) stood out as our trusty guardian, ensuring the utmost security for user authentication. I used Enitity and Identify nuget packages to connect the local host default connection and use Identify for the application user which is an inbuilt into the entitiy framework.


### Phase 2 Designing the Database and Crafting Models:

In the second phase of our venture into building the Video Game shop, the foundation and conceptualizations of the inaugural phase were put to the test. Here, I delved into the realms of database design and model creation.

Solidifying Our Database with MS SQL Server Management:
Microsoft SQL Server Management, played a pivotal role. Given the intricate relationships between video games, user profiles, reviews and shopping cart, it was crucial to ensure our database could handle complex queries and maintain data integrity.

Schema Creation: We designed tables keeping normalization in mind, ensuring data redundancy was minimized. Tables for video games, user profiles, and relational tables were meticulously crafted to cater to both one-to-many and many-to-many relationships.

Stored Procedures and Triggers: Leveraging the power of MS SQL Server Management, we set up stored procedures to streamline complex operations. Triggers were also designed to maintain consistency and prevent potential data anomalies.

Crafting Models and Classes with C# ASP.NET Entity Framework:
Entity Framework (EF) is a gem in the .NET ecosystem, allowing myself to interact with the databases using object-relational mapping (ORM). Our models became the representatives of our database tables, simplifying data operations and making them more intuitive as time passes.

Creating Entities: For every table in our database, a corresponding model was built in C#. These models, adorned with necessary attributes and annotations, made data validation and relationships seamless.

DBContext Creation: The DBContext is the bridge between our application and the database. We created a custom DBContext to manage our entities and their relationships.

LINQ Queries: With the power of LINQ, querying became a delightful experience. From fetching a particular video game's details to updating user profiles, LINQ brought clarity and efficiency to our database operations.

Upon creating the database, I employed seeding data as a method to test the application's responsiveness across both frontend and backend. I firmly hold the belief that if the backend functions optimally, it paves the way for a smoother frontend experience. This is especially true when executing HTTP requests for data retrieval, creation, updating, and deletion in a real-world application setting. 


Managing and integrating the middleware was crucial for enabling CORS and ensuring smooth interactivity across different origins. Additionally, by utilizing tools like Swagger, I could efficiently test the API controllers and their HTTP requests. Insomnia further supplemented this process, allowing us to validate back-and-forth data exchanges seamlessly.


### Key Learnings from Phase 2:
Database Design: Understanding the intricacies of relationships and ensuring a scalable and efficient design is paramount. A good schema today can prevent many potential headaches in the future.

Entity Framework: Leveraging EF can drastically simplify database operations, but it's crucial to understand its inner workings to prevent inefficiencies.

The Power of LINQ: A potent tool in a developer's arsenal, LINQ is both versatile and expressive. However, one must be cautious to avoid over-complicating queries and affecting performance.

Phase 2, though challenging, was a testament to the importance of meticulous planning. The schemas, models, and classes we designed and implemented are now ready to support the next stages of our Video Game Management System. The road ahead is exciting, and we eagerly look forward to the challenges and triumphs that lie in wait.


### Phase 3: Integrating Backend and Frontend:

This phase was all about bringing our backend services and frontend interface together. Angular, a component-based framework, facilitated the smooth interaction between the user and our ASP.NET backend.

Started by creating seeding data using the models of games and its relationships. I started to build a few seeding data to test the application both the backend and frontend. Using insomia, I wanted to test if the application is able to retrieve the information from the required endpoints and HTTP request.

API Creation: Leveraging ASP.NET, we crafted RESTful APIs to enable communication between the frontend and backend. Every video game and user action had its corresponding API endpoint, ensuring full system functionality. The same functionality based on the user's login, register and profile and the ability to generate JWT token for authenticating users. 

These endpoints creation was created in the Controller section and was seperated into different parts. The Auth controller was a struggle as I wanted to use JWT token to authenticate 

Once these tests were carried out I started using swagger to see if I was able to retrieve the data in JSON format. I also used bearer token to authenticate the user in insomia and console log to see if the user were logged in. For a more dramatic feel I switched to toaster 

### Phase 4 Styling the Frontend

Over the past few days, I have poured my creative energy into designing a website that truly reflects my personal style. By leveraging the powerful combination of Bootstrap, Tailwind, CSS and SASS, I was able to add a level of sophistication and polish to the site's design that truly sets it apart.

In addition to aesthetics, I also devoted time to optimizing the site for mobile devices through code refactoring and implementation of CSS media.
These enhancements have truly elevated the site's functionality and aesthetics to new heights, making it a truly immersive and engaging experience for all who visit.



## Final Product 






## Wins & Challenges

### Win
* Successful Integration: Bringing together a C# backend and an Angular frontend was no small feat. However, my meticulous planning and design made integration smoother than anticipated.
* Updating the Cart when a registered user is logged in and hits the buy button in the game detail component page.
* Having a greater understanding on how OOP works and how it is used both in the frontend and backend. 





### Challenges
* TypeScript Learning Curve: Transitioning from JS to TS presented initial hurdles, especially around strict typing and interfaces.
* Learning TS and Angular while making this application was incredibly changling. From more experience developers I was told not to use any, however in certain situation this became impossible for my skillset and looking develop my skills futher using TS for future projects





### Bugs
*  TypeScript Learning Curve: Transitioning from JS to TS presented initial hurdles, especially around strict typing and interfaces.

*  Debugging Cross-Platform Issues: As with any full-stack development, ensuring seamless interaction between different technologies had its moments of head-scratching.




## Future Content and Improvements:

* Authentication Flow: Initial iterations had some bugs around the JWT authentication flow, which were subsequently ironed out.
* Using Swipe and other payment API method for the application. 




## Key learnings

* Coming from a JavaScript background, TypeScript's nuances were both challenging and enlightening. Static typing, although initially restrictive, proved invaluable in catching errors early. Angular's component-based architecture presented a paradigm shift but enabled more organized and modular code.


Embracing continuous learning was pivotal. Every challenge faced was an opportunity to delve deeper into the technology stack and emerge with a clearer understanding. Iterative development, feedback, and a focus on the user experience were crucial to the project's success.
