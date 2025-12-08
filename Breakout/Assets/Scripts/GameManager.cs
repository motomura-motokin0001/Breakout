using UnityEngine;
using System;
using BrickBreaker.Event;


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

    public GameStatus status;

    public string Status
    {
        get { return status.ToString(); }
    }

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
        GameManager.instance.status = GameStatus.Title; 
    }



    private void OnEnable()
    {
        BrickBreaker.Event.EventService.GameClear += OnGameClear;
        BrickBreaker.Event.EventService.GameOver += OnGameOver;
        BrickBreaker.Event.EventService.StateChanged += OnstatusChanged;
    }

    private void OnDisable()
    {
        BrickBreaker.Event.EventService.GameClear -= OnGameClear;
        BrickBreaker.Event.EventService.GameOver -= OnGameOver;
        BrickBreaker.Event.EventService.StateChanged -= OnstatusChanged;
    }

    void OnGameClear()
    {
        GameManager.instance.status = GameStatus.GameClear;
        BrickBreaker.Event.EventService.StateChanged?.Invoke(GameStatus.GameClear);
    }

    void OnGameOver()
    {
        GameManager.instance.status = GameStatus.GameOver;
        BrickBreaker.Event.EventService.StateChanged?.Invoke(GameStatus.GameOver);
    }

    void OnstatusChanged(GameStatus status)
    {
        GameManager.instance.status = status;
    }


}
