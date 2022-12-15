using CameraClassLibrary;
using SecurityCameraWebAPI.Interfaces;
using System.Drawing;
using System.Runtime.ConstrainedExecution;


namespace SecurityCameraWebAPI.Managers
{
    public class CameraManager : ICameraManager
    {
        private static int _nextId = 1;
        private static readonly List<Camera> Data = new List<Camera>
        {
            new Camera {Id = 1, PictureId= _nextId++, Date=DateTime.Now, Picture= File.ReadAllBytes("C:\\Users\\Acer\\Desktop\\SecurityCamera\\SecurityCameraWebAPI\\Managers\\ParkerMo.jpeg"), FileType = "jpeg", Name ="SecurityCameraSnap1"},
            new Camera {Id = 1, PictureId= _nextId++, Date=DateTime.Today, Picture= File.ReadAllBytes("C:\\Users\\Acer\\Desktop\\SecurityCamera\\SecurityCameraWebAPI\\Managers\\avatar7.png"), FileType = "jpeg", Name ="SecurityCameraSnap2"},
            new Camera {Id = 1, PictureId= 9999, Date=DateTime.Today, Picture= File.ReadAllBytes("C:\\Users\\Acer\\Desktop\\SecurityCamera\\SecurityCameraWebAPI\\Managers\\NoConnection.png"), FileType = "jpeg", Name ="No connection to the database!!"},


        };


        
        public List<Camera> GetAll()
        {

        return new List<Camera>(Data);
        }

        public Camera GetById(int id)
        {
            return Data.Find(Camera => Camera.PictureId == id);
        }

        public Camera Add(Camera newCamera)
        {
            newCamera.Id = _nextId++;
            Data.Add(newCamera);
            return newCamera;
        }

        public Camera Delete(int id)
        {
            Camera Camera = Data.Find(Camera1 => Camera1.Id == id);
            if (Camera == null) return null;
            Data.Remove(Camera);
            return Camera;
        }

        public Camera Add(string CameraJSON)
        {
            throw new NotImplementedException();
        }

        //public Camera Update(int id, Camera updates)
        //{
        //    //Camera Camera = Data.Find(Camera1 => Camera1.Id == id);
        //    //if (Camera == null) return null;
        //    //Camera.Height = updates.Height;
        //    //Camera.Species = updates.Species;
        //    //Camera.Color = updates.Color;
        //    //return Camera;
        //}
    }
    }

