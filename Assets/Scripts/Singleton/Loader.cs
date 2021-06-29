using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class Loader: MonoSingleton<Loader>
{

    public  void Load(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    
}
