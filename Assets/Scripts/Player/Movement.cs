
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    public Rigidbody body;
    public bool canMove = true;
    public bool canRotate = false;

    Vector3 rotation;
    Vector3 movement;

    int index = 0;

    public float playerSpeed = 4f;
    public float rotationSpeed;

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        if (canMove)
        {
            if (canRotate)
            {
                Quaternion rotation;
            }
            movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical"));
            transform.position += movement * playerSpeed;
        }

        else if (!canMove)
        {
            movement = new Vector3(0, 0);
            transform.position = movement * 0.0f;
        }
    }
}