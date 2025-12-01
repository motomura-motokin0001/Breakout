using TMPro;
using UnityEngine;
using BrickBreaker.Event;

namespace BrickBreaker.UI
{
    public class DisplayUI : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _SCORE_text;

        private void OnEnable()
        {
            EventService.UpdateScore += Display_Score;
        }

        private void OnDisable()
        {
            EventService.UpdateScore -= Display_Score;
        }

        public void Display_Score(int score)
        {
            _SCORE_text.SetText(score.ToString());
        }
    }
}
