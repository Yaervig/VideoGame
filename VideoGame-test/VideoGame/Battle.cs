﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGame
{
    internal class Battle
    {
        bool inProgress;

        //Alex
        string msg;

        List<Skill> skillList = new List<Skill>
            {
                new Skill("Basic", "attacks", 1),
                new Skill("Fireball", "blasts", 1.5),
                new Skill("Heal", "heals", 0, true),
                new Skill("Lightning", "zaps", 0.6)
            };
        //End Alex

        public Battle()
        {
            inProgress = true;
        }

        public void setInProgress(bool a)
        {
            inProgress = a;
        }

        public bool getInProgress()
        {
            return inProgress;
        }
        
        //Alex
        public void setMsg(string a) {  msg = a; }
        public string getMsg() { return msg; }

        public void addSkill(Skill newSkill) { skillList.Add(newSkill); }

        public void castSkill(dynamic attacker, dynamic defender, String skill)
        {
            foreach (Skill s in skillList)
            {
                if (s.sName == skill)
                    msg = s.doSkill(attacker, defender);
            }
        }
        //End Alex

        public void enemyTurn(dynamic attacker, dynamic defender)
        {
            castSkill(attacker, defender, "Basic");
        }
    }
}
