﻿using System.ComponentModel.DataAnnotations;

namespace SolarCompanyWebsite.Models
{
    public class AppointmentData
    {
        public List<Appointment> AppointmentList { get; set; } = new List<Appointment>();

    }

    // Individual appointment class
    
public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        
        public string PurchasePreference { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; } = DateTime.Today.AddDays(1);// The date of the appointment



        public TimeSpan AvailableFrom { get; set; } = new TimeSpan(9, 0, 0); // The time when the customer is free from

        
        public TimeSpan AvailableUntil { get; set; } = new TimeSpan(17, 0, 0); // The time until the customer is free


        public bool IsBooked { get; set; } = false;// Status of the appointment: true if booked, false if available

        [Required]
        public bool IsPrimaryHouse { get; set; } = true; // Indicates if this is their primary house

        [StringLength(500)]
        public string Details { get; set; } // Additional details for the appointment
    }
}
