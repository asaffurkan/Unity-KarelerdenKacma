using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    private hingscore gm;
    public float _moveSpeed;
    private Vector2 _movement;


    void Start() {
        gm = hingscore.FindObjectOfType<hingscore>();
    }
    void FixedUpdate()
    {   
        //sağ sol yokarı aşağı
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical"); 
    }

    void Update() {

        rb.velocity = new Vector2(
            _movement.x * _moveSpeed,
            _movement.y * _moveSpeed
        );

        rb.velocity.Normalize();


    }

  

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag != "Enemy") {
            gm._score++;
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "Enemy") {
            gm.GameOver();
        }
    }
}
