using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultSceneScript : MonoBehaviour
{
    [SerializeField] Text yourScore;

    private void Awake()
    {
        yourScore.text = "Score  :  "+ScoreMan.Instance().skor.ToString();

    }
    private void Start()
    {
        ScoreMan.Instance().skor = 0;
    }
    
    public void PlayAgain()
    {
        Loader.Load(1);
    }
}
