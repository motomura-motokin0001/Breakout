using UnityEngine;
using UnityEngine.UI;
// using DG.tween;

public class GameStart : MonoBehaviour
{

    [SerializeField]
    private Button _TargetButton;
    [SerializeField]
    private GameObject _TargetObject;
    

    void Start()
    {
        _TargetButton.onClick.AddListener(OnGameStartAnimation);
    }

    void Update()
    {
        
    }

    void OnGameStartAnimation()
    {
        // _TargetObject.transform.
    }
}
