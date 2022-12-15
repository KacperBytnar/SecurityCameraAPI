using CameraClassLibrary;

namespace SecurityCameraWebAPI.Interfaces
{
    public interface ICameraManager
    {
        public List<Camera> GetAll();
        public Camera GetById(int id);
        public Camera Add(string CameraJSON);
        public Camera Delete(int id);
    }
}
