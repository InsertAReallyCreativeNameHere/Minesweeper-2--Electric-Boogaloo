using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MinesweeperAdvance.Behaviours
{
    enum InputType
    {
        
    }
    public static class Game
    {
        public static Form mainForm;

        public static SolidBrush mainTileBrush;
        public static SolidBrush secondaryTilebrush;

        public static TileMap tileMap;

        public static bool canUpdate; // .NET primitive types should be atomic...

        /// <summary>
        /// Don't put any graphics update stuff here. I will f*cking kill you.
        /// </summary>
        public static void Start()
        {
            Game.mainForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            Game.mainForm.MaximizeBox = false;

            Game.mainTileBrush = new SolidBrush(Color.FromArgb(255, 80, 80, 80));
            Game.secondaryTilebrush = new SolidBrush(Color.FromArgb(255, 120, 120, 120));

            Game.tileMap = new TileMap();
            Game.tileMap.size = (10, 10);
            Game.tileMap.tiles = new Tile[100];
            for (ushort i = 0; i < tileMap.size.Item1; i++)
            {
                for (ushort j = 0; j < tileMap.size.Item2; j++)
                {
                    var tile = tileMap.tiles[j * tileMap.size.Item1 + i];
                    tile = new Tile();
                    tile.position = (i, j);
                }
            }
        }
        public static void Update()
        {
            // Logic

            // Graphics Update.
            Game.mainForm.Invalidate(); // Resends a WM_PAINT event natively so the .NET stuff will repaint.
        }
        public static void GraphicsUpdate(ref PaintEventArgs args)
        {
            var graphics = args.Graphics;
            Game.tileMap.InitBackdrop(ref graphics);
            for (ushort i = 0; i < tileMap.size.Item1; i++)
            {
                for (ushort j = 0; j < tileMap.size.Item2; j++)
                {
                    var tile = tileMap.tiles[j * tileMap.size.Item1 + i];
                    if (tile != null)
                        tile.Clear(ref graphics);
                }
            }
        }
    }

    public class Tile : IDisposable
    {
        public (ushort, ushort) position;

        public void Clear(ref Graphics graphics)
        {
            graphics.FillRectangle(Game.mainTileBrush, 6 + position.Item1 * 16, 6 + position.Item2 * 16, 16, 16);
        }

        #region Dispose
        private bool disposedValue;
        protected virtual void Dispose(bool disposing) // I'm a C++ programmer, we do RAII where I come from.
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Undraw stuff here.
                }

                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
    public class TileMap : IDisposable
    {
        public (ushort, ushort) size;
        public Tile[] tiles;

        public void InitBackdrop(ref Graphics graphics)
        {
            graphics.FillRectangle(Game.secondaryTilebrush, 4, 4, size.Item1 * 16 + 4, size.Item2 * 16 + 4);
        }

        #region Dispose
        private bool disposedValue;
        protected virtual void Dispose(bool disposing) // I'm a C++ programmer, we do RAII here.
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Destroy all tiles here.
                }

                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}