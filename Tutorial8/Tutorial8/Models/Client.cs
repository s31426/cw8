using Tutorial8.Models.DTOs;

namespace Tutorial8.Models;
using System;
using System.Collections.Generic;

public partial class Client
{
    public int IdClient { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public string Pesel { get; set; } = null!;
    
    // Odnośnik do innej klasy 
    public virtual ICollection<ClientTrip> ClientTrips { get; set; } = new List<ClientTrip>();
}