using System.Collections.Generic;

namespace WebShop.Data.Entities.Catalog
{
    public class PublisherDetailsEntity : PublisherEntity
    {
        public IEnumerable<BookEntity> Books { get; set; }
    }
}