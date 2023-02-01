using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Konsole.konsole.control;
using Konsole.konsole.utility;
using Konsole.konsole;
using Raylib_CsLo;

namespace Sternschnuppen;

public static unsafe class Program
{
    
    const string Resources = @"../../../resources";
    private static Image image;
    private static Bregion gifRegion;

    public static void Main()
    {
        image = Raylib.LoadImage(@"C:\Users\Admin\Desktop\x.gif");
        ActionHandler.Listen = Update;
        Mcd.CharSize = 10;
        ActionHandler.ZoomSpeed = 0.5f;
        ActionHandler.CameraMovementSpeed = 10;
        Mcd.Resize(1000);
        Mcd.Main();
    }

    public static void Update(Bregion bRegion)
    {
        Mcd.Resize(Mcd.CanvasW*Mcd.CanvasH);

        bRegion.Pack(Vector2.One, bRegion.Size-Vector2.One*2, x =>
        {
            gifRegion = x;
            gifRegion.FillAnimation(image, 15);
        });

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_F1))
        {
            Util.ToggleFullscreen();
        }
        
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT_SHIFT))
        {
            Mcd.Zoom += ActionHandler.ZoomSpeed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT_SHIFT))
        {
            Mcd.Zoom -= ActionHandler.ZoomSpeed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
        {
            Mcd.CameraY+=ActionHandler.CameraMovementSpeed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            Mcd.CameraY-=ActionHandler.CameraMovementSpeed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            Mcd.CameraX+=ActionHandler.CameraMovementSpeed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            Mcd.CameraX-=ActionHandler.CameraMovementSpeed;
        }
    }
    

}
