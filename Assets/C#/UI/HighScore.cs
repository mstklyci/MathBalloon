using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text _highscore1;
    public Text _highscore2;
    public Text _highscore3;
    public Text _highscore4;
    public Text _highscore5;
    void Start()
    {
        _highscore1.text = PlayerPrefs.GetInt("_highscore").ToString();
        _highscore2.text = PlayerPrefs.GetInt("_highscore2").ToString();
        _highscore3.text = PlayerPrefs.GetInt("_highscore3").ToString();
        _highscore4.text = PlayerPrefs.GetInt("_highscore4").ToString();
        _highscore5.text = PlayerPrefs.GetInt("_highscore5").ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
}