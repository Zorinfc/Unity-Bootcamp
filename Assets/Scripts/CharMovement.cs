using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CharMovement : MonoBehaviour
{ 
    public float speed = 5f;
    public float jumpSpeed = 8f;
    private float direction = 0f;
    
    public Rigidbody2D player;
    private Animator anim;
    private SpriteRenderer sprite;
    
    public Vector3 respawnPoint;
    public GameObject fallDetector;
    public ParticleSystem PlayerWalkingparticleSystem;
    public ParticleSystem.MainModule PlayerWalkingParticleSystemMainModule;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        
        respawnPoint = transform.position;

        PlayerWalkingParticleSystemMainModule = PlayerWalkingparticleSystem.main;
    }

    void Update()
    {
        direction = Input.GetAxis("Horizontal");

        if (direction > 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
            anim.SetBool("running",true);
            sprite.flipX = false;
        }
        else if (direction < 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
            anim.SetBool("running",true);
            sprite.flipX = true;    // Player'ın yürüdüğü yöne rotate eder.
        }
        else
        {
            player.velocity = new Vector2(0, player.velocity.y);
            anim.SetBool("running",false);

        }

        if (Input.GetButtonDown("Jump"))
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
            PlayerWalkingparticleSystem.Stop();
        }

        
        UpdateAnimation();
        fallDetector.transform.position = new Vector2(transform.position.x,fallDetector.transform.position.y);
    }

    private void UpdateAnimation()
    {
        if (direction > 0f)
        {
            anim.SetBool("running",true);
        }
        else if (direction < 0f)
        {
            anim.SetBool("running",true);
        }
        else
        {
            anim.SetBool("running",false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            anim.SetBool("running",false);
            anim.SetBool("jumping",true);
        }
        
    }

    // Particle sistemi yere temas ettiğinde çalışmasını sağlıyor.
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Terrain"))
        {
            PlayerWalkingparticleSystem.Play();
            anim.SetBool("jumping",false); //player yere değdiğinde false değeri verecek ve bunu kullanarak zıplama animasyonunu yapacağım.
        }
    }

    
    // Haritadan aşağı düşünce karakteri respawn pointe götürüyor.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "FallDetector")
        {
            transform.position = respawnPoint;
        }
    }
}
