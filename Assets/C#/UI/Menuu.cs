using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuu : MonoBehaviour
{
    public GameObject islemler;
    public AudioSource audioSource;
    public AudioClip GirisSesi;
    public AudioClip BaslamaSesi;
    public void Play()
    {
        islemler.SetActive(true);
        audioSource.PlayOneShot(GirisSesi);
    }
    public void Toplama()
    {
        SceneManager.LoadScene(1);
        audioSource.PlayOneShot(BaslamaSesi);
    }
    public void Cikarma()
    {
        SceneManager.LoadScene(2);
        audioSource.PlayOneShot(BaslamaSesi);
    }
    public void Carpma()
    {
        SceneManager.LoadScene(3);
        audioSource.PlayOneShot(BaslamaSesi);
    }
    public void Bolme()
    {
        SceneManager.LoadScene(4);
        audioSource.PlayOneShot(BaslamaSesi);
    }
    public void Mod()
    {
        SceneManager.LoadScene(5);
        audioSource.PlayOneShot(BaslamaSesi);
    }
    public void Siralama()
    {
        SceneManager.LoadScene(6);
        audioSource.PlayOneShot(GirisSesi);
    }
    public void Quit()
    {
        Application.Quit();
        audioSource.PlayOneShot(GirisSesi);
    }
}