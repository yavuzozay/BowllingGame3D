using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallControl : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float speed;
    float tempSpeed;
    bool canControl= true;
    
    

    Vector3 firstPosition;
    Quaternion firstRotation;
    
    bool a;

    private void Awake()
    {
        
        
        firstPosition = gameObject.transform.position;
        
        firstRotation = gameObject.transform.rotation;
        tempSpeed = speed;
        a = false;
    }
   
    void Update()
    {
        Debug.Log("kalan" + GameManage.kalanHak);


        if (a)
            StartCoroutine(Next());


    }
    float abc = 0;
    int temp = 0;
    float sure = 0;
    private void FixedUpdate()
    {
    
        Control();
        if (Input.GetKey(KeyCode.N))
            SceneManager.LoadScene(1);
    }
  

    void Control()
    {
        if (canControl)
        {
            float x = 0;
            sure += Time.deltaTime;


            Debug.Log("sure"+sure);

            
            x = Mathf.Cos(sure*8)/2;
            Debug.Log(x);
            transform.position += new Vector3(x, 0, 0);
            if (Input.GetKey(KeyCode.Space))

            {
              

                rigidbody.constraints = RigidbodyConstraints.None;
                speed = tempSpeed;

                rigidbody.AddForce(speed * gameObject.transform.forward);
                speed = 0;
                sure = 0;
                canControl = false;
                a = true;
                GameManage.kalanHak--;

            }

        }
     
    }
    IEnumerator Next()
    {
        a = false;


        yield return new WaitForSeconds(2.5f);


        rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        // yield return new WaitForSeconds(1.0f);
        gameObject.transform.position = firstPosition;
        gameObject.transform.rotation = firstRotation;
        GameManage.GameControl();
      
        canControl = true;



    }

}
