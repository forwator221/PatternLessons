using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PatternLessons.TraderTask
{
    public class Bootstrap : MonoBehaviour
    {
        [Header("Character Params")]
        [SerializeField] private Character _character;
        [SerializeField] private float _startSpeed;
        [SerializeField] private float _startExperience;

        [Header("Trader Params")]
        [SerializeField] private Trader _trader;
        [SerializeField] private float _noTradingExperience;
        [SerializeField] private float _fruitTradingExperience;

        private void Awake()
        {
            _character.Initialize(_startSpeed, _startExperience);
            _trader.Initialize(new NoTradingPattern(), _noTradingExperience, _fruitTradingExperience);
        }
    }
}

