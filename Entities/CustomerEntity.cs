namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Customer")]
    public class CustomerEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int StatusId { get; set; }
        [ForeignKey(nameof(StatusId))]
        public StatusEntity Status { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Phone { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Email { get; set; } = null!;
    }
}
