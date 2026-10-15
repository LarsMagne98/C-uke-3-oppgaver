// Parcel first = new Parcel("MX-101", "Luna Station", 12);
// Parcel second = new Parcel("MX-102", "Crater Lab", 7);
// Parcel third = new Parcel("MX-103", "Sun Station", 15);

// Classen Parcel holder alle propertiesene, og en metode for å tildele dem verdiene.

// Jeg liker List.
// Her har jeg opprettet objektene inne i listen i stedet for
// å opprette de uten for listen for så å legge de inn i listen.
// Dette gjør det enklere å legge til nye objekter i listen for å skrive 
// de ut i konsollen.
List<Parcel> shipments = new List<Parcel>()
{
     new Parcel("MX-101", "Luna Station", 12),
     new Parcel("MX-102", "Crater Lab", 7),
     new Parcel("MX-103", "Sun Station", 15),
     new Parcel("MX-104", "Jupiter", 2),
};

foreach (var item in shipments)
{
    Console.WriteLine($"{item.TrackingCode} -> {item.Destination} ({item.Weight} kg)");
}

// Ferdig.