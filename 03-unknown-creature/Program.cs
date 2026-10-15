// En klasse med objekter. koden i klassen bestemmer hvilke properties objektene skal kunne få.
Creature first = new Creature();
Creature second = new Creature();
Creature third = new Creature();

// Jeg har gitt propertiesene til objetene forskjellige values.
first.Name = "Pusn";
first.Species = "Wolf";
first.Energy = 100;

second.Name = "Hans";
second.Species = "Cat";
second.Energy = 100;

third.Name = "Grete";
third.Species = "Bear";
third.Energy = 200;

// Her legger jeg alle objektene til i en liste.
List<Creature> creatues = new List<Creature>() { first, second, third };
// Her er en fin liten table av de forskjellige objektene.
Console.WriteLine($"| {"NAME",-7} | {"SPECIES",-7} | {"ENERGY",-7} |");
foreach (var creature in creatues)
{
    Console.WriteLine($"| {creature.Name,-7} | {creature.Species,-7} | {creature.Energy,-7} |");
}

// Tror jeg sporet litt av med denne og lærte en del om List i stedet.
// Ferdig.