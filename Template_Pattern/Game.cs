﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Pattern
{
    public abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        //template method
        public void Play()
        {
            //initialize the game
            Initialize();

            //start game
            StartPlay();

            //end game
            EndPlay();
        }
    }
}
