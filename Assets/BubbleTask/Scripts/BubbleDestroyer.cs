using UnityEngine;

namespace PatternLessons.BubbleTask
{
    public class BubbleDestroyer : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.TryGetComponent(out Bubble bubble))
                    {
                        bubble.DestroyBubble();
                    }
                }
            }
        }
    }
}