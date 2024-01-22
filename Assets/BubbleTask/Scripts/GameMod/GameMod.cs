using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PatternLessons.BubbleTask
{
    public abstract class GameMod
    {
        public abstract void Initialize(List<Bubble> activeBubbles);

        public abstract void RemoveBubble();

        public abstract void TryWin();
    }
}


