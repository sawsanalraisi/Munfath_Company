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

        if(Input.GetMouseButtonDown(0))
        {     
       
         RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit,150f))
            {

                // show spisific distance 

                if (IsFood == false)
                {

                    if (hit.transform.name == "food1Sel")
                    {
                        food1.SetActive(true);
                        food1.transform.position = new Vector3(-42.3f, 15.7f, 11.7f);
                        IsFood = true;
                        print("Have a good meal");
                    }
                    else if (hit.transform.name == "food2Sel")
                    {
                        food2.SetActive(true);
                        food2.transform.position = new Vector3(-42.3f, 15.7f, 11.7f);
                        IsFood = true;
                        print("Have a good meal");
                    }
                    else if (hit.transform.name == "food3Sel")
                    {
                        food3.SetActive(true);
                        food3.transform.position = new Vector3(-42.3f, 15.7f, 11.7f);
                        IsFood = true;
                        print("Have a good meal");
                    }

                }
                else
                {
                    if (hit.transform.name == "food1")
                    {
                        food1.SetActive(false);
                        IsFood = false;

                    }
                    else if (hit.transform.name == "food2")
                    {
                        food2.SetActive(false);
                        IsFood = false;

                    }
                    else if (hit.transform.name == "food3")
                    {
                        food3.SetActive(false);
                        IsFood = false;

                    }


                }

            }

        }
    }
}



/*

void EatFoodFun()
{
    if (Input.GetMouseButtonDown(0))
    {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {

            if (IsFood == true)
            {

                if (hit.transform.name == "food1")
                {
                    food1.SetActive(false);
                    IsFood = false;
                }
                else if (hit.transform.name == "food2")
                {
                    food2.SetActive(false);
                    IsFood = false;


                }
                else if (hit.transform.name == "food2")
                {
                    food3.SetActive(false);
                    IsFood = false;
                }
            }

        }
    }
}*/




