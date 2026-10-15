// Parcel first = new Parcel("MX-101", "Luna Station", 12);
// Parcel second = new Parcel("MX-102", "Crater Lab", 7);
// Parcel third = new Parcel("MX-103", "Sun Station", 15);

// Jeg liker List.
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