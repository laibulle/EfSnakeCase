# EfSnakeCase

## Getting started

__Install package__
```bash
dotnet add package EfSnakeCase
```

__C# usage__

```C#
using Microsoft.EntityFrameworkCore;
using static EfSnakeCase.Core;

namespace MyApplication.Database
{
    public class MyDataContext : DbContext
    {
        public MyDataContext(DbContextOptions<CoreContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ToSnakeCase(modelBuilder);
        }
    }
}
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
