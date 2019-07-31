using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logo : MonoBehaviour
{
    public float Speed=10.0f;

    //public GameObject TopologyRobot;
    public GameObject Robot;
    // public GameObject parent;

    Material mat;


    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
    
           

        // Robot.GetComponent<Renderer>().enabled = false;
       StartCoroutine(TopologyRobotFun());

     
    }


    IEnumerator TopologyRobotFun()
    {
        yield return new WaitForSeconds(0f);
        transform.transform.Rotate(new Vector3(0f, 0f, 1f) * Speed * Time.deltaTime);
        mat.SetFloat("_DissolveAmount", Mathf.Sin(Time.time) / 2 + 0.5f);
        yield return new WaitForSeconds(0.5f);
        Robot.SetActive(true);
        gameObject.SetActive(false);

        // Robot.transform.parent = parent.transform.parent;
        // Robot.transform.SetParent(parent.transform, true);
        //TopologyRobot.SetActive(false);
        //Robot.SetActive(true);



    }




}
