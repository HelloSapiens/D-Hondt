Console.WriteLine("D'Hondt seat allocation");

var totalSeats = 3; // Total number of seats to be allocated
var parties = new Dictionary<string, int> {
    { "Party A", 700 },
    { "Party B", 600 },
    { "Party C", 100 },
    { "Party D", 100 }
};

// Calculate seat allocation using D'Hondt method
Dictionary<string, int> seatAllocation = DHondt.CalculateDHondtSeats(parties, totalSeats);

// Display seat allocation results
foreach (var party in seatAllocation) {
    Console.WriteLine($"{party.Key}: {party.Value} seat(s)");
}