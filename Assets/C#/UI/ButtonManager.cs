using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public AudioSource butonsespanali;
    public AudioClip Butonsesi;

    public int sahne = 0;
    private bool duraklatma = false;
    public GameObject MenuPanel;
    public void MenuButton()
    {
        butonsespanali.PlayOneShot(Butonsesi);
        SceneManager.LoadScene(0);
    }
    public void RestartButton()
    {
        butonsespanali.PlayOneShot(Butonsesi);
        SceneManager.LoadScene(sahne);
    }
    public void Durdur()
    {
        if (!duraklatma)
        {
            butonsespanali.PlayOneShot(Butonsesi);
            MenuPanel.SetActive(true);
            Time.timeScale = 0;
            duraklatma = true;
        }
        else
        {
            butonsespanali.PlayOneShot(Butonsesi);
            MenuPanel.SetActive(false);
            Time.timeScale = 1;
            duraklatma = false;
        }
    }
}