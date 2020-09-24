using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

     // Handle Player movement
    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontal, 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
    }
}
