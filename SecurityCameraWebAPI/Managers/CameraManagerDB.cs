using CameraClassLibrary;
using SecurityCameraWebAPI.DBContext;
using SecurityCameraWebAPI.Interfaces;
using System.Collections.Generic;

namespace SecurityCameraWebAPI.Managers
{
    public class CameraManagerDB : ICameraManager
    {
        private CameraContext _context;

        public CameraManagerDB(CameraContext context)
        {
            _context = context;
        }

        public Camera Add(string CameraJSON)
        {
            Camera newCameraObject= Newtonsoft.Json.JsonConvert.DeserializeObject<Camera>(CameraJSON);

            newCameraObject.Id = 0;
            _context.Cameras.Add(newCameraObject);
            _context.SaveChanges();
            return newCameraObject;
        }

        public Camera? Delete(int Id)
        {
            Camera? foundCamera = GetById(Id);

            if (foundCamera != null)
            {
                _context.Cameras.Remove(foundCamera);
                _context.SaveChanges();
            }
            return foundCamera;
        }

        public List<Camera> GetAll()
        {
            return _context.Cameras.ToList();
        }

        public Camera? GetById(int Id)
        {
            return _context.Cameras.FirstOrDefault(camera => camera.Id == Id);
        }

    }
}
