using UnityEngine;
public enum GameStatus
{
    None,
    Title,
    Play,
    GameClear,
    GameOver
}
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameStatus Status;
    public int Score;
    public int AddScore;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        Status = GameStatus.Play;
    }

    void Update()
    {

    }
}
