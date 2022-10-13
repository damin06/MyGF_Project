using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int Score;
    [SerializeField]private TextMeshProUGUI socreTXT;
    void Start()
    {
        PlayerPrefs.SetInt("score", 0);
    }

    // Update is called once per frame
    void Update()
    {
        Score = PlayerPrefs.GetInt("score");
        socreTXT.text = Score.ToString();
    }
}
