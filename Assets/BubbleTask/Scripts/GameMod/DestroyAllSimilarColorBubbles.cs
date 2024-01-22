using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PatternLessons.BubbleTask
{
    public class DestroyAllSimilarColorBubbles : GameMod
    {
        private List<RedBubble> _activeRedBubbles;
        private List<GreenBubble> _activeGreenBubbles;
        private List<WhiteBubble> _activeWhiteBubbles;

        private int _redBubbleCounter;
        private int _greenBubbleCounter;
        private int _whiteBubbleCounter;

        public override void Initialize(List<Bubble> activeBubbles)
        {
            _activeRedBubbles = activeBubbles.OfType<RedBubble>().ToList();
            _redBubbleCounter = _activeRedBubbles.Count;

            _activeGreenBubbles = activeBubbles.OfType<GreenBubble>().ToList();
            _greenBubbleCounter = _activeGreenBubbles.Count;

            _activeWhiteBubbles = activeBubbles.OfType<WhiteBubble>().ToList();
            _whiteBubbleCounter = _activeWhiteBubbles.Count;
        }

        public override void TryWin()
        {
            if (_redBubbleCounter == 0 || _greenBubbleCounter == 0 || _whiteBubbleCounter == 0)
                Debug.Log("you win");
        }
    }
}
