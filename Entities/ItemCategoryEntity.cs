namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ItemCategory")]
    public class ItemCategoryEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public char Name { get; set; }
    }
}
