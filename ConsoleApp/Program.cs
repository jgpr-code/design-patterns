Console.WriteLine("Hello, Design Patterns");

// The Gang of Four Design Patterns https://en.wikipedia.org/wiki/Design_Patterns

// Creational

// Abstract factory groups object factories that have a common theme.
// Builder constructs complex objects by separating construction and representation.
// Factory method creates objects without specifying the exact class to create.
// Prototype creates objects by cloning an existing object.
// Singleton restricts object creation for a class to only one instance.

// Structural

// Adapter allows classes with incompatible interfaces to work together by wrapping its own interface around that of an already existing class.
// Bridge decouples an abstraction from its implementation so that the two can vary independently.
// Composite composes zero-or-more similar objects so that they can be manipulated as one object.
// Decorator dynamically adds/overrides behaviour in an existing method of an object.
// Facade provides a simplified interface to a large body of code.
// Flyweight reduces the cost of creating and manipulating a large number of similar objects.
// Proxy provides a placeholder for another object to control access, reduce cost, and reduce complexity.

// Behavioral

// Chain of responsibility delegates commands to a chain of processing objects.
// Command creates objects that encapsulate actions and parameters.
// Interpreter implements a specialized language.
// Iterator accesses the elements of an object sequentially without exposing its underlying representation.
// Mediator allows loose coupling between classes by being the only class that has detailed knowledge of their methods.
// Memento provides the ability to restore an object to its previous state (undo).
// Observer is a publish / subscribe pattern, which allows a number of observer objects to see an event.
// State allows an object to alter its behavior when its internal state changes.
// Strategy allows one of a family of algorithms to be selected on-the-fly at runtime.
// Template method defines the skeleton of an algorithm as an abstract class, allowing its subclasses to provide concrete behavior.
// Visitor separates an algorithm from an object structure by moving the hierarchy of methods into one object.

// Further Design Patterns listed in Wikipedia https://en.wikipedia.org/wiki/Software_design_pattern

// Creational

// Dependency Injection A class accepts the objects it requires from an injector instead of creating the objects directly.
// Lazy Initialization 	Tactic of delaying the creation of an object, the calculation of a value, or some other expensive process until the first time it is needed. This pattern appears in the GoF catalog as "virtual proxy", an implementation strategy for the Proxy pattern.
// Multiton Ensure a class has only named instances, and provide a global point of access to them.
// Object Pool Avoid expensive acquisition and release of resources by recycling objects that are no longer in use. Can be considered a generalisation of connection pool and thread pool patterns.
// RAII Ensure that resources are properly released by tying them to the lifespan of suitable objects.

// Structural

// Extension Object Adding functionality to a hierarchy without changing the hierarchy.
// Front Controller The pattern relates to the design of Web applications. It provides a centralized entry point for handling requests.
// Marker Empty interface to associate metadata with a class.
// Module Group several related elements, such as classes, singletons, methods, globally used, into a single conceptual entity.
// Twin Twin allows modeling of multiple inheritance in programming languages that do not support this feature.

// Behavioral

// Blackboard Artificial intelligence pattern for combining disparate sources of data (see blackboard system)
// Null Object Avoid null references by providing a default object.
// Servant Define common functionality for a group of classes. The servant pattern is also frequently called helper class or utility class implementation for a given set of classes. The helper classes generally have no objects hence they have all static methods that act upon different kinds of class objects.
// Specification Recombinable business logic in a Boolean fashion.
// Fluent Interface Design an API to be method chained so that it reads like a DSL. Each method call returns a context through which the next logical method call(s) are made available.

// Concurrency Patterns

// Maybe also interesting read: https://en.wikipedia.org/wiki/Expression_problem

