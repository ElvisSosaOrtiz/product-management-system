namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CustomerItem")]
    public class CustomerItemEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public CustomerEntity Customer { get; set; } = null!;

        [Required]
        public int ItemId { get; set; }
        [ForeignKey(nameof(ItemId))]
        public ItemEntity Item { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }
    }
}
