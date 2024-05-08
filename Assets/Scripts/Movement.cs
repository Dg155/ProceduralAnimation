using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 1f;

    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float multiplier = 1f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            multiplier = 2f;
        }

        if (_rigidbody.velocity.magnitude < movementSpeed * multiplier)
        {

            float value = Input.GetAxis("Vertical");
            if (value != 0)
                _rigidbody.AddForce(0, 0, value * Time.fixedDeltaTime * 1000f);
            value = Input.GetAxis("Horizontal");
            if (value != 0)
                _rigidbody.AddForce(value * Time.fixedDeltaTime * 1000f, 0f, 0f);
        }
    }
}
