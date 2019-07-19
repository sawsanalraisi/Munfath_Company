using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectFood : MonoBehaviour
{
    public GameObject food1;
    public GameObject food2;
    public GameObject food3;

    public bool IsFood = false;
    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            // show spisific distance 
                if (hit.transform.name == "food1Sel")
                {
                  //  food1.SetActive(true);
                   // IsFood = true;
                    print("Have a good meal");
                }
                else if (hit.transform.name == "food2Sel")
                {
                    //food2.SetActive(true);
                    //IsFood = true;
                    print("Have a good meal");
                }
                else if (hit.transform.name == "food3Sel")
                {
                   // food3.SetActive(true);
                    //IsFood = true;
                    print("Have a good meal");
                }
              
            }
           /* else
            {
                print("Take Your Foods");

                if (hit.transform.name == "food1")
                {
                    food1.SetActive(false);
                }
                else if (hit.transform.name == "food2")
                {
                    food2.SetActive(false);
                }
                else if (hit.transform.name == "food2")
                {
                    food3.SetActive(false);
                }

            }*/


        }

    }

