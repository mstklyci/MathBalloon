using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class BalonYokedici : MonoBehaviour
{
    //Animasyonlar
    //Text
    private Score score;
    private void Start()
    {
        score= FindObjectOfType<Score>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("YokEdici"))
        {
            Destroy(gameObject);
            if (gameObject.CompareTag("Dogru"))
            {
                score.DogruYokOl();
            }
            if (gameObject.CompareTag("Yanlis"))
            {
                score.YanlisYokOl();
            }
        }
    }
    private void OnDestroy()
    {
        if (gameObject.CompareTag("Dogru"))
        {
            score.DogruPuan();
        }
        if (gameObject.CompareTag("Yanlis"))
        {
            score.YanlisPuan();
        }
    }
}