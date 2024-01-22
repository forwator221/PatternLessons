using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace PatternLessons.BubbleTask
{
    internal class DestroyAllBubbles : GameMod
    {
        private List<Bubble> _bubbles;

        public override void Initialize(List<Bubble> activeBubbles)
        {
           _bubbles = activeBubbles;
        }

        public override void TryWin()
        {
            if (_bubbles.Count == 0)
                Debug.Log("you win");
        }
    }
}
