using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour
{

    public AudioSource music;                                           //for music playthrough
    
    public float moveSpeed;
    public Rigidbody2D rb2d;
    private Vector2 moveInput;

    public SpriteRenderer CharacterSprite;                             //for accessing the sprite and flipping
    public bool timerTriggered = false;
    private bool musicPlayed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        //CharacterSprite = GetComponent<SpriteRenderer>();             //done in inspector
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        rb2d.velocity = moveInput * moveSpeed;

        if (moveInput.x < 0)
        {
            CharacterSprite.flipX = true;
        }
        else if (moveInput.x > 0)
        {
            CharacterSprite.flipX = false;
        }
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (!timerTriggered)
        {
            Debug.Log("Timer trigger");
            timerTriggered = true;
            music.Play();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy encountered");
            SceneManager.LoadScene("OverScene");
        }
    }
}
