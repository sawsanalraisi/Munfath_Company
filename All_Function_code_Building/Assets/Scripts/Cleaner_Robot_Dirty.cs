using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner_Robot_Dirty : MonoBehaviour
{
    [SerializeField]
    GameObject Dirty;

    float DirtyTimer = 1;

    public GameObject DirtyRobot;

   // List<GameObject> allDirtys;

    // Start is called before the first frame update
    void Start()
    {
       // allDirtys = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        DirtyTimer -= Time.deltaTime;
        if (DirtyTimer <= 0)
        {
            DirtyTimer = 1;
            //allDirtys.Add(Instantiate(Dirty, new Vector3(Random.Range(62.7f, 62.7f), -20.5f, Random.Range(201.5f, 201.5f)), Dirty.transform.rotation));
            Instantiate(Dirty, new Vector3(Random.Range(-62.7f,-62.7f), -20.5f, Random.Range(201.5f, 201.5f)), Dirty.transform.rotation);

        }

    }


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Dirty")
        {
             DirtyRobot.transform.position = Dirty.transform.position;
                Destroy(gameObject);
        }


    }
}