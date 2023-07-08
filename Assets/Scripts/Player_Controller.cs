using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb2d;
    private float _moveInput;
    private float _speed = 10f;

    void Update()
    {
        _moveInput = Input.GetAxis("Horizontal");
        _rb2d.velocity = new Vector2(_moveInput * _speed, _rb2d.velocity.y);
    }
}
