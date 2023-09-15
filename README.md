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

In the initial phase of our Video Game E-commerce project, I established a solid backend infrastructure using C#, ASP.NET, and the Entity Framework. I integrated all required packages for both frontend and backend using the NuGet package manager. Our database was configured and connected using MS SQL Server Management Studio. Beyond mere coding, this phase was about conceptualizing, designing, and architecting the core essence of our application. To visualize and map out our application, I used Excalidraw for sketching and employed EDR flowcharts to understand database relationships.


## Embracing the Power of SQL Server:

For our application's data storage, I opted for SQL Server—a reliable choice that facilitated the creation and management of our local database, laying a stable groundwork for our app data. I utilized MVC to shape the database models, which were initially structured as simple classes. Over time, these evolved, with more classes being added, often interconnected via foreign keys. I paired these classes with the ICollection method.

The principles of C# Object-Oriented Programming (OOP) played a pivotal role, especially in determining the use of public, private, and readonly accessors within the classes. Given that a significant portion was related to the gaming class, I modularized some classes into smaller sections for better manageability and potential reuse. After setting up the classes, I integrated the local database with the backend.

SQL Server was chosen not only for its stability but also for its flexibility in supporting robust connections to cloud databases like Azure, AWS, and more. This project became an enriching learning curve, especially as my prior experience was mainly with Table Plus and MySQL for local databases.

## NuGet Packages and JWT:

To supercharge the backend, I harnessed the incredible capabilities of NuGet packages. These packages became our tools, empowering us to streamline tasks, enhance security, and accelerate development. Among them, JWT (JSON Web Tokens) stood out as our trusty guardian, ensuring the utmost security for user authentication. I used Enitity and Identify nuget packages to connect the local host default connection and use Identify for the application user which is an inbuilt into the entitiy framework.


### Phase 2 Designing the Database and Crafting Models:

Certainly! Let's simplify and streamline the information:

---

**Video Game Shop Project - Phase Two**

**Controllers Creation & Testing**: Based on our early designs, we built controllers to manage web requests. Testing was done using tools such as Swagger and Insomnia. 

**Database Design with MS SQL Server Management**: Given the intricate data relationships in our app—spanning from video games to user reviews—we needed a robust database system. SQL Server Management was chosen for this task. We created well-structured tables to avoid data redundancy and maintain easy-to-understand relationships, both simple and complex.

**Using Stored Procedures & Triggers**: We used stored procedures for efficient data operations and triggers to ensure data consistency.

**Building Models with C# ASP.NET Entity Framework**:

- **Entity Creation**: For each database table, we created a corresponding model in C#.
  
- **DBContext**: This serves as the liaison between our app and the database, ensuring smooth data operations.

- **LINQ for Data Operations**: With LINQ, database operations, from data retrieval to updates, became straightforward and efficient.

**Testing with Seeding Data**: To ensure our app's optimal performance, I populated our database with test data. I believe a solid backend sets the stage for an impeccable frontend experience, especially when performing real-world data operations.

**Middleware & Tools**: Proper middleware integration was essential for CORS support, ensuring smooth communication across various sources. We extensively used Swagger for API testing, complemented by Insomnia for data exchange verification.

---

### Key Learnings from Phase 2:
Database Design: Understanding the intricacies of relationships and ensuring a scalable and efficient design is paramount. A good schema today can prevent many potential headaches in the future.

Entity Framework: Leveraging EF can drastically simplify database operations, but it's crucial to understand its inner workings to prevent inefficiencies.

The Power of LINQ: A potent tool in a developer's arsenal, LINQ is both versatile and expressive. However, one must be cautious to avoid over-complicating queries and affecting performance.

Phase 2, though challenging, was a testament to the importance of meticulous planning. The schemas, models, and classes we designed and implemented are now ready to support the next stages of our Video Game Management System. The road ahead is exciting, and we eagerly look forward to the challenges and triumphs that lie in wait.


### Phase 3: Bridging Backend with Frontend:

In this phase, we integrated our backend services with the frontend interface. We employed Angular—a component-based framework—to ensure seamless communication with our ASP.NET backend.

**Seeding & Initial Tests**: I initiated the process by populating our system with test data derived from the video game models and their associated relationships. Using tools like Insomnia, I verified if the application correctly accessed information via designated endpoints and HTTP requests.

**API Development**: Using ASP.NET, we developed RESTful APIs to bridge the gap between our frontend and backend. This included endpoints for every video game function, user interactions, and specific features like user login, registration, profile management, and JWT token generation for user authentication.

**Endpoint Organization**: We structured our endpoints within the Controller section, categorizing them to maintain clarity. Developing the Auth controller posed some challenges, particularly in integrating JWT tokens for authentication.

**Validation and Testing**: With Swagger, I validated data retrieval in JSON format. Additionally, I used bearer tokens in Insomnia and console logs to check user authentication. To enhance user feedback and provide a dynamic user experience, I integrated toaster notifications.

---

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
