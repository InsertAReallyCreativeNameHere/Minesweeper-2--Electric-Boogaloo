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
        public static bool canUpdate; // .NET primitive types should be atomic...

        /// <summary>
        /// Don't put any graphics update stuff here. I will f*cking kill you.
        /// </summary>
        public static void Start()
        {
            Game.mainForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            Game.mainForm.MaximizeBox = false;
        }
        public static async void Update()
        {
            await Task.Yield(); // Force asynchronicity.

            // Logic

            // Graphics Update.
            Game.mainForm.Invalidate(); // Resends a WM_PAINT event natively so the .NET stuff will repaint.
        }
        public static void GraphicsUpdate(ref PaintEventArgs args)
        {
            var graphics = args.Graphics;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 40, 40, 40)))
            {
                // Clear screen.
                graphics.FillRectangle(brush, new Rectangle(args.ClipRectangle.X, args.ClipRectangle.Y, args.ClipRectangle.Width, args.ClipRectangle.Height));
            }
            using (Pen is_ = new Pen(Color.Blue, 2))
            {
                graphics.DrawLine(is_, 20, 10, 200, 200);
            }
        }
    }

    public class Tile : IDisposable
    {
        public (uint, uint) position;

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
        public (uint, uint) size;
        public Tile[] tiles;

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