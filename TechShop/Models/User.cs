﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id {  get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name of banch can't exceed 100 characters")]
        public string? Name { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name of banch can't exceed 50 characters")]
        public string? Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Name of banch can't exceed 100 characters")]
        public string? Address { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Name of banch can't exceed 10 characters")]
        public string? PhoneNumber { get; set; }
        [Required]
        public Boolean? role {  get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Name of banch can't exceed 50 characters")]
        public string? Password { get; set; }

    }
}
