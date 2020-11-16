﻿using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeperAdvance.Behaviours
{
    enum InputType
    {

    }

    public enum GameDifficulty : ushort
    {
        Easy = 0,
        Medium = 1,
        Hard = 2,
        Insane = 3
    }
    public static class GameData
    {
        public static GameDifficulty Difficulty { get; set; } = GameDifficulty.Easy;
        public static Image FlagSkin { get; set; } = null;
        public static Image MineSkin { get; set; } = null;
    }
    public static class Game
    {
        public static Form mainForm;
        public static Graphics mainGraphics;

        public static SolidBrush mainTileBrush;
        public static TileMap tileMap;

        public static Font drawFont;

        /// <summary>
        /// Don't put any graphics update stuff here.
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

            Game.drawFont = new Font("Comic Sans", 20);

            for (ushort i = 0; i < tileMap.size.Item1; i++)
            {
                for (ushort j = 0; j < tileMap.size.Item2; j++)
                {
                    var index = j * tileMap.size.Item1 + i;
                    tileMap.tiles[index] = new Tile
                    {
                        position = (i, j),
                        isMine = new Random().Next(100) <= 40
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

            System.Threading.Thread.Sleep(120);
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
                    else if (tileMap.tiles[index].drawMine)
                        tileMap.tiles[index].DrawMine();
                    else if (tileMap.tiles[index].drawNumber >= 0)
                        tileMap.tiles[index].DrawNumber();
                    else tileMap.tiles[index].Clear();
                }
            }
        }
        public static void HandleMouseEvent(ref MouseEventArgs args)
        {
            ushort x = (ushort)((args.X - 6) / 36);
            ushort y = (ushort)((args.Y - 6) / 36);
            var index = y * tileMap.size.Item2 + x;

            if (x < Game.tileMap.size.Item1 && y < Game.tileMap.size.Item2)
            {
                switch (args.Button)
                {
                    case MouseButtons.Left:
                        {
                            if (Game.tileMap.tiles[index].isMine)
                                Game.tileMap.tiles[index].drawMine = true;
                            else
                            {
                                int num = 0;
                                for (int i = -1; i <= 1; ++i)
                                {
                                    for (int j = -1; j <= 1; ++j)
                                    {
                                        if (Game.tileMap.tiles[index].position.Item1 + i >= 0 ||
                                            Game.tileMap.tiles[index].position.Item1 + i < Game.tileMap.size.Item1 ||
                                            Game.tileMap.tiles[index].position.Item2 + j >= 0 ||
                                            Game.tileMap.tiles[index].position.Item2 + j < Game.tileMap.size.Item2)
                                            if (Game.tileMap.tiles[index].isMine)
                                                num++;
                                    }
                                }
                                Game.tileMap.tiles[index].drawNumber = num;
                            }
                        }
                        break;
                    case MouseButtons.Right:
                        {
                            Game.tileMap.tiles[index].drawFlag = !Game.tileMap.tiles[index].drawFlag;
                        }
                        break;
                }
            }
        }
    }

    public class Tile : IDisposable
    {
        public (ushort, ushort) position;

        public bool isMine;

        public bool drawFlag = false;
        public bool drawMine = false;
        public int drawNumber = -1;

        public void Clear()
        {
            Game.mainGraphics.FillRectangle(Game.mainTileBrush, 6 + position.Item1 * 36, 6 + position.Item2 * 36, 34, 34);
        }
        public void DrawFlag()
        {
            // Temporary flag thing.
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 0, 0)))
                Game.mainGraphics.DrawImage(GameData.FlagSkin, 10 + position.Item1 * 36, 10 + position.Item2 * 36, 26, 26);
        }
        public void DrawMine()
        {
            // Temporary flag thing.
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 0, 0, 0)))
                Game.mainGraphics.FillRectangle(brush, 10 + position.Item1 * 36, 10 + position.Item2 * 36, 26, 26);
        }
        public void DrawNumber()
        {
            // Temporary flag thing.
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 0, 0, 255)))
                Game.mainGraphics.DrawString(drawNumber.ToString(), Game.drawFont, brush, new RectangleF(10 + position.Item1 * 36, 10 + position.Item2 * 36, 26, 26));
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