using BrickBreaker.Event;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f; 

    private bool _isMoving = false; 
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Move()
    {
        if (_isMoving) return;
        _rb.linearVelocity = new Vector2(_speed, _speed);
        _isMoving = true;
    }

    void Stop()
    {
        _rb.linearVelocity = Vector2.zero; 
        _rb.angularVelocity = 0f; 
        _isMoving = false;
    }

    private void OnEnable()
    {
        EventService.StateChanged += OnStateChanged;
    }

    private void OnDisable()
    {
        EventService.StateChanged -= OnStateChanged;
    }

    private void OnStateChanged(GameStatus status)
    {
        switch(status)
        {
            case GameStatus.Play :
                Move();
                break;
            case GameStatus.GameClear : 
            case GameStatus.GameOver :
                Stop();
                break;
        }
    }
}