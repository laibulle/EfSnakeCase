namespace EfSnakeCase

open Microsoft.EntityFrameworkCore
open System.Text.RegularExpressions
open System.Runtime.CompilerServices

[<Extension>]
type StringExtensions () =
    [<Extension>]
    static member ToSnakeCase(input : string) =
        match input with
            | null -> input
            | "" -> input
            | _ ->
                let startUnderscores = Regex.Match(input, @"^_+");
                startUnderscores.ToString() + Regex.Replace(input, @"([a-z0-9])([A-Z])", "$1_$2").ToLower();
                
module Core =
    let ToSnakeCase (builder: ModelBuilder) =
        for entity in builder.Model.GetEntityTypes() do
            entity.SetTableName(entity.GetTableName().ToSnakeCase())
            
            for property in entity.GetProperties() do
              property.SetColumnName(property.GetColumnName().ToSnakeCase())
             
            for key in entity.GetKeys() do
                key.SetName(key.GetName().ToSnakeCase())
             
            for key in entity.GetForeignKeys() do
                key.SetConstraintName(key.GetConstraintName())
             
            for key in entity.GetIndexes() do
                key.SetName(key.GetName())