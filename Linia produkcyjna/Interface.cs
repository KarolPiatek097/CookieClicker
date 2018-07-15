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
    public class GameInterface
    {

        public RectangleShape ClickBooster = new RectangleShape();
        public RectangleShape ClickBooster1 = new RectangleShape();
        public RectangleShape ClickBooster2 = new RectangleShape();
        public RectangleShape ClickBooster3 = new RectangleShape();
        public RectangleShape ClickBooster4 = new RectangleShape();
        public RectangleShape ClickBooster5 = new RectangleShape();

        public int cookiesPerSec = 0;
        public int gameTime = 0;
        public int frameCounter = 0;

        public Text cookieAmount = new Text("Cookies: ", new Font("Arial.ttf"));
        public Text cookieCounter = new Text("0",new Font("Arial.ttf"));
        public Text perSec = new Text("Cookies/s: ", new Font("Arial.ttf"));
        public Text perSecAmount = new Text("0", new Font("Arial.ttf"));
        public Text timer = new Text("00:00:00", new Font("Arial.ttf"));

        #region boost definition
        public Text boost = new Text("+1 cookie per click ", new Font("Arial.ttf"));
        public Text boostamount = new Text("0", new Font("Arial.ttf"));
        public Text boostprice = new Text("1000", new Font("Arial.ttf"));

        public int boost_amount = 0;
        public int boost_Price = 500;
        #endregion 
        #region boost1 definition
        public Text boost1 = new Text("1c/1s ", new Font("Arial.ttf"));
        public Text boost1amount = new Text("0", new Font("Arial.ttf"));
        public Text boost1price = new Text("25", new Font("Arial.ttf"));

        public int boost1_amount = 0;
        public int boost1_Price = 25;
        #endregion
        #region boost2 definition
        public Text boost2 = new Text("5c/1s ", new Font("Arial.ttf"));
        public Text boost2amount = new Text("0", new Font("Arial.ttf"));
        public Text boost2price = new Text("200", new Font("Arial.ttf"));

        public int boost2_amount = 0;
        public int boost2_Price = 200;
        #endregion
        #region boost3 definition
        public Text boost3 = new Text("25c/1s ", new Font("Arial.ttf"));
        public Text boost3amount = new Text("0", new Font("Arial.ttf"));
        public Text boost3price = new Text("5000", new Font("Arial.ttf"));

        public int boost3_amount = 0;
        public int boost3_Price = 5000;
        #endregion
        #region boost4 definition
        public Text boost4 = new Text("100c/1s ", new Font("Arial.ttf"));
        public Text boost4amount = new Text("0", new Font("Arial.ttf"));
        public Text boost4price = new Text("20000", new Font("Arial.ttf"));

        public int boost4_amount = 0;
        public int boost4_Price = 20000;
        #endregion
        #region boost5 definition
        public Text boost5 = new Text("500c/s", new Font("Arial.ttf"));
        public Text boost5amount = new Text("0", new Font("Arial.ttf"));
        public Text boost5price = new Text("100000", new Font("Arial.ttf"));

        public int boost5_amount = 0;
        public int boost5_Price = 100000;
        #endregion 

        public GameInterface()
        {

            #region cookie
            cookieAmount.CharacterSize = 60;
            cookieAmount.Color = Color.White;
            cookieAmount.Position = new Vector2f(600, 960);
            
            cookieCounter.CharacterSize = 60;
            cookieCounter.Color = Color.White;
            cookieCounter.Position = new Vector2f(840, 960);

            perSec.CharacterSize = 30;
            perSec.Color = Color.White;
            perSec.Position = new Vector2f(605, 1030);

            perSecAmount.CharacterSize = 30;
            perSecAmount.Color = Color.White;
            perSecAmount.Position = new Vector2f(750, 1030);

            #endregion
            #region boost
            ClickBooster.FillColor = new Color(55, 76, 109);
            ClickBooster.Position = new Vector2f(40, 40);
            ClickBooster.Size = new Vector2f(100, 100);

            boost.CharacterSize = 30;
            boost.Color = Color.White;
            boost.Position = new Vector2f(40, 140);

            boostamount.CharacterSize = 30;
            boostamount.Color = Color.White;
            boostamount.Position = new Vector2f(50, 40);

            boostprice.CharacterSize = 30;
            boostprice.Color = Color.White;
            boostprice.Position = new Vector2f(40, 170);
            #endregion
            #region boost1
            ClickBooster1.FillColor = new Color(55, 76, 109);
            ClickBooster1.Position = new Vector2f(1800, 40);
            ClickBooster1.Size = new Vector2f(100, 100);

            boost1.CharacterSize = 30;
            boost1.Color = Color.White;
            boost1.Position = new Vector2f(1810, 140);

            boost1amount.CharacterSize = 30;
            boost1amount.Color = Color.White;
            boost1amount.Position = new Vector2f(1810, 40);

            boost1price.CharacterSize = 30;
            boost1price.Color = Color.White;
            boost1price.Position = new Vector2f(1810, 170);
            #endregion
            #region boost2
            ClickBooster2.FillColor = new Color(55, 76, 109);
            ClickBooster2.Position = new Vector2f(1800, 210);
            ClickBooster2.Size = new Vector2f(100, 100);

            boost2.CharacterSize = 30;
            boost2.Color = Color.White;
            boost2.Position = new Vector2f(1810, 310);

            boost2amount.CharacterSize = 30;
            boost2amount.Color = Color.White;
            boost2amount.Position = new Vector2f(1810, 210);

            boost2price.CharacterSize = 30;
            boost2price.Color = Color.White;
            boost2price.Position = new Vector2f(1810, 340);
            #endregion
            #region boost3
            ClickBooster3.FillColor = new Color(55, 76, 109);
            ClickBooster3.Position = new Vector2f(1800, 380);
            ClickBooster3.Size = new Vector2f(100, 100);

            boost3.CharacterSize = 30;
            boost3.Color = Color.White;
            boost3.Position = new Vector2f(1800, 480);

            boost3amount.CharacterSize = 30;
            boost3amount.Color = Color.White;
            boost3amount.Position = new Vector2f(1810, 380);

            boost3price.CharacterSize = 30;
            boost3price.Color = Color.White;
            boost3price.Position = new Vector2f(1800, 510);
            #endregion
            #region boost4
            ClickBooster4.FillColor = new Color(55, 76, 109);
            ClickBooster4.Position = new Vector2f(1800, 550);
            ClickBooster4.Size = new Vector2f(100, 100);

            boost4.CharacterSize = 30;
            boost4.Color = Color.White;
            boost4.Position = new Vector2f(1800, 650);

            boost4amount.CharacterSize = 30;
            boost4amount.Color = Color.White;
            boost4amount.Position = new Vector2f(1810, 550);

            boost4price.CharacterSize = 30;
            boost4price.Color = Color.White;
            boost4price.Position = new Vector2f(1800, 680);
            #endregion
            #region boost5
            ClickBooster5.FillColor = new Color(55, 76, 109);
            ClickBooster5.Position = new Vector2f(1800, 720);
            ClickBooster5.Size = new Vector2f(100, 100);

            boost5.CharacterSize = 30;
            boost5.Color = Color.White;
            boost5.Position = new Vector2f(1800, 820);

            boost5amount.CharacterSize = 30;
            boost5amount.Color = Color.White;
            boost5amount.Position = new Vector2f(1810, 720);

            boost5price.CharacterSize = 30;
            boost5price.Color = Color.White;
            boost5price.Position = new Vector2f(1795, 850);
            #endregion

            timer.CharacterSize = 30;
            timer.Color = Color.White;
            timer.Position = new Vector2f(40, 1040);

        }

        public void isInside(int x, int y,ref int c)
        {
            if (x >= 40 && x <= 140 && y >= 40 && y <= 140 && c >= boost_Price)
            {
                c -= Convert.ToInt32(boost_Price);
                boost_Price += Convert.ToInt32(boost_Price * 0.25);
                boost_amount++;
            }

            if (x>=1800 && x<= 1900 && y>=40 && y<=140 && c>=boost1_Price)
            {
                c -= Convert.ToInt32(boost1_Price);
                boost1_Price+=Convert.ToInt32(boost1_Price*0.1);
                boost1_amount++;
                cookiesPerSec += 1;
            }

            if (x >= 1800 && x <= 1900 && y >= 210 && y <= 310 && c >= boost2_Price)
            {
                c -= Convert.ToInt32(boost2_Price);
                boost2_Price += Convert.ToInt32(boost2_Price *0.1);
                boost2_amount++;
                cookiesPerSec += 5;
            }

            if (x >= 1800 && x <= 1900 && y >= 380 && y <= 480 && c >= boost3_Price)
            {
                c -= Convert.ToInt32(boost3_Price);
                boost3_Price += Convert.ToInt32(boost3_Price * 0.1);
                boost3_amount++;
                cookiesPerSec +=  25;
            }
            if (x >= 1800 && x <= 1900 && y >= 550 && y <= 650 && c >= boost4_Price)
            {
                c -= Convert.ToInt32(boost4_Price);
                boost4_Price += Convert.ToInt32(boost4_Price * 0.1);
                boost4_amount++;
                cookiesPerSec += 100;
            }

            if (x >= 1800 && x <= 1900 && y >= 720 && y <= 820 && c >= boost5_Price)
            {
                c -= Convert.ToInt32(boost5_Price);
                boost5_Price += Convert.ToInt32(boost5_Price * 0.1);
                boost5_amount++;
                cookiesPerSec += 500;
            }
        }
    }
}
