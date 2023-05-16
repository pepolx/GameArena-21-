using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace _21ProjectSchool
{
    internal class Card
    {
        public enum CardName
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
        }

        public enum CardType
        {
            Hearts = 1,
            Spaders = 2,
            Cubes = 3,
            Diamonds = 4,
        }
        Image image;
        CardName cardName;
        CardType cardType;

        public Image Image
        {
            get { return image; }
        }

        public CardName Name { 
            get { return cardName; } 
            set { 
                cardName = value;
                GetImage();
                
            } 
        }
        public CardType Type { get { return cardType; } set { cardType= value; GetImage(); } }

        public Card()
        {
            cardName = 0;
            cardType = 0;
            image = null;
        }

        private void GetImage()
        {
            if(Type != 0 && Name != 0)
            {
                int x = 0;
                int y = 0;
                int height = 97;
                int width =  73;

                switch(Type) {
                    case CardType.Hearts:
                        y = 196;
                        break;
                        case CardType.Spaders:
                        y = 98;
                        break;
                        case CardType.Cubes:
                        y = 0;
                        break; case CardType.Diamonds:
                        y = 294;
                        break;
                }
                x = width * ((int)this.Name - 1);

                DirectoryInfo dir = new DirectoryInfo(@"D:\VS\Sandbox\21ProjectSchool\21ProjectSchool\Resources\cards.png");
                Bitmap source = (Bitmap) Image.FromFile (dir.FullName);
                Bitmap img = new Bitmap(width, height);
                Graphics g = Graphics.FromImage(img);
                g.DrawImage(source, new Rectangle(0, 0, width, height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);
                g.Dispose();
                image= img;
                
            }
        }
        
    }
}

