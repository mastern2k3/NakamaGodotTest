using Godot;
using System;

public class main2 : Node2D
{
    // Member variables here, example:
    // private int a = 2;
    // private string b = "textvar";

    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        GD.Print("gay stuff");

        try
        {
            var client = new Nakama.Client("defaultkey", "localhost", 7350, true) {
                Timeout = 10000, // set timeout on requests (default is 5000).
                Retries = 5      // set retries on requests (default is 3).
            };
            GD.Print("gay stuff");
            var auth = client.AuthenticateEmailAsync("nitzan.zada@gmail.com", "lolpwd").Result;

            GD.Print("auth", auth.Username);
        }
        catch (System.Exception e)
        {
            GD.Print("err", e.ToString());
        }
    }

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}
