using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace PhotoSharingApplication.Models
{
    public class PhotoSharingInitializer : CreateDatabaseIfNotExists<PhotoSharingContext>
    {
        //This gets a byte array for a file at the path specified
        //The path is relative to the route of the web site
        //It is used to seed images
        private byte[] getFileBytes(string path)
        {
            FileStream fileOnDisk = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);
            byte[] fileBytes;
            using (BinaryReader br = new BinaryReader(fileOnDisk))
            {
                fileBytes = br.ReadBytes((int)fileOnDisk.Length);
            }
            return fileBytes;
        }

        protected override void Seed(PhotoSharingContext context)
        {
            base.Seed(context);
            var photos = new List<Photo>
            {
                new Photo {
                    Title = "Test Photo",
                    Description = "Det er et billedet som jeg har ikke set mang gang",
                    UserName = "NaokiSato",
                    PhotoFile = getFileBytes("\\Images\\flower.jpg"), 
                    ImageMimeType = "image/jpeg",
                    CreatedDate= DateTime.Today
                }
            };

            photos.ForEach(s => context.Photos.Add(s));
            context.SaveChanges();

            var comments = new List<Comment>
            {
                new Comment {
                    PhotoID = 1,
                    UserName = "NaokiSato",
                    Subject = "Det er et Test billedet", 
                    Body = "Denne komment skal vises under billedet"+ "billedet"
                    
                }
            };

            comments.ForEach(s => context.Comments.Add(s));
            context.SaveChanges();
        }
    }
}