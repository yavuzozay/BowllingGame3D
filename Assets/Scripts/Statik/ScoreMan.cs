using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMan : MonoBehaviour
{
    private static ScoreMan _instance;
    public int skor = 0;

  
    public static ScoreMan Instance()
    {
       
            if(_instance==null)
            {
                _instance = FindObjectOfType < ScoreMan>();
                if(_instance==null)
                {
                    _instance = new GameObject("Score Manager").AddComponent<ScoreMan>();
                }

            }
            return _instance;

        
    }
    private void Awake()
    {

        if (_instance != null) Destroy(this);
        DontDestroyOnLoad(this);
        
    }
   



}
