using System;
using System.Linq;

namespace MyLinq
{
    class Document
    {
        public int Id { set; get; }
    }

    class Image
    {
        public double DocumentId { set; get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var documents = new[] {
                new Document { Id = 1 },
                new Document { Id = 2 },
            };

            var images = new[] {
                new Image { DocumentId = 1.0 },
                new Image { DocumentId = 1.0 },
                new Image { DocumentId = 2.0 },
                new Image { DocumentId = 2.0 },
                new Image { DocumentId = 2.0 },
            };


            var query =
                from document in documents
                join image in images on document.Id equals image.DocumentId into imgs
                where document.Id > 0
                orderby document.Id
                select new
                {
                    Document = document,
                    Images = imgs
                };


            foreach (var item in query)
            {
                Console.WriteLine("Document {0}", item.Document.Id);
                Console.WriteLine("-- Images {0}", item.Images.Count());
            }
        }
    }
}
