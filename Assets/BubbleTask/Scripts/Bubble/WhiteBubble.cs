using UnityEngine;

namespace PatternLessons.BubbleTask
{
    internal class WhiteBubble : Bubble
    {
        public override void DestroyBubble()
        {
            Debug.Log("u destroy white bubble");
        }
    }
}
