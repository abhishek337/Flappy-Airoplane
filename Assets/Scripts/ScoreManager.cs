using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text textMesh;
    public Text highScore;
    private float score;
    int highscore = 0;

    void Awake()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        highScore.text = "High Score : " + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       if(PlayerManager.isGameOver == false)
        {
            score += 1 * Time.deltaTime;
            textMesh.text = ((int)score).ToString();
            //Debug.Log("Update");
        }

        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", ((int)score));
        }
    }
}
