using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeperAdvance.Behaviours
{
    public static class Game
    {
        public static async Task<int> Test(int i)
        {
            await Task.Yield();

            MessageBox.Show("Wow called through C#.");

            return i;
        }
    }
}
