using CommunityToolkit.Mvvm.Messaging.Messages;
using VtaAlf.Dto;

namespace VtaAlf.Fll
{
    // All the code in this file is included in all platforms.
    public static class ConexionFll
    {
        public static string ConexionString(string NombreBaseDatos)
        {
            string conexionString = string.Empty;

            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                conexionString = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                conexionString = Path.Combine(conexionString, NombreBaseDatos);
            }
            else if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                conexionString = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                conexionString = Path.Combine(conexionString,"..","Library", NombreBaseDatos);
            }
            return conexionString;
        }
    }
     public class AlfajorMensaje
    {
        public bool Crear { get; set; }
        public AlfajorDto AlfajorDto { get; set; }
    }

    public class AlfajorMensajeria : ValueChangedMessage<AlfajorMensaje>
    {
        public AlfajorMensajeria(AlfajorMensaje value):base(value)
        {
            
        }
    }
}
 