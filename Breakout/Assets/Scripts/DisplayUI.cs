using TMPro;
using UnityEngine;

public class DisplayUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _text;
    void Update()
    {
        _text.SetText("SCORE: " + GameManager.instance.Score.ToString());
    }
}
