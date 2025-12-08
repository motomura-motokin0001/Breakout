using UnityEngine;

public class GameOverJudgment : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            GameManager.instance.status = GameStatus.GameOver;
        }
    }
}
