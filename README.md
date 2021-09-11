# BaseEntity ![.NET Core](https://github.com/leo-oliveira-eng/BaseEntity/workflows/.NET%20Core/badge.svg) [![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.md) [![NuGet](https://img.shields.io/nuget/vpre/BaseEntity.Domain)](https://www.nuget.org/packages/BaseEntity.Domain) [![codecov](https://codecov.io/gh/leo-oliveira-eng/BaseEntity/branch/master/graph/badge.svg?token=JH0QL5OG6K)](https://codecov.io/gh/leo-oliveira-eng/BaseEntity) [![CodeQL](https://github.com/leo-oliveira-eng/BaseEntity/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/leo-oliveira-eng/BaseEntity/actions/workflows/codeql-analysis.yml)

Package to make easier the creation of entities by encapsulating basic properties and methods

## Installation

BaseEntity is available on [NuGet](https://www.nuget.org/packages/BaseEntity.Domain/).  You can find the raw NuGet file [here](https://www.nuget.org/api/v2/package/BaseEntity.Domain/1.0.0-pre-1) or install it by the commands below depending on your platform:

 - Package Manager
```
pm> Install-Package BaseEntity.Domain -Version 1.0.0-pre-1
```

 - via the .NET Core CLI:
```
> dotnet add package BaseEntity.Domain --version 1.0.0-pre-1
```

 - PackageReference
```
<PackageReference Include="BaseEntity.Domain" Version="1.0.0-pre-1" />
```

 - PaketCLI
```
> paket add BaseEntity.Domain --version 1.0.0-pre-1
```

## Setup

There is no need for configuration or dependency injection.


## How to Use

Just make your model class inherit from the Entity class. It is necessary to create an empty constructor for your class because it is used by the Entity Framework. The base constructor of the class receives a Guid, providing a unique identification for each record. 
Your class also inherit the CreatedAt, LastUpdate and DeletedAt properties, with the idea that soft delete will be your choice.

```csharp

using BaseEntity.Domain.Entities;
using System;

namespace 
{
    public class Student : Entity
    {
        #region properties 
        
        ...

        public string Name { get; private set; }

        public DateTime BirthDate { get; private set; }

        public CPF Cpf { get; private set; }

        ...        

	    #endregion

        #region Constructors

        [Obsolete(ConstructorObsoleteMessage), false]
        Student() { }

        public Student(string name, DateTime birthDate, CPF cpf)
            : base(Guid.NewGuid())
        {
            Name = name;
            BirthDate = birthDate;
            Cpf = cpf;
        }

        #endregion
    }
}


```


## License [![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fleo-oliveira-eng%2FBaseEntity.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Fleo-oliveira-eng%2FBaseEntity?ref=badge_shield)

The project is under MIT License, so it grants you permission to use, copy, and modify a piece of this software free of charge, as is, without restriction or warranty.

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fleo-oliveira-eng%2FBaseEntity.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Fleo-oliveira-eng%2FBaseEntity?ref=badge_large)
