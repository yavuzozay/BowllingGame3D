﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("lobutHead"))
        {
            Debug.Log(other.gameObject.transform.parent.gameObject);
            Destroy(other.gameObject.transform.parent.gameObject);
            GameManage.Instance.score++;
            
        }
    }
  
  
  
}
