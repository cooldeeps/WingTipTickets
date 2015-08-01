﻿using System;

namespace Tenant.Mvc.Models
{
    public class ConcertSearchHit
    {
        public string ConcertId { get; set; }

        public string ConcertName { get; set; }

        public DateTimeOffset ConcertDate { get; set; }

        public int VenueId { get; set; }

        public string VenueName { get; set; }

        public string VenueCity { get; set; }

        public string VenueState { get; set; }

        public string VenueCountry { get; set; }

        public int PerformerId { get; set; }

        public string PerformerName { get; set; }

        public string FullTitle { get; set; }
    }
}