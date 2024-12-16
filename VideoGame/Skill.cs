using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Alex
namespace VideoGame
{
    internal class Skill
    {
        public string sName { get; set; }
        protected string sVerb { get; set; }
        protected double damMod { get; set; }  
        protected bool heals { get; set; }

        public Skill(string n, string v)
        { sName = n; sVerb = v; damMod = 1; heals = false; }

        public Skill(string n, string v, double m)
        { sName = n; sVerb = v; damMod = m; heals = false; }

        public Skill(string n, string v, double m, bool h)
        { sName = n; sVerb = v; damMod = m; heals = h; }

        public string doSkill(dynamic source, dynamic target)
        { 
            if (heals) {return healCalc(source, target); }    
            else { return damageCalc(source, target); }
        }


        public string damageCalc(dynamic source, dynamic target)
        {
            int damage = (int)((source.getStrength() - target.getDefense()) * damMod);
            if (damage < 1) { damage = 1; }
            int hp = target.getHp();

            int remaining = hp - damage;

            target.setHp(remaining);

            string msg = doFeedback(source, target, damage, remaining);
            return msg;
        }

        public string healCalc(dynamic source, dynamic target)
        {
            //Random r = new Random();
            int power = source.getMaxHp() / 5;

            //int upHP = r.Next(0, power);
            int upHP = power;

            source.setHp(upHP + source.getHp());

            if(source.getHp() > source.getMaxHp())
            {
                source.setHp(source.getMaxHp());
            }

            string msg = doFeedback(source, source, upHP, source.getHp());
            return msg;
        }

        public string doFeedback(dynamic source, dynamic target, int damage, int remaining)
        {
            string msg;
            string src = source.getName();
            string tgt = target.getName();

            try
            {
                if (source == target) { tgt = "themself"; }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (heals) { msg = $"{src} heals {tgt} for {damage} HP!"; }
            else { msg = $"{src} {sVerb} {tgt} for {damage} damage!"; }

            if (remaining <= 0) { msg += $" The {tgt} passes out!"; }

            return msg;
        }
        //End Alex
    }
}
