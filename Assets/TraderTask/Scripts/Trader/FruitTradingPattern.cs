using UnityEngine;

namespace PatternLessons.TraderTask
{
    public class FruitTradingPattern: ITradingPattern
    {
        public void Trade()
        {
            Debug.Log("I can sell u some fruits");
        }
    }
}
