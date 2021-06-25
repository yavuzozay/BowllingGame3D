using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("lobutHead"))
        {
            Debug.Log(other.gameObject.transform.parent.gameObject);
            Destroy(other.gameObject.transform.parent.gameObject);
            ScoreMan.Instance().skor++;
        }
    }
    // Update is called once per frame
  
}
