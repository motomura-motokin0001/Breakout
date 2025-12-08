using UnityEngine;
using BrickBreaker.Event;

public class GameJudgment : MonoBehaviour
{
[SerializeField]
private GameObject _BlockList;
[SerializeField]
private GameObject _OverArea;
private int Blocks;

    private void OnEnable()
    {
        EventService.OnBlockDestroyed += OncangeBlockCount;//ブロック破壊イベント登録
    }

    private void OnDisable()
    {
        EventService.OnBlockDestroyed -= OncangeBlockCount;//ブロック破壊イベント解除
    }

    void Start()
    {
        Blocks = _BlockList.transform.childCount;
        Collider2D collider = _OverArea.GetComponent<Collider2D>();
    }

    void OncangeBlockCount()
    {
        Blocks--;
        Debug.Log(Blocks);//デバッグ用
        if (Blocks <= 0)
        {
            GameClear();
        }
    }

    void GameClear()
    {
        EventService.GameClear?.Invoke();//ゲームクリアイベント発火
    }

    // //_OverAreaに衝突したら(スクリプトは_OverAreaにアタッチしない)ゲームオーバー
    // private void OnTriggerEnter2D(collider)
    // {
    //     if (collision.gameObject == _OverArea)
    //     {
    //         EventService.GameOver?.Invoke();//ゲームオーバーイベント発火
    //     }
    // }
}
