using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlataformasOnlines_MEJG.Models
{
    public class BooksModel
    {
        public class VolumeInfo
        {
            public string Title { get; set; }
            public List<string> Authors { get; set; }
            public string Publisher { get; set; }
        }

        // Clase para los libros individuales
        public class BookItem
        {
            public VolumeInfo VolumeInfo { get; set; }
        }

        // Clase para la respuesta de Google Books
        public class GoogleBooksResponse
        {
            public List<BookItem> Items { get; set; }
        }

    }
}