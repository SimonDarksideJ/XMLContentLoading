using System;
using Foundation;
using UIKit;

namespace XMLContentLoadingSample.iOS
{
    [Register("AppDelegate")]
    class Program : UIApplicationDelegate
    {
        private static Particle3DSampleGame game;

        internal static void RunGame()
        {
            game = new Particle3DSampleGame();
            game.Run();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            UIApplication.Main(args, null, "AppDelegate");
        }

        public override void FinishedLaunching(UIApplication app)
        {
            RunGame();
        }
    }
}
