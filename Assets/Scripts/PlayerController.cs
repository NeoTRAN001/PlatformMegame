using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public float horizantalInput = 0f;
    public float speed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        BasicMovement();
    }

    void FixedUpdate() {
        playerMovement.Move(horizantalInput * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Cherry")
            HandlerItem(other.gameObject.tag, other);
    }

    private void BasicMovement() {
        horizantalInput = Input.GetAxisRaw("Horizontal");
        if(Input.GetButtonDown("Jump")) playerMovement.Jump();
    }

    private void HandlerItem(string itemName, Collider2D other) {
        Destroy(other.gameObject);
    }
}
