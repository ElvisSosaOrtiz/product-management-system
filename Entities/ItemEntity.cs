namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Item")]
    public class ItemEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public ItemCategoryEntity Category { get; set; } = null!;

        [Required]
        public int StatusId { get; set; }
        [ForeignKey(nameof(StatusId))]
        public StatusEntity Status { get; set; } = null!;

        [Required]
        [StringLength(250)]
        public string Description { get; set; } = null!;

        [Required]
        [DataType(DataType.Currency)]
        public double DefaultPrice { get; set; }
    }
}
