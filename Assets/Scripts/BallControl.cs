using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallControl : MonoBehaviour
{
     Rigidbody rigidbody;
    public float speed;
    float tempSpeed;
    bool canControl= true;
    private int maxHak=2;
    
    

    Vector3 firstPosition;
    Quaternion firstRotation;
    
    bool a;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        
        firstPosition = gameObject.transform.position;
        
        firstRotation = gameObject.transform.rotation;
        tempSpeed = speed;
        a = false;
    }
   
    void Update()
    {


        if (a)
            StartCoroutine(Next());


    }
    
    private void FixedUpdate()
    {
    
        Control();
        
    }

    float x = 0;
    void Control()
    {
        if (canControl)
        {
            x += Time.fixedDeltaTime * 2;
            

            Debug.Log(x);
            transform.position += new Vector3(Mathf.Cos(x*2)/3, 0, 0);
            if (Input.GetKey(KeyCode.Space))

            {
              

                rigidbody.constraints = RigidbodyConstraints.None;
                speed = tempSpeed;

                rigidbody.AddForce(speed * gameObject.transform.forward);
                speed = 0;
               
                canControl = false;
                a = true;
                GameManage.Instance.kalanHak--;

            }
            

        }
     
    }
    IEnumerator Next()
    {
        a = false;

        x = 0;

        yield return new WaitForSeconds(5.5f);


        rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        gameObject.transform.position = firstPosition;
        gameObject.transform.rotation = firstRotation;

        GameManage.Instance.GameControl();
        canControl = true;





    }

}
