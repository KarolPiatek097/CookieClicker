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
    public class Cookie
    {
        public int cookies=0;
        public int clickBoost = 0;


        public CircleShape cookie = new CircleShape(400);
        
        public Cookie()
        {
            cookie.Position = new Vector2f(560, 140);
            cookie.OutlineColor = new Color(81, 49,1);
            cookie.OutlineThickness = 2f;
            cookie.FillColor = new Color(142, 86, 2);
            cookie.Transform.Translate(new Vector2f(360, 540));
        }
       
        public void isInside(int x, int y)
        {
            if (Math.Pow((x - 960), 2) + Math.Pow((y - 540), 2) <= 400 * 400)
            {
                cookie.Radius = 390;
                cookie.Position += new Vector2f(10, 10);
                cookies += 1 + 1 * clickBoost;
                Console.WriteLine(Convert.ToString(cookies));

            }
            
        }
        public void isInside2(int x, int y)
        {
            if (Math.Pow((x - 960), 2) + Math.Pow((y - 540), 2) <= 400 * 400)
            {
                cookie.Radius = 400;
                cookie.Position -= new Vector2f(10, 10);

            }

        }


    }
}
