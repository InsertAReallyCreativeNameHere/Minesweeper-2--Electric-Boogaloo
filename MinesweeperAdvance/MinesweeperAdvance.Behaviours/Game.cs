using System;
using System.Drawing;
using System.Windows.Forms;

namespace MinesweeperAdvance.Behaviours
{
    enum InputType
    {

    }
    public static class Game
    {
        public static bool ready = false;
        public static bool done = false;

        public static Form mainForm;

        public static SolidBrush mainTileBrush;

        public static TileMap tileMap;

        /// <summary>
        /// Don't put any graphics update stuff here. I will f*cking kill you.
        /// </summary>
        public static void Start()
        {
            Game.tileMap = new TileMap
            {
                size = (10, 10),
                tiles = new Tile[100]
            };
            for (ushort i = 0; i < tileMap.size.Item1; i++)
            {
                for (ushort j = 0; j < tileMap.size.Item2; j++)
                {
                    tileMap.tiles[j * tileMap.size.Item1 + i] = new Tile
                    {
                        position = (i, j)
                    };
                }
            }

            Game.mainForm.ClientSize = new Size { Width = Game.tileMap.size.Item1 * 36 + 10, Height = Game.tileMap.size.Item2 * 36 + 10 };
            Game.mainTileBrush = new SolidBrush(Color.FromArgb(255, 80, 80, 80));
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
                    tileMap.tiles[j * tileMap.size.Item1 + i].Clear(ref graphics);
                }
            }
        }
    }

    public class Tile : IDisposable
    {
        public (ushort, ushort) position;

        public void Clear(ref Graphics graphics)
        {
            graphics.FillRectangle(Game.mainTileBrush, 6 + position.Item1 * 36, 6 + position.Item2 * 36, 34, 34);
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
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 40, 40, 40)))
                graphics.FillRectangle(brush, graphics.VisibleClipBounds.X, graphics.VisibleClipBounds.Y, graphics.VisibleClipBounds.Width, graphics.VisibleClipBounds.Height);
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 120, 120, 120)))
                graphics.FillRectangle(brush, 4, 4, size.Item1 * 36 + 2, size.Item2 * 36 + 2);
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