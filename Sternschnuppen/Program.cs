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
        InputHandler.Listen = Update;
        Mcd.CharSize = 15;
        Mcd.Main();
    }

    public static void Update(Einpacker packer)
    {
        // packer:
        // start: 0, 0
        // size:  20, 10
        
        //Console.WriteLine($"{Mcd.CanvasW}, {Mcd.CanvasH}, {packer.Size}");
        
        //do something on frame-update
        string[] lines = File.ReadAllLines($"{Resources}/scenes/presets/gamePane.txt");
        string text = String.Join('\n', lines);

        packer.FüllenMit('Y', Raylib.RED);
        packer.Einpacken(Vector2.One, packer.Size-Vector2.One, packer =>
        {
            packer.FüllenMit('X',Raylib.LIGHTGRAY);
        });
        packer.SetzeBei(new Vector2(0,0), 'A', Raylib.WHITE);
        packer.SetzeBei(new Vector2(1,0), 'B', Raylib.WHITE);
        packer.SetzeBei(new Vector2(2,0), 'C', Raylib.WHITE);
        packer.SetzeBei(new Vector2(3,0), 'D', Raylib.WHITE);
        packer.SetzeBei(new Vector2(4,0), 'E', Raylib.WHITE);
        packer.SetzeBei(new Vector2(5,0), 'F', Raylib.WHITE);
        packer.SetzeBei(new Vector2(6,0), 'G', Raylib.WHITE);
        packer.SetzeBei(new Vector2(7,0), 'H', Raylib.WHITE);
        packer.SetzeBei(new Vector2(0,1), 'I', Raylib.WHITE);
        packer.SetzeBei(new Vector2(1,1), 'J', Raylib.WHITE);
        packer.SetzeBei(new Vector2(2,1), 'K', Raylib.WHITE);
        packer.SetzeBei(new Vector2(3,1), 'L', Raylib.WHITE);
        packer.SetzeBei(new Vector2(4,1), 'M', Raylib.WHITE);
        packer.SetzeBei(new Vector2(5,1), 'N', Raylib.WHITE);
        packer.SetzeBei(new Vector2(6,1), 'O', Raylib.WHITE);
        packer.SetzeBei(new Vector2(7,1), 'P', Raylib.WHITE);
        packer.SetzeBei(new Vector2(0,2), 'Q', Raylib.WHITE);
        packer.SetzeBei(new Vector2(1,2), 'R', Raylib.WHITE);
        packer.SetzeBei(new Vector2(2,2), 'S', Raylib.WHITE);
        packer.SetzeBei(new Vector2(3,2), 'T', Raylib.WHITE);
        packer.SetzeBei(new Vector2(4,2), 'U', Raylib.WHITE);
        packer.SetzeBei(new Vector2(5,2), 'V', Raylib.WHITE);
        packer.SetzeBei(new Vector2(6,2), 'W', Raylib.WHITE);
        packer.SetzeBei(new Vector2(7,2), 'X', Raylib.WHITE);
        /*
        Console.WriteLine((packer.Size-new Vector2(1,1)).X+"    "+(packer.Size-new Vector2(1,1)).Y);
        packer.SetzeBei(packer.Size-new Vector2(1,1), 'Y', Raylib.GOLD);

        packer.Einpacken(Vector2.One, packer.Size-Vector2.One, packer =>
        {
            packer.FüllenMit('X',Raylib.GOLD);
        });
        */
    
    }
    

}