using Android.App;
using Android.OS;
using Android.Content.PM;

using Stride.Engine;
using Stride.Starter;

namespace MyGame
{
    [Activity(MainLauncher = true, 
              Icon = "@mipmap/gameicon", 
              ScreenOrientation = ScreenOrientation.Landscape,
              Theme = "@android:style/Theme.NoTitleBar",
              ConfigurationChanges = ConfigChanges.UiMode | ConfigChanges.Orientation | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize)]
    public class MyGameActivity : StrideActivity
    {
        protected Game Game;

        protected override void OnRun()
        {
            base.OnRun();

            Game = new Game();
            Game.Run(GameContext);
        }

        protected override void OnDestroy()
        {
            Game.Dispose();

            base.OnDestroy();
        }
    }
}
