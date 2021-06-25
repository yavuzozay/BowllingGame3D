using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{

    private static GameManage _instance;
    private int _count = 0;

    public int count
    {
        get { return _count; }
        set { _count = value; }
    }
    public static GameManage Instance()
    {

        if (_instance == null)
        {
            _instance = FindObjectOfType<GameManage>();
            if (_instance == null)
            {
                _instance = new GameObject("Game Manager").AddComponent<GameManage>();
            }

        }
        return _instance;


    }
}
