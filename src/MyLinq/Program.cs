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
                new Image { DocumentId = 1 },
                new Image { DocumentId = 1 },
                new Image { DocumentId = 2 },
                new Image { DocumentId = 2 },
            };


            var query =
                from document in documents
                join image in images on document.Id equals image.DocumentId into imgs
                select new
                {
                    Images = imgs
                };


            foreach (var item in query)
            {
                Console.WriteLine(item.Images.Count());
            }
        }
    }
}
