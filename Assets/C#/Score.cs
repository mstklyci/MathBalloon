using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int Can = 3;
    public int Puan = 0;
    public GameObject Can1;
    public GameObject Can2;
    public GameObject Can3;
    //Text
    public GameObject SonPuan;
    public Text PuanText;
    public Text PuanilkText;
    private float kronometrebasla;
    //Sesler
    public AudioSource audioSource;
    public AudioClip DogruSesi;
    public AudioClip KacSesi;
    public AudioClip YanlisSesi;
    void Start()
    {
        Time.timeScale = 1f;
        UpdateScore();
        kronometrebasla = Time.time;
    }
    void Update()
    {
        if (Puan > PlayerPrefs.GetInt("_highscore5") && Puan < PlayerPrefs.GetInt("_highscore4"))
        {
            PlayerPrefs.SetInt("_highscore5", Puan);
        }
        else if (Puan > PlayerPrefs.GetInt("_highscore4") && Puan < PlayerPrefs.GetInt("_highscore3"))
        {
            PlayerPrefs.SetInt("_highscore4", Puan);
        }
        else if (Puan > PlayerPrefs.GetInt("_highscore3") && Puan < PlayerPrefs.GetInt("_highscore2"))
        {
            PlayerPrefs.SetInt("_highscore3", Puan);
        }
        else if (Puan > PlayerPrefs.GetInt("_highscore2") && Puan < PlayerPrefs.GetInt("_highscore1"))
        {
            PlayerPrefs.SetInt("_highscore2", Puan);
        }
        else if (Puan > PlayerPrefs.GetInt("_highscore1"))
        {
            PlayerPrefs.SetInt("_highscore1", Puan);
        }
        else
        {
        }
        if (Can < 1)
        {
            Can1.SetActive(false);
            Can2.SetActive(false);
            Can3.SetActive(false);
            SonPuan.gameObject.SetActive(true);
            Time.timeScale = 0;
            PuanText.text = "Puan:" + Puan.ToString();
        }
        else if (Can >= 1 && Can <2)
        {
            Can1.SetActive(true);
            Can2.SetActive(false);
            Can3.SetActive(false);
        }
        else if (Can >= 2 && Can < 3)
        {
            Can1.SetActive(true);
            Can2.SetActive(true);
            Can3.SetActive(false);
        }
        else if (Can >= 3)
        {
            Can3.SetActive(true);
            Can2.SetActive(true);   
            Can1.SetActive(true);
        }
        Puan = (int)(Time.time - kronometrebasla);
        PuanilkText.text = Puan.ToString();
    }
    private void UpdateScore()
    {
        if (Can > 4) 
        {
            Can = 4;
        }
    }
    public void DogruPuan()
    {
        Can += 1;
        audioSource.PlayOneShot(DogruSesi);
        UpdateScore();            
    }
    public void YanlisPuan()
    {
        Can -= 1;
        audioSource.PlayOneShot(YanlisSesi);
        UpdateScore();
    }
    public void DogruYokOl()
    {
        Can -= 2;
        audioSource.PlayOneShot(KacSesi);
        UpdateScore();
    }
    public void YanlisYokOl()
    {
        Can += 1;
        UpdateScore();       
    }
}