### Uno/Dos - Step 2

As the overview page mentioned, this model is pretty straightforward.  There are three static classes
(`AuthorizationLevel`, `CommentStatus`, and `PostStatus`) to keep us from using magic strings in the code.  The objects
that will actually be stored in the database are `Category`, `Comment`, `Page`, `Post`, `User`, and `WebLog`.
`Revision` and `Authorization` give structure to the collections stored within other objects (`Page`/`Post` and
`User`, respectively).

To support the `JsonProperty` attribute, we'll need to add a reference to JSON.Net; this goes in the `.csproj` file, in
the `ItemGroup` with dependencies:

    [lang=text]
    <PackageReference Include="Newtonsoft.Json" Version="10.*" />

If you're reading through this for learning, you'll want to familiarize yourself with the
[files as they are in C# at this step](https://github.com/danieljsummers/FromObjectsToFunctions/tree/step-2-core2/src/1-AspNetCore-CSharp/Entities)
before continuing to [Tres](tres.html) and [Quatro](quatro.html).

[Back to Step 2](../step2)