using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDoAction : MonoBehaviour
{

    public GameObject CubeMove;
    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray,out hit))
        {
            if(hit.transform.name== "p1")
            {
                CubeMove.transform.position = new Vector3(transform.position.x, transform.position.y+1f, transform.position.z);
            }
            else if (hit.transform.name == "p2")
            {
                CubeMove.transform.position = new Vector3(transform.position.x, transform.position.y -1f, transform.position.z);

            }
            else if(hit.transform.name == "p3")
            {
                CubeMove.transform.position = new Vector3(transform.position.x - 1f, transform.position.y , transform.position.z);

            }
            else if (hit.transform.name == "p4")
            {
                CubeMove.transform.position = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);

            }
        }

    }
}
