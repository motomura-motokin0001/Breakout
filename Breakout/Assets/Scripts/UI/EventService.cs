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
        public static Action<GameStatus> StateChanged;
        public static Action OnBlockDestroyed;//ブロック破壊イベント発火
        public static Action GameClear;
        public static Action GameOver;

    }
}

