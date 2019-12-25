using System;
using System.ComponentModel.DataAnnotations;

namespace FeatureTryout.Models
{
    public class Note
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime LastModifiedTime { get; set; }
        [Required]
        public string Content { get; set; }
    }
}