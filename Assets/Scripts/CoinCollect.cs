using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using Unity.Mathematics;
using UnityEngine;


public class CoinCollect : MonoBehaviour
{
    public GameObject CoinParticle;

    public ParticleSystem CoinParticleSystem;

    private int coinCount = 0 ;
    [SerializeField] private TMP_Text CoinText;
    
    
    
    void SpawnCoinParticle()
    {
        GameObject spawnedObj = Instantiate(CoinParticle,transform.position,quaternion.identity,transform);
        Destroy(spawnedObj,2f);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            CoinParticleSystem.Play();
            
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        //
        // Instantiate(ParticlePrefab, gameObject.transform.position, quaternion.identity);
        // Destroy(gameObject);
        //
        if (other.CompareTag("Player"))
        {
            SpawnCoinParticle();
            Destroy(gameObject);
            coinCount++; // 1 oluyor ve başka coin toplasam bile değişmiyor.

            CoinText.text = "Coins : " + coinCount;

            //Debug.LogError("Coin : " + coinCount);
        }
    }

    
}
