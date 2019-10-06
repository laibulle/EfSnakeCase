# EfSnakeCase

## Getting started

```bash

```

```F#
open EfSnakeCase.Core

type MyDataContext(options) =
   inherit Microsoft.EntityFrameworkCore.DbContext(options)
   
   override __.OnModelCreating(builder) =
      base.OnModelCreating(builder)
      ToSnakeCase(builder)
```