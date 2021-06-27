using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public   class GameManage
{

  
    public static int kalanHak=2 ;


    public  static void GameControl()
    {
        
        if (kalanHak <= 0)
        {        
            Loader.Load(2);
            kalanHak = 2;
        }
        if (ScoreMan.Instance().skor == 10 && kalanHak>0)
        {
            ScoreMan.Instance().skor += 5;
            Loader.Load(2);

        }

    }
}
