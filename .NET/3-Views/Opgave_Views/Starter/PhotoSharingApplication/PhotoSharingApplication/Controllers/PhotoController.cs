using PhotoSharingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoSharingApplication.Controllers
{
    [RouteValueReporter]
    public class PhotoController : Controller
    {
        private PhotoSharingContext context = new PhotoSharingContext();
        // GET: Photo
        public ActionResult Index()
        {
            return View("Index", context.Photos.ToList());
        }
        public ActionResult Display(int id)
        {
            Photo photo = context.Photos.Find(id);
            if (photo ==null)
            {
                return HttpNotFound();
            }
            return View("Display", photo);
        }
        //GET
        public ActionResult Create()
        {
            Photo newphoto = new Photo();
            newphoto.CreatedDate = DateTime.Today;
            return View("Create", newphoto);
        }
        [HttpPost]
        public ActionResult Create(Photo newPhotoData, HttpPostedFileBase image)
        {
            newPhotoData.CreatedDate = DateTime.Today;
            if (!ModelState.IsValid)
            {
                return View("Create", newPhotoData);
            }
            else
            {
                if (image !=null)
                {
                    newPhotoData.ImageMimeType = image.ContentType;
                    newPhotoData.PhotoFile = new byte[image.ContentLength]; // int[] A = new int[3] ;
                    image.InputStream.Read(newPhotoData.PhotoFile, 0, image.ContentLength);
                    context.Photos.Add(newPhotoData);
                    context.SaveChanges();
                }
               
                return RedirectToAction("Index");
            }
          }
        //Get
        public ActionResult Delete(int id)
        {
            Photo photo = context.Photos.Find(id);
            if (photo == null)
            {
                return HttpNotFound();
            }
            return View("Delete", photo);
            
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Photo photo = context.Photos.Find(id);
            context.Photos.Remove(photo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetImage(int id)
        {
            Photo photo = context.Photos.Find(id);
            if (photo !=null)
            {
                return File(photo.PhotoFile , photo.ImageMimeType);
            }
            return HttpNotFound();
        }
    }

}