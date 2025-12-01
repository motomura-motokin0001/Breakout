using UnityEngine;
using System;


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

    public static event Action<GameStatus> StateChanged;

    private GameStatus _status;
    public GameStatus Status
    {
        get => _status;
        set
        {
            if (_status == value) return;

            _status = value;

            StateChanged?.Invoke(_status);
        }
    }

    public int Score;
    public int AddScore;
    public int BlockCount;

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
        GameManager.instance.Status = GameStatus.Title; 
    }
}
