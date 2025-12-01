using UnityEngine;

public class ClearJudgment : MonoBehaviour
{
[SerializeField]
private GameObject _BlockList;
private bool _IsJudge = true;

    void Update()
    {
        GameManager.instance.BlockCount = _BlockList.transform.childCount;

        if(GameManager.instance.BlockCount == 0 && _IsJudge)
        {
            _IsJudge = false;
            GameManager.instance.Status = GameStatus.GameClear;
        }
    }
}
