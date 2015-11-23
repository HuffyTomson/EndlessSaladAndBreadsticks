using UnityEngine;
using System.Collections;

public class Motor : MonoBehaviour
{
    private Vector3 inputDirection;
    public Vector3 velocity;
    public float drag = 0.98f;
    public float acceleration = 0.5f;

    void FixedUpdate()
    {
        velocity += inputDirection * acceleration;
        inputDirection = Vector3.zero;
        velocity *= drag;
        transform.position += velocity;
    }

    public void InputDirection(Vector2 _direction)
    {
        inputDirection = _direction;
    }
}
