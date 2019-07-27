using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner_Robot_Dirty : MonoBehaviour
{
    [SerializeField]
    GameObject Dirty;

    float DirtyTimer = 3;

    List<GameObject> allDirtys;

    // Start is called before the first frame update
    void Start()
    {
        allDirtys = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        DirtyTimer -= Time.deltaTime;
        if (DirtyTimer <= 0)
        {
            DirtyTimer = 3;
            allDirtys.Add(Instantiate(Dirty, new Vector3(Random.Range(-978f, -0.16f), -72.9f, Random.Range(-1268, -0.16f)), Dirty.transform.rotation));
        }
    }
 

}
