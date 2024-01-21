using UnityEngine;

namespace PatternLessons.TraderTask
{
    internal class ArmorTradingPattern: ITradingPattern
    {
        public void Trade()
        {
            Debug.Log("I can sell u armor");
        }
    }
}
