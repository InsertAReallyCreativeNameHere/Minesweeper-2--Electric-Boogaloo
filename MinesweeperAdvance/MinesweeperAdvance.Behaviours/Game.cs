using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Threading.Tasks;
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
        public static bool firstGraphicsUpdate = true;

        public static Form mainForm;
        public static Graphics mainGraphics;

        public static SolidBrush mainTileBrush;
        public static TileMap tileMap;

        /// <summary>
        /// Don't put any graphics update stuff here. I will f*cking kill you.
        /// </summary>
        public static void Start()
        {
            Game.mainTileBrush = new SolidBrush(Color.FromArgb(255, 80, 80, 80));
            Game.tileMap = new TileMap
            {
                size = (10, 10),
                tiles = new Tile[100]
            };
            Game.mainForm.ClientSize = new Size { Width = Game.tileMap.size.Item1 * 36 + 10, Height = Game.tileMap.size.Item2 * 36 + 10 };
            //Game.tileMap.InitBackdrop(ref Game.mainGraphics);
            for (ushort i = 0; i < tileMap.size.Item1; i++)
            {
                for (ushort j = 0; j < tileMap.size.Item2; j++)
                {
                    var index = j * tileMap.size.Item1 + i;
                    tileMap.tiles[index] = new Tile
                    {
                        position = (i, j)
                    };
                }
            }

            Task.Run(Update);
        }
        public static async void Update()
        {
            await Task.Yield();

            // Logic

            // Graphics Update.
            Game.mainForm.Invalidate();

            System.Threading.Thread.Sleep(80);
            Update();
        }
        public static void GraphicsUpdate(ref PaintEventArgs args)
        {
            Game.mainGraphics = args.Graphics;
            Game.tileMap.InitBackdrop();
            for (ushort i = 0; i < tileMap.size.Item1; i++)
            {
                for (ushort j = 0; j < tileMap.size.Item2; j++)
                {
                    var index = j * tileMap.size.Item1 + i;
                    tileMap.tiles[index].Clear();
                    if (tileMap.tiles[index].drawFlag)
                        tileMap.tiles[index].DrawFlag();
                    else tileMap.tiles[index].Clear();
                }
            }
        }
        public static void HandleMouseEvent(ref MouseEventArgs args)
        {
            switch (args.Button)
            {
                case MouseButtons.Left:
                    {

                    }
                    break;
                case MouseButtons.Right:
                    {
                        ushort x = (ushort)((args.X - 6) / 36);
                        ushort y = (ushort)((args.Y - 6) / 36);
                        var index = y * tileMap.size.Item2 + x;
                        if (x < Game.tileMap.size.Item1 && y < Game.tileMap.size.Item2)
                            Game.tileMap.tiles[index].drawFlag = !Game.tileMap.tiles[index].drawFlag;
                    }
                    break;
            }
        }
    }

    public class Tile : IDisposable
    {
        public (ushort, ushort) position;
        public bool drawFlag = false;

        public void Clear()
        {
            Game.mainGraphics.FillRectangle(Game.mainTileBrush, 6 + position.Item1 * 36, 6 + position.Item2 * 36, 34, 34);
        }
        public void DrawFlag()
        {
            // Temporary flag thing.
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 220, 220, 220)))
                Game.mainGraphics.FillRectangle(brush, 10 + position.Item1 * 36, 10 + position.Item2 * 36, 26, 26);
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

        public void InitBackdrop()
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 40, 40, 40)))
                Game.mainGraphics.FillRectangle(brush, Game.mainGraphics.VisibleClipBounds.X, Game.mainGraphics.VisibleClipBounds.Y, Game.mainGraphics.VisibleClipBounds.Width, Game.mainGraphics.VisibleClipBounds.Height);
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 120, 120, 120)))
                Game.mainGraphics.FillRectangle(brush, 4, 4, size.Item1 * 36 + 2, size.Item2 * 36 + 2);
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