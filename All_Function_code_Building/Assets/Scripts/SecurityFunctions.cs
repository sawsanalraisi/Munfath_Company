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


    //Rebort Part
    public Image MsgNeedHelp;
    public Button YesRebort;
    public Button NoRebort;
    public Image MsgYesRebort;
    public Image MsgNoRebort;
    public int YN;

    Transform Orighinalrebortbady;
    public GameObject rebortbady;
    public GameObject welcomeRobot;

    void Start()
    {
        //need infuture
       // Orighinalrebortbady = GameObject.FindGameObjectWithTag("rebortbady").transform;
    }

    void Update()
    {
      
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
                MsgNeedHelp.gameObject.SetActive(true);
                YesRebort.onClick.AddListener(YesRebortFun);
                NoRebort.onClick.AddListener(NoRebortFun);
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
       // ScanY.gameObject.SetActive(true);


        //Scan the user (red)
         //yield return new WaitForSeconds(4f);
        //Scan change color(green)
       // ScanY.gameObject.SetActive(false);
        //ScanG.gameObject.SetActive(true);


        //Chech the user succefully 
        yield return new WaitForSeconds(10f);
        Scan.SetActive(false);
        // ScanG.gameObject.SetActive(false);
        DataManger.Instance.IsAllowToOpenDoor = true;
        // Open the Door (check if open or not)
    }



    void YesRebortFun()
    {
        MsgNeedHelp.gameObject.SetActive(false);
        MsgYesRebort.gameObject.SetActive(true);

        StartCoroutine(MsgWaitRebort());
        YN = 1;

        //rebort came from spisicf place  here
    }


    void NoRebortFun()
    {
        MsgNeedHelp.gameObject.SetActive(false);
        MsgNoRebort.gameObject.SetActive(true);
        StartCoroutine(MsgWaitRebort());
        YN = 2;
    }


    IEnumerator MsgWaitRebort()
    {
        yield return new WaitForSeconds(1f);

        if (YN == 1)
        {
            MsgYesRebort.gameObject.SetActive(false);
            //bring Rebort 
            yield return new WaitForSeconds(3f);
            rebortbady.SetActive(true);
            yield return new WaitForSeconds(4f);
            welcomeRobot.SetActive(true);
            yield return new WaitForSeconds(5f);
            welcomeRobot.SetActive(false);
            // Rebort follow camera
            yield return new WaitForSeconds(6f);
            rebortbady.transform.SetParent(Camera.main.transform);

        }

        else if (YN == 2)
        { 
        MsgNoRebort.gameObject.SetActive(false);
        
        }


    }

}
