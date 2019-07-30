using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecurityFunctions : MonoBehaviour
{

    //Security Part
    public Image stop_security;
     public GameObject Scan;
     public GameObject ScanG;

    //public GameObject ScanY;
    //public GameObject ScanG;
    public bool OnceTimeDone = true;
    public float TimeSce=2;



    //Robot Part
    public List<Transform> waypoints = new List<Transform>();
    private Transform targetWaypoint;
    private int targetWaypointIndex = 0;
    private float minDistance = 0.1f; //If the distance between the enemy and the waypoint is less than this, then it has reacehd the waypoint
    private int lastWaypointIndex;
    // private float movementSpeed = 5.0f;
    private float movementSpeed = 10f;
    private float rotationSpeed = 2.0f;
    public bool IsMoveRobot = true;

    public GameObject Robot;//once



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
           

        //OnceTimeDone = false; //once time done functions
        }
    }

  

    //Security 
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
        ScanG.SetActive(true);
        yield return new WaitForSeconds(10f);
        ScanG.SetActive(false);

        // Open the Door 
        DataManger.Instance.IsAllowToOpenDoor = true;
    }



  
}
