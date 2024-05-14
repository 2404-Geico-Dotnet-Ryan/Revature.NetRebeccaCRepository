# SQL Notes

- Database - a collection of Objects designed to hold/manipulate information (data)
  - There are many various objects that are associated with a Database.
  - Tables, Procedures, Functions, Triggers, Views, Cursors, Sequences, etc...
- Relational Database - Hold information in tables related to each other.
- Nonrelational Database - Hold information in objects such as a collection/document that are unrelated.
- RDBMS - Relational Database Management System
  - Software designed to manage a Database.
    - Example: PostgreSQL, Oracle SQL, MySQL, Maria DB, Microsoft SQL Server, SQLite, Amazon Aurora, etc...
    - Slight Differences between them, i.e.:
      - Oracle SQL -> `DELETE movies;`
      - PostgreSQL -> `DELETE FROM movies;`
- Table - Object that is composed of columns (fields) which hold attributes and rows (records) which model an instance of our entities.
  - Car Table
    - Columns -> the fields (properties) of that Car.
    - Rows -> instances of that Car.
- SQL - Structured Query Language
  - used for managing data held inside of an RDBMS.
  - Freedom to choose how much code is executed at a given time.
  - We don't craft classes/functions that we run, but instead we can use SQL files to behave more like a workspace. And we can execute some or all of that code whenever we want.
  - In practice,  SQL is not case-sensitive, CREATE == create == CrEaTe, 
    - Technically, it is case-sensitive, but SQL (more specifically the RDBMS) usually converts you entire statement to a single case.
    - Can enforce case-sensitivity
    - 'myTable' != mytable OR MYTABLE
      - Strings are in single quotes in SQL (at least for some or most RDBMSs).
    - Data is absolutely Case-Sensitive
      - username => 'Ryan' != 'ryan'
- Schema - Outline for one or more Database Tables.
  - Often used to set up a new copy of a database, potentially on a different machine.
- Cursor - Result Set from a Query (aka the return from a query)
- View - Virtual Table/Representation of data based on the results of a query.

---

### Sublanguages of SQL

- SQL has 5 sublanguages
  - designation for the purpose of a particular command.
  - Data Definition Language (DDL)
    - Defines the rules and structures of objects within our Database.
    - CREATE, ALTER, DROP, TRUNCATE
  - Data Manipulation Language (DML)
    - Adds, removes, or edits data in the Database.
    - INSERT, UPDATE, DELETE
  - Data Query Language (DQL)
    - For reading data from the Database
    - SELECT
  - Data Control Language (DCL)
    - Managing User permissions on the Database
    - GRANT, REVOKE
  - Transaction Control Language (TCL)
    - Management of Transaction
    - COMMIT, ROLLBACK
  
---

### Constraints

- Rules used to specify what can(not) be added into a particular column (field)
  - Not Null Key - ensures that values in the column cannot be null.
  - Unique Key - ensures that values in the column are unique (different values)
  - Check Key - Checks that data being inserted across some value (predicate)
  - Default Key - Allows you to provide a default value for your data.
  - Primary Key - Unique Identifier. Used to identify each record.
    - Combination of the Unique and Not Null Keys
      - JUST because something should be Unique and Not Null does NOT mean that it NEEDS to a Primary Key.
    - What makes a good Primary Key?
      - Unique
      - Not Null
      - Non-sensitive
      - Non-volatile  //unchanging -> has no need to change.
    - candidate key - something suitable for being used as a PK.
    - surrogate key - when we create a column solely to be our PK.
      - This is why/where we will opt to create columns like ID.
    - Almost all tables will likely have a Primary Key (PK).
    - composite key - when we use two or more columns to represent a PK.
  - Foreign Key - FK
    - Used to establish a relationship between another table with a Primary Key
      - without duplicating any redundant data.