using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public   class GameManage :MonoSingleton<GameManage>
{

  
    public  int kalanHak =2;
    public int score=0;

  

    public   void GameControl()
    {
        
        if (kalanHak <= 0)
        {
            Loader.Instance.Load(2);
            kalanHak = 2;
        }
        if (score==10 && kalanHak==1)
        {
            kalanHak = 2;
            Loader.Instance.Load(2);
            score += 5;


        }

    }
}
