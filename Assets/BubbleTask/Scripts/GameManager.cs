using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace PatternLessons.BubbleTask
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private List<Bubble> _activeBubbles;

        private GameMod _gameMod;        

        private void Update()
        {
            _gameMod.TryWin();
        }

        public void Initialize(GameMod gameMod)
        {
            _gameMod = gameMod;
        }
    }
}