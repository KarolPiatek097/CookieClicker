using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace CookieClicker
{
    class Program
    {
        static void Main(string[] args)
        {
            var window = new RenderWindow(new VideoMode(1920, 1080), "Cookie clicker", Styles.Default);
            window.SetFramerateLimit(60);
            Cookie cookie = new Cookie();
            GameInterface gameInterface = new GameInterface();
            
            #region events
            window.Closed += (s,a) => window.Close();
            window.MouseButtonPressed += (s, a) => cookie.isInside(a.X, a.Y);
            window.MouseButtonReleased += (s, a) => cookie.isInside2(a.X, a.Y);
            window.MouseButtonPressed += (s, a) => gameInterface.isInside(a.X, a.Y, ref cookie.cookies);
            #endregion

            //Game loop
            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear();
                draw();
                convertDataToString();

                #region game time
                gameInterface.frameCounter++;
                if(gameInterface.frameCounter==60)
                {
                    gameInterface.gameTime++;
                    cookie.cookies += gameInterface.cookiesPerSec;

                    gameInterface.frameCounter = 0;
                }
                #endregion

                Console.WriteLine(gameInterface.gameTime);

                window.Display();
            }

            void draw()
            {
                window.Draw(cookie.cookie);
                //window.Draw(gameInterface.timer);

                window.Draw(gameInterface.cookieAmount);
                window.Draw(gameInterface.cookieCounter);
                window.Draw(gameInterface.perSec);
                window.Draw(gameInterface.perSecAmount);

                window.Draw(gameInterface.ClickBooster);
                window.Draw(gameInterface.ClickBooster1);
                window.Draw(gameInterface.ClickBooster2);
                window.Draw(gameInterface.ClickBooster3);
                window.Draw(gameInterface.ClickBooster4);
                window.Draw(gameInterface.ClickBooster5);

                window.Draw(gameInterface.boost);
                window.Draw(gameInterface.boost1);
                window.Draw(gameInterface.boost2);
                window.Draw(gameInterface.boost3);
                window.Draw(gameInterface.boost4);
                window.Draw(gameInterface.boost5);

                window.Draw(gameInterface.boostamount);
                window.Draw(gameInterface.boost1amount);
                window.Draw(gameInterface.boost2amount);
                window.Draw(gameInterface.boost3amount);
                window.Draw(gameInterface.boost4amount);
                window.Draw(gameInterface.boost5amount);

                window.Draw(gameInterface.boostprice);
                window.Draw(gameInterface.boost1price);
                window.Draw(gameInterface.boost2price);
                window.Draw(gameInterface.boost3price);
                window.Draw(gameInterface.boost4price);
                window.Draw(gameInterface.boost5price);
            }
            void convertDataToString()
            {
                gameInterface.cookieCounter.DisplayedString = Convert.ToString(cookie.cookies);
                gameInterface.perSecAmount.DisplayedString = Convert.ToString(gameInterface.cookiesPerSec);

                gameInterface.boostamount.DisplayedString = Convert.ToString(gameInterface.boost_amount);
                gameInterface.boost1amount.DisplayedString = Convert.ToString(gameInterface.boost1_amount);
                gameInterface.boost2amount.DisplayedString = Convert.ToString(gameInterface.boost2_amount);
                gameInterface.boost3amount.DisplayedString = Convert.ToString(gameInterface.boost3_amount);
                gameInterface.boost4amount.DisplayedString = Convert.ToString(gameInterface.boost4_amount);
                gameInterface.boost5amount.DisplayedString = Convert.ToString(gameInterface.boost5_amount);

                gameInterface.boostprice.DisplayedString = Convert.ToString(gameInterface.boost_Price);
                gameInterface.boost1price.DisplayedString = Convert.ToString(gameInterface.boost1_Price);
                gameInterface.boost2price.DisplayedString = Convert.ToString(gameInterface.boost2_Price);
                gameInterface.boost3price.DisplayedString = Convert.ToString(gameInterface.boost3_Price);
                gameInterface.boost4price.DisplayedString = Convert.ToString(gameInterface.boost4_Price);
                gameInterface.boost5price.DisplayedString = Convert.ToString(gameInterface.boost5_Price);

                cookie.clickBoost = gameInterface.boost_amount;

            }



        }
    }
}
