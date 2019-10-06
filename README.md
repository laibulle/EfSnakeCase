# EfSnakeCase

## Getting started

__Install package__
```bash
dotnet add package EfSnakeCase
```

__F# usage__
```F#
open EfSnakeCase.Core

type MyDataContext(options) =
   inherit Microsoft.EntityFrameworkCore.DbContext(options)
   
   override __.OnModelCreating(builder) =
      base.OnModelCreating(builder)
      ToSnakeCase(builder)
```