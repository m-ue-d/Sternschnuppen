using System.Numerics;
using Konsole.konsole.control;
using Konsole.konsole.utility;
using Konsole.konsole;
using Raylib_CsLo;

namespace Sternschnuppen;

public static class Program
{
    
    const string Resources = @"../../../resources";

    public static void Main()
    {
        ActionHandler.Listen = Update;
        Mcd.CharSize = 15;
        Mcd.Resize(1000);
        Mcd.Main();
    }

    public static void Update(Bregion bRegion)
    {
        Mcd.Resize(Mcd.CanvasW*Mcd.CanvasH);    //TODO: Make it work without resizing
        
        bRegion.FillColor('Y', Raylib.RED);
        bRegion.Pack(Vector2.One, bRegion.Size - Vector2.One*2, region2 =>
        {
            region2.FillColor('X',Raylib.WHITE);
        });
        
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_F1))
        {
            Util.ToggleFullscreen();
        }
        
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT_SHIFT))
        {
            Mcd.Zoom += ActionHandler.ZoomSpeed;
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT_SHIFT))
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
