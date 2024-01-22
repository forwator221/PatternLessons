using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PatternLessons.BubbleTask
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private GameManager _gameManager;

        private void Awake()
        {
            _gameManager.Initialize(new DestroyAllBubbles());
        }
    }
}