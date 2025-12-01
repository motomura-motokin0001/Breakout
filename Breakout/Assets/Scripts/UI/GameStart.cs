using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class GameStartUI : MonoBehaviour
{

    [SerializeField]
    private Button _TargetButton;
    [SerializeField]
    private GameObject _TargetObject;
    [SerializeField]
    private Text _TargetText;
    [SerializeField]
    private Vector3 _StartPos;
    [SerializeField]
    private Vector3 _MovePos;
    

    void Start()
    {
        _TargetObject.transform.localPosition = _StartPos;
        _TargetButton.onClick.AddListener(OnGameStartAnimation);
    }

    void Update()
    {
        
    }

    void OnGameStartAnimation()
    {
        _TargetObject.transform.DOLocalMove(_MovePos,1f).OnComplete(() =>
        {
            _TargetText.DOCounter(3,0,4,true).OnComplete(() =>
            {
                
                Destroy(_TargetObject);
                GameManager.instance.Status = GameStatus.Play;
            });
        });
    }
}
