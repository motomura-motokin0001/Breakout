using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField]
    private float _speed;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Move();
    }
    void Move()
    {
        _rb.linearVelocity = new Vector3(_speed, _speed, 0);
    }

}
