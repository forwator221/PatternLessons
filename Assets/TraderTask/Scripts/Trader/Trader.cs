using UnityEngine;

namespace PatternLessons.TraderTask
{
    public class Trader : MonoBehaviour
    {
        private ITradingPattern _tradingPattern;
        private float _noTradingExp;
        private float _fruitTradingExp;


        public void Initialize(ITradingPattern tradingPattern, float noTradingExp, float fruitTradingExp)
        {
            _tradingPattern = tradingPattern;
            _noTradingExp = noTradingExp;
            _fruitTradingExp = fruitTradingExp;
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.TryGetComponent(out Character character))
            {
                CheckExp(character);
                _tradingPattern.Trade();
            }
        }

        private void CheckExp(Character character)
        {
            if (character.Experience < _noTradingExp)
                _tradingPattern = new NoTradingPattern();
            else if (character.Experience < _fruitTradingExp)
                _tradingPattern = new FruitTradingPattern();
            else
                _tradingPattern = new ArmorTradingPattern();
        }
    }
}