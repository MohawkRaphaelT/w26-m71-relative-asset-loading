// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Texture2D characters = Graphics.LoadTexture("C:\\Users\\000906269\\source\\repos\\w26-m71-relative-asset-loading\\assets\\graphics\\characters.gif");
        Sound sound = Audio.LoadSound("C:\\Users\\000906269\\source\\repos\\w26-m71-relative-asset-loading\\assets\\audio\\sound.wav");
        Sound target = Audio.LoadSound("C:\\Users\\000906269\\source\\repos\\w26-m71-relative-asset-loading\\assets\\audio\\target.ogg");

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Asset Load Demo");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            //
            Graphics.Draw(characters, Window.Size / 2);

            // Play 'sound'
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Q))
            {
                Audio.Play(sound);
            }
            // Play `target`
            if (Input.IsKeyboardKeyPressed(KeyboardInput.W))
            {
                Audio.Play(target);
            }
        }
    }

}
