using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private InputActionAsset _Input;
    [SerializeField] private float _speed;
    private Rigidbody2D _rb;
    private Vector3 _velocity;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue Value)
    {
        var axis = Value.Get<Vector2>();
        _velocity = new Vector3(axis.x, 0, axis.y);
    }

    private void Update()
    {
        if(GameManager.instance.Status == GameStatus.Play)
        {
            _rb.linearVelocity = _velocity * _speed;
        }
    }
}
