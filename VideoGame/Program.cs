using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGame
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            List<Skill> skillList = new List<Skill>
            {
                new Skill("Basic", "attacks"),
                new Skill("Fireball", "blasts", 3),
                new Skill("Heal", "heals", 0, true)
            };
        }
    }
}
