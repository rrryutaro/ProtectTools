using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

namespace ProtectTools
{
    public static class ProtectToolsUtils
    {
        public const int tileSize = 16;

        public static Texture2D Resize(this Texture2D texture, int width, int height)
        {
            Texture2D result = texture;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                texture.SaveAsPng(ms, width, height);
                result = Texture2D.FromStream(texture.GraphicsDevice, ms);
            }
            return result;
        }

        public static Vector2 Offset(this Vector2 position, float x, float y)
        {
            position.X += x;
            position.Y += y;
            return position;
        }

    }
}
