using UnityEngine;

namespace PatternLessons.BubbleTask
{
    internal class GreenBubble : Bubble
    {
        public override void DestroyBubble()
        {
            Debug.Log("u destroy green bubble");
        }
    }
}
