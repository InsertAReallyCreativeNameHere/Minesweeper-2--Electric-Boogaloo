using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MinesweeperAdvance.Behaviours
{
    public static class Game
    {
        public static Graphics graphics;
        public static int Test(int i)
        {
            using (SolidBrush brush = new SolidBrush(Color.Red))
            {
                graphics.FillRectangle(brush, new Rectangle(0, 0, 1000, 1000));
            }
            using (Pen is_ = new Pen(Color.Blue, 5))
            {
                graphics.DrawLine(is_, 20, 10, 200, 200);
            }
            return i;
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