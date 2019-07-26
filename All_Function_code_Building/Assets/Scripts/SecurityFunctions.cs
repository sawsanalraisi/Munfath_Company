using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecurityFunctions : MonoBehaviour
{

    //Security Part
    public Image stop_security;
     public GameObject Scan;
    //public GameObject ScanY;
    //public GameObject ScanG;
    public bool OnceTimeDone = true;
    public float TimeSce=2;


    //Robot Part




    void Start()
    {
     

    }

    void Update()
    {
        //public float Anmination;

        //Anmination += Time.deltaTime;
        //Anmination = Anmination % 5f;
        //Robot.transform.position = MathParabola.Parabola(Vector3.zero, Vector3.forward * 10f, 5f, Anmination / 5f);

    }
    void OnTriggerEnter(Collider other)
    {
        if (OnceTimeDone == true)
        {
            if (other.gameObject.tag == "SecurityTag")
            {
                //show stop security msg
                stop_security.gameObject.SetActive(true);
                StartCoroutine(SecurityFun());
            }

            if (other.gameObject.tag == "Rebort")
            {

             
                //welcome use (sound)
                //tall the use to check heath 
                //show heath report 
               //StartCoroutine(MsgWaitRebort());

               
            }

        //   OnceTimeDone = false;
        }
    }

   

    IEnumerator SecurityFun()
    {
        //hide stop security msg
        yield return new WaitForSeconds(2f);
        stop_security.gameObject.SetActive(false);

        //Here Scanner start
        Scan.SetActive(true);

        //Chech the user succefully 
        yield return new WaitForSeconds(10f);
        Scan.SetActive(false);

        // Open the Door 
        DataManger.Instance.IsAllowToOpenDoor = true;
    }



   


    IEnumerator MsgWaitRebort()
    {
        yield return new WaitForSeconds(1f);

            //bring Rebort 
            yield return new WaitForSeconds(3f);
            yield return new WaitForSeconds(4f);
            yield return new WaitForSeconds(5f);
            // Rebort follow camera
            yield return new WaitForSeconds(6f);

       


    }

}
