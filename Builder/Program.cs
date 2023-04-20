using Builder.Site;
using Builder.Youtube;
using Builder.Youtube.Build;
using Builder.Youtube.Products;
using System;


//Método que chama diretamente a classe
//var mediaSocial = new MidiaSocial("Facebook");
//mediaSocial.Post("Titulo da publicação", body:$"Minha primeira publicação no {mediaSocial.RedeNome}");
//mediaSocial.Like("Publicação da Microsoft");

//var mediaSocialT = new MidiaSocial("Twitter");
//mediaSocialT.Post("Titulo da publicação", body: $"Minha primeira publicação no {mediaSocialT.RedeNome}");
//mediaSocialT.Like("Publicação da Microsoft");


////Usando builder sem o Director (Diretor)
///
//MidiaSocialBuilder builder;
//builder = new MidiaSocialFacebookBuilder();
//builder.BuildPost();
//builder.BuildLike();

///Builder usando  Director (orquestra a criaçãoo dos builders)
///
Console.WriteLine("Usando o Director");
MidiaSocialBuilder builder;

builder = new MidiaSocialFacebookBuilder();
var director = new Builder.Youtube.Director(builder);

builder = new MidiaSocialTwitterBuilder();
director = new Builder.Youtube.Director(builder);


// The client code creates a builder object, passes it to the
// director and then initiates the construction process. The end
// result is retrieved from the builder object.
var director2 = new Builder.Site.Director();
var builder2 = new ConcreteBuilder();
director2.Builder = builder2;

Console.WriteLine("Standard basic product:");
director2.BuildMinimalViableProduct();
Console.WriteLine(builder2.GetProduct().ListParts());

Console.WriteLine("Standard full featured product:");
director2.BuildFullFeaturedProduct();
Console.WriteLine(builder2.GetProduct().ListParts());

// Remember, the Builder pattern can be used without a Director
// class.
Console.WriteLine("Custom product:");
builder2.BuildPartA();
builder2.BuildPartC();
Console.Write(builder2.GetProduct().ListParts());
