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