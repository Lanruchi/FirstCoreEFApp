using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.EntityMapping
{
    public class BookMap
    {
        public BookMap(EntityTypeBuilder<Book> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Name).IsRequired();
            entityTypeBuilder.Property(t => t.ISBN).IsRequired();
            entityTypeBuilder.Property(t => t.Publisher).IsRequired();
            entityTypeBuilder.HasOne(e => e.Author).WithMany(e => e.Books).HasForeignKey(e => e.AuthorId);
        }
    }
}
