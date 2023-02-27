# C# Basics


`dotnet new console --framework net6.0`

## C# vs. .NET

- C# is programming language

- .NET is a framework for building applications on Windows
    - .NET Consists of two components:
        - CLR(Common Language Runtime)
        - Class Library


## CLR (Common Language Run-time)

- Basicaly is an application thats is sitting in the memory whose job is to translate the IL code into the machine code. (Same concept of Bitecode coversion on Java)
- This procces is called Just In Time compilation (JIT)

When you compile an application, C# compiler compiles your code to IL (Intermediate Language) code. 
IL code is platform agnostics, which makes it possible to a take a C# program on a different computer with different hardware architecture and operating system and run it.
For this to happen, we need CLR. When you run a C# application, CLR compiles the IL code into the native machine code for the computer on which it is running. 
This process is called Just-in-time Compilation (JIT).


## Architecture of .NET Applications
- When you build an application with C-Sharp your application consists of building blocks called classes
- This classes colaborates with each other at runtime and as a result the application provides some functionality
- Class:
    - Is a container that has some DATA or ATTRIBUTES
    - And FUNCTIONS or METHODS
- Namespace:
    - A the number of classes in a application grows we need a way to organize this classes, thats where we use a namespace
    - Namespace is a container for related classes

- Assembly (DLL or EXE)
    - As the number o namespaces grows we need a different way of partitioning an application and thats where we use an assembly
    - Assembly is a container for related namespaces
    - Physically its a file on the disk which can either be an executable or a DLL (dinamically linked library)
    - Its a single unit of deployment of .NET applications

- When you compile an application the compiler builds on or more assemblies depending on how you partition your code


## Variables and Constants

- Variable: a name given to a storage location in memory
- Constant: an immutable value


## Operators
- Aritmetic Operators
- Comparison Operators
- Assignment Operators
- Logical Operators
- Bitwise Operators

