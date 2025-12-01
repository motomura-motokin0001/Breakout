using UnityEngine;
using BrickBreaker.Event;

namespace BrickBreaker.System
{
    public class ScoreSystem : MonoBehaviour
    {
        private int _SCORE;

        private void OnEnable()
        {
            EventService.AddScoreEvent += AddScore;
        }

        private void OnDisable()
        {
            EventService.AddScoreEvent -= AddScore;
        }
        public void AddScore(int Add)
        {
            _SCORE +=  Add;
            EventService.UpdateScore(_SCORE);
        }
    }
}
