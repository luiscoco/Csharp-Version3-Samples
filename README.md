# C# 3.0 Features - Sample Projects

This repository demonstrates the language features introduced in **C# version 3.0**.  
Each project (`P46` … `P56`) shows one feature with small runnable code.

---

## Features & Samples

### P46_Var - Implicitly Typed Locals
- **What’s new**: The `var` keyword lets the compiler infer the type of local variables from the initializer.  
- **Example**:
  ```csharp
  var n = 42;                 // int
  var words = new[] { "a", "b" };  // string[]
  ```
---

### P47_ObjectCollectionInitializers - Object & Collection Initializers
- **What’s new**: Initialize objects and collections more concisely inline.  
- **Example**:
  ```csharp
  var customer = new Customer { Id = 1, Name = "Ada" };
  var list = new List<int> { 1, 2, 3 };
  var dict = new Dictionary<int,string> { [1] = "one", [2] = "two" };
  ```
---

### P48_AutoProperties - Auto‑implemented Properties
- **What’s new**: Properties where the compiler provides the backing field automatically.  
- **Example**:
  ```csharp
  class Person
  {
      public string Name { get; set; }
      public int Age { get; private set; }
  }
  ```
---

### P49_AnonymousTypes - Anonymous Types
- **What’s new**: Create lightweight, unnamed types on the fly with properties.  
- **Example**:
  ```csharp
  var proj = new { Id = 7, Title = "LINQ" };
  Console.WriteLine(proj.Title);  // "LINQ"
  ```
---

### P50_Lambdas - Lambda Expressions
- **What’s new**: Inline functions for delegates/functional style.  
- **Example**:
  ```csharp
  var evens = Enumerable.Range(1, 10).Where(x => x % 2 == 0);
  ```
---

### P51_ExpressionTrees - Expression Trees
- **What’s new**: Represent code as data (expressions) which can be compiled or inspected.  
- **Example**:
  ```csharp
  Expression<Func<int, bool>> pred = x => x > 10;
  Console.WriteLine(pred.Body); // prints something like "(x > 10)"
  ```
---

### P52_ExtensionMethods - Extension Methods
- **What’s new**: Add methods to existing types without modifying the type or subclassing.  
- **Example**:
  ```csharp
  public static class StringExtensions
  {
      public static int WordCount(this string s) => s.Split(' ').Length;
  }

  Console.WriteLine("hello world".WordCount()); // 2
  ```
---

### P53_PartialMethods - Partial Methods
- **What’s new**: In partial classes, declare “hooks” that may or may not have implementations; unused ones cost nothing.  
- **Example**:
  ```csharp
  partial class Generator
  {
      partial void OnCreated();
      public void Create() { OnCreated(); }
  }

  partial class Generator
  {
      partial void OnCreated() { Console.WriteLine("Created"); }
  }
  ```
---

### P54_LINQBasic - LINQ to Objects - Method Syntax 
- **What’s new**: Use extension methods like `.Where()`, `.Select()`, etc., to query collections in a fluent style.  
- **Example**:
  ```csharp
  var top3 = numbers.Where(n => n > 10).OrderBy(n => n).Take(3);
  ```
---

### P55_QueryExpressions - LINQ Query Expressions
- **What’s new**: SQL‑like syntax for queries that map to LINQ methods under the hood.  
- **Example**:
  ```csharp
  var q = from n in numbers
          where n > 10
          orderby n
          select n;
  ```
---

### P56_LINQGrouping - LINQ Grouping
- **What’s new**: Group elements by key, then iterate groups.  
- **Example**:
  ```csharp
  var groups = from w in new[] { "ant", "ape", "bat", "bee" }
               group w by w[0] into g
               select new { Letter = g.Key, Count = g.Count() };
  ```
---

## Build & Run

From the repo root:
```bash
dotnet restore
dotnet build
dotnet run --project P42_Var
# or choose any of P43_ObjectCollectionInitializers, P44_AutoProperties, … P52_LINQGrouping
```

---

## Why These Features Mattered

- Brought LINQ to the language, enabling expressive queries over collections.  
- Reduced boilerplate: `var`, auto-properties, object initializers, anonymous types.  
- Made functional programming easier: lambdas, expression trees.  
- Extended the power of existing types via extension methods.  

