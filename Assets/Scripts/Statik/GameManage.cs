using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static  class GameManage
{

  
    private static int _kalanHak=2 ;

    public static int kalanHak
    {
        get { return _kalanHak; }
        set { _kalanHak = value; }
    }

    

    public  static void GameControl()
    {
        if (_kalanHak <= 0)
            Loader.Load(1);
    }
}
