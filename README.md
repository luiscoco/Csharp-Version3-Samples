# C# 3.0 Features (Visual Studio 2008, .NET 3.5)

This solution demonstrates **major features introduced in C# 3.0**.

## Projects
- **P42_Var** — Implicitly typed local variables (`var`).
- **P43_ObjectCollectionInitializers** — Object and collection initializers.
- **P44_AutoProperties** — Auto-implemented properties.
- **P45_AnonymousTypes** — Anonymous type with `new {}`.
- **P46_Lambdas** — Lambda expressions with delegates and LINQ.
- **P47_ExpressionTrees** — Expression trees with `Expression<Func<T>>`.
- **P48_ExtensionMethods** — Extension method example (`WordCount`).
- **P49_PartialMethods** — Partial methods split across partial classes.
- **P50_LINQBasic** — LINQ to objects (method syntax).
- **P51_QueryExpressions** — LINQ query syntax (SQL-like).
- **P52_LINQGrouping** — Grouping with LINQ.

## Build & Run
```bash
dotnet restore
dotnet build
dotnet run --project P42_Var
```

Targets `.NET 10.0` with `<LangVersion>3</LangVersion>` to enforce C# 3.0 syntax.
