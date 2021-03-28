# RentACar

RentACar is a **C# Solution** for dealing with **C#** fundamentals and **Secured Web Api Development (JWT).** 

It's developed on **Microsoft SQL Server** and **Asp.net Core Framework (5.0)**


## Features
Let's talk about the **plug and play architecture** and **core components** on this **flexible** and **sustainable** and **powerful** architecture.

#### 1. Aspect Oriented Programming

You can use the aspects for;
- **Cache** and **Remove Cache**. If you want to cache something with unique key basically just call the aspect below.

- Role Based **Secured operations**.
- **Validation**
- **Transactions**
- **Performance**

You can see the example for aspects 

```c
[ValidationAspect(typeof(CarValidator))]
[SecuredOperation("car.add")]
[CacheRemoveAspect("ICarService.Get")]
[TransactionScopeAspect]
[PerformanceAspect(3)]
public IResult DoSomething(SomeEntity someEntity)
{
   // Your code 
}
```

#### 2. Powerful OOP Examples

It contains powerful OOP examples which that are used on right time and right place which that are;
 - Encapsulation
 - Inheritance
 - Polymorphism
 - Abstraction

For example just look at the `Core/DataAccess/IEntityRepository.cs` file. It contains all basic CRUD operations for you don't write those operations over and over again.

## Installation

If you want to run this project on locally you have to be sure about your machine already configured for run **Microsoft SQL Server** and **Asp.net Core Framework (5.0)**

 - Configure your db credentials on DataAccess/Concrete/EntityFramework/ReCapContext.cs
 - Migrate your database like this documentation `https://docs.microsoft.com/tr-tr/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli#create-your-database-and-schema`

When you build the Solution and run the **WebAPI Project** it will open automatically the **Swagger UI.** 

So you can see the all **endpoints** and **necessary parameters** on Swagger IU. 

For that reason I will not give any information about endpoints. 

![swagger ui](https://github.com/cagatayy94/RentACar/blob/main//WebAPI/wwwroot/images/swagger.png?raw=true)

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Feel free to give me a star thanks! :)
