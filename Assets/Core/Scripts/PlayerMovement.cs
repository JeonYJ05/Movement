using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _speed = 5;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>(); 
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Move(h, v);
    }

    private void Move(float h , float v)
    {
        // transform.forward(z) 값에다가 v(수직 값)을 곱한다.
        // a * -1 또는 1사이 값이 계산되는데, 계산된 값을 가지고 축으로 사용한다 (Axis)
        Vector3 dir = transform.forward * v + transform.right * h;
        Vector3 speed = _speed * Time.deltaTime * dir.normalized;

        _rigidbody.MovePosition(transform.position + speed);
    }

}
