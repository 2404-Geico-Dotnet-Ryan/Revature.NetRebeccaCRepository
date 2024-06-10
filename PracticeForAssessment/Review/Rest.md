# RESTful APIs Review

## What is REST?

REST, or Representational State Transfer, is an architectural style for designing networked applications. It relies on a stateless, client-server, cacheable communications protocol -- the HTTP. REST is designed to take advantage of existing protocols and can be used over nearly any protocol, but when used for web APIs, it's most commonly associated with HTTP.

## What is a REST API?

A REST API (Application Programming Interface) is an interface that allows for interaction with RESTful web services. It uses standard HTTP methods (GET, POST, PUT, DELETE) to perform operations on resources, which are identified by URIs (Uniform Resource Identifiers). REST APIs are designed to be stateless and support CRUD (Create, Read, Update, Delete) operations.

## What are REST Constraints?

REST is defined by the following architectural constraints:

1. **Client-Server**: The client and the server are separated; clients interact with servers through a uniform interface (typically HTTP).
2. **Stateless**: Each request from a client to a server must contain all the information the server needs to fulfill that request. The server does not store any client context between requests.
3. **Cacheable**: Responses must explicitly indicate whether they are cacheable to improve network efficiency.
4. **Uniform Interface**: The interface between clients and servers is standardized to improve simplicity and visibility of interactions.
5. **Layered System**: The architecture allows for a layered system where a client can connect to an intermediary server (e.g., for load balancing, caching).
6. **Code on Demand (Optional)**: Servers can extend the functionality of clients by transferring executable code.

## What is HATEOAS?

HATEOAS stands for Hypermedia As The Engine Of Application State. It is a constraint of the REST application architecture that distinguishes it from other network application architectures. According to HATEOAS, a client interacts with a network application entirely through hypermedia provided dynamically by application servers. This allows the client to dynamically navigate resources by following links, similar to how web pages are navigated.

## What is Idempotent?

In the context of HTTP methods in REST, an operation is idempotent if it produces the same result regardless of how many times it is performed. For instance, the HTTP GET, PUT, and DELETE methods are idempotent:

- **GET**: Fetching the same resource multiple times will always return the same resource, provided it hasn't changed on the server.
- **PUT**: Updating a resource with the same data multiple times will not change the outcome beyond the initial application.
- **DELETE**: Deleting a resource multiple times will result in the resource being deleted without causing an error beyond the first deletion.

### Non-Idempotent

- **POST**: Creates a resource, multiple identical requests can create multiple resources.

## What is JSON?

JSON (JavaScript Object Notation) is a lightweight data interchange format that's easy for humans to read and write, and easy for machines to parse and generate. It is a text format that is language-independent but uses conventions familiar to programmers of the C family of languages, including C, C++, C#, Java, JavaScript, Perl, Python, and others. JSON is widely used in RESTful APIs to format data being transferred between a client and server.

## What is the Richardson Maturity Model?

The Richardson Maturity Model is a way to grade your API according to the constraints of REST. It is divided into four levels:

- **Level 0**: The Swamp of POX Uses HTTP but not in a RESTful way. Essentially, it delivers XML data via POST.
- **Level 1**: Resources Introduces the concept of resources, where each resource is accessible via a URI.
- **Level 2**: HTTP Verbs Uses HTTP methods (GET, POST, PUT, DELETE) correctly.
- **Level 3**: HATEOAS Uses hypermedia links to allow clients to navigate the API dynamically.

## Difference between Authorization and Authentication

- **Authentication**: The process of verifying who a user is. This is often done via login credentials such as a username and password. For example, when you log into a website, you are authenticating yourself to the server.

- **Authorization**: The process of verifying what a user has access to. This occurs after authentication and determines the user's permissions and access levels within the system. For example, after logging in, you might have access to certain resources or actions that are determined by your role or permissions.