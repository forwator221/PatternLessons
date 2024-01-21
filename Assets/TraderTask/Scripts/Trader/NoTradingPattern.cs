using UnityEngine;

namespace PatternLessons.TraderTask
{
    public class NoTradingPattern : ITradingPattern
    {
        public void Trade()
        {
            Debug.Log("I can`t trade with u");
        }
    }
}
