# Challenge: The Family Dictionary

### Setup

```
mkdir -p ~/workspace/csharp/exercises/family_dictionary && cd $_
dotnet new console -n FamilyDictionary -o .
```

Oh, the Glory Days of JavaScript, when creating an object that contains another object was as simple as this.

```js
const myFamily = {
  sister: {
    name: "Krista",
    age: 42
  },
  mother: {
    name: "Cathie",
    age: 70
  }
};
```

Well, those days are over while you learn C#. Below you will see an example of how you will do that with a Dictionary.

### Instructions

1. Define a Dictionary that contains information about several members of your family. Use the following example as a template.

   ```cs
   Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

   myFamily.Add("sister", new Dictionary<string, string>(){
       {"name", "Krista"},
       {"age", "42"}
   });
   ```

2. Next, iterate over each item in `myFamily` and produce the following output. Remember that you can use square bracket notation to get to the value of a key, and that a dictionary has a `Key` and a `Value` property.

   ```cs
   foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
   {
       ... your code here
   }
   ```

   ```sh
   Krista is my sister and is 42 years old
   ```
