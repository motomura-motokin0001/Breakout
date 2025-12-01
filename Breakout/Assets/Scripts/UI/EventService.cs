using System;

namespace BrickBreaker.Event
{
    public class EventService
    {
        public static Action<int> AddScoreEvent;
        public static Action<int> UpdateScore;
        public static void AddScore(int NewScore)
        {
            AddScoreEvent?.Invoke(NewScore);
        }
    }
}

