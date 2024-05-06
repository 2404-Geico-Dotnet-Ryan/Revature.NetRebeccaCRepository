# Application Architectural Design Structures and Patterns

- Why Use Design Patterns / Standard Conventions?
  - Reusability
  - Readability
  - Scalability
  - Modularity
  - Maintainability

- To help us structure our application we are going to organize our applications into Layers.
- Layers -> Roles/Duties that our application needs to accomplish.
- Single Responsibility Principle -> Each aspect of our application should have but one responsibility AND should be the only aspect that manages said responsibility.

---

### Layers

- Application Layer
  - Developing an interface for the end user to use the presented information

- Presentation Layer
  - Converting Data into a presentable layer

- Controller Layer
  - is responsible for handling Application Logic, which includes ideas like processing requests and generating responses.

- Service Layer
  - is responsible for performing Business Logic, which includes things like filtering, searching, sorting, validating, etc...
    - Would do so upon the data that was retrieved by the Repository Layer.

- Data Access Layer - Repository Layer
  - is responsible for data(base) interaction. Theses objects that we create will perform any amount of retrieval, manipulation, destruction to our data.
    - These Objects are referred as Data Access Objects: DAOs

- Data Layer 
  - Where all data exists. Typically stored in something like a Database, or perhaps some form of a file system.
  - Represented in your Applications through: Models
    - Cars, Users, Courses, BankAccounts, Roles, etc...