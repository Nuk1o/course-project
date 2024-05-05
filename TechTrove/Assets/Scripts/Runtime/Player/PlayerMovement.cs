using UnityEngine;
using Zenject;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private Animator _animator;
    private Vector2 _movement;
    private void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
        
        _animator.SetFloat("Horizontal",_movement.x);
        _animator.SetFloat("Vertical",_movement.y);
        _animator.SetFloat("Speed",_movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + _movement * _moveSpeed * Time.fixedDeltaTime);
    }
}
