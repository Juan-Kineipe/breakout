using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public AudioClip collisionAudio;

    private Rigidbody2D rb;
    private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respawn()
    {
        transform.position = new Vector3(0,-3.5f,0);
        rb.velocity = Random.insideUnitCircle.normalized * speed;
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.name == "Bottom Collider") {
            GameManager.instance.ShowGameOver();
        }
        audio.PlayOneShot(collisionAudio);
    }
}
