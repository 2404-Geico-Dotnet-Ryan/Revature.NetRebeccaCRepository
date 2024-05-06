# Application Architectural Design Structure and Patterns

- Why use deisgn patterns or standard convientions?
    - Resusablity
    - Readablity - general population can understand it
    - Scalablity - in order to grow our stucture
    - Modularity - common structure
    - Maintainablity - able to keep it up with fresh updates easily (this is important for testing, updating simple list, etc.)

- To help us structure our application we are going to start organizing our application into what are called Layers
- Layer(Level) is a single role/duty that our application needs to accomplish 
- Single Responsiblity Principle - each aspect of our application should have but one responsiblity AND should be the only aspect that manages said responsiblity.
- This is incremental development - one task at a time 

###  Layers (goes up and down one step at a time- no skipping)
- bottom up approach starts at last layer (data) and building layers up to top application layer is the most common way to build things and the way we will do this in class 
- the top down approach starts at building application first then work down in layers 
- the sandwhich approach kind of jumps around in building layers 


- Application Layer 
    - Developing an interface for the end user to use the presented information
      - Methods lesson where we asked for input

- Presentation Layer
    - Converting Data into a presentable layer
        - this cuold be Console.WriteLine or formatting the output

- Controller Layer
    - is responsible for handling Application Logic. 
        - ideas like processing request sent into the application and generating responses.

- Service Layer  
    - is responsible for performing business logic in our application.
        - Such business logic is filtering, searching, sorting, validating, etc...
            - this would do so upon the data which was retrieved from the Data Access (Repo) layer
        - used in loging in for example (which would use other layers)
        - the flow the program has to follow to make something happen.

- Data Access Layer - Repository Layer 
    - Responsible for data (base) interaction in our application .
    - These objects we create will perform any amount of retrieval, munipulation, destruction, to our data.
        - referred to as data access objects : DAOs

- Lowest layer - Data Layer 
    - Where all of our data exists and is maintained. Typically stored in something (database or some sort of file system).
    - This is represented in applications through : Models
        - Models - any class we create (Cars, Pizzaz, users, roles) Traditional Classes with properties constructors ToString etc. This are temporarily stored no permenance yet. 

If you look up on the internet this information could vary - this is the most basic and most useful outline for our purposes. 

