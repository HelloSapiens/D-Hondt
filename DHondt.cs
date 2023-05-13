public static class DHondt {
    public static Dictionary<string, int> CalculateDHondtSeats(Dictionary<string, int> parties, int totalSeats) {
        // Create a copy of the original dictionary to track remaining votes
        var remainingVotes = new Dictionary<string, int>(parties);

        // Create a dictionary to track the allocated seats for each party
        var seatAllocation = new Dictionary<string, int>();

        // Loop until all seats are allocated
        while (totalSeats > 0)
        {
            // Find the party with the highest quotient (votes / seats + 1)
            string winningParty = remainingVotes.OrderByDescending(p => p.Value / (seatAllocation.GetValueOrDefault(p.Key) + 1)).First().Key;

            // Allocate a seat to the winning party
            seatAllocation.TryGetValue(winningParty, out int allocatedSeats);
            seatAllocation[winningParty] = allocatedSeats + 1;

            // Update the remaining votes for the winning party
            remainingVotes[winningParty] = parties[winningParty] / (allocatedSeats + 1);

            totalSeats--;
        }

        return seatAllocation;
    }
}
