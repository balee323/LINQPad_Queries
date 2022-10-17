<Query Kind="Expression" />

/*
Notes on code architectures

Database-centric Architecture:
Old architecture models focused on having the database in the middle.  All other layers would then point towards the database.

Other models have the database as an implementation detail or a datalayer.


Domain-centric Architecture:
The database is outside of the circle and is viewed as an implemenation detail. 
1. Hexagonal Architecture -> plug in architecture
2. Onion Architecture
3. Clean Architecture

Pros:
-focus on domain
-less coupling
-allows for domain driven design (domain modeling practicies)

Cons:
-change is difficult
-requires more thought
-initial higher cost


Clean Architecture:
-All dependencies (and project references) point inward towards the domain.

Functional Cohesion:
-organize our Folders, classes, namespaces by a concept called "functional cohesion".
-Aggregate stuff based on key entities.

The classic 3-Layer architecture:
UI, Business Logic, and Data Access -> works fine with simple CRUD apps

Modern, Domain-centric layer:
Presentation, Application, Domain, Infrastructure, and Cross-Cutting Concerns

Application Layer: Implements use cases.

-Dependency Inversion:
-Details should depend on abstractions
-Inversion of control pattern
-last responsible moment

Why use an Application Layer?
Pros:
-Focus on use cases
-Easy to understand
-Follows DIP (dependency Inversion Principle (principal is headmaster of a school)

Cons:
-Additional layer cost
-Requires extra thought
-IoC (Inversion of Control) is counter-intuitive

Demo:
The interfaces folder has all the interfaces required for all the external dependencies.
For instance, there is an interface for the persistance layer.  It's up the persistance layer
to implement these abstractions.


Command/Query separation:

Commands:
-do something
-modify data
-should not return a value

Query:
-Answers a question
-does not modify data
-does return a value









*/