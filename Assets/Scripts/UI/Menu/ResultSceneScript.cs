using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultSceneScript : MonoBehaviour
{
    [SerializeField] Text yourScore;

    private void Awake()
    {
        yourScore.text = "Score  :  "+ GameManage.Instance.score.ToString();

    }
    private void Start()
    {
        GameManage.Instance.score = 0;
    }
    
    public void PlayAgain()
    {
        Loader.Instance.Load(1);
    }
}
