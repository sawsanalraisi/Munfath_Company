using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectFood : MonoBehaviour
{

    public GameObject FoodMenuScreen;

    public Button[] foodBtn;
    public GameObject[] foods;

    //  public Button LeftFoodBtn;
    //  public Button RightFoodBtn;

    void Start()
    {
        // LeftFoodBtn.onClick.AddListener(LeftFood);
        //  RightFoodBtn.onClick.AddListener(RightFood);
        foodBtn[0].onClick.AddListener(foodBtn1);
        foodBtn[1].onClick.AddListener(foodBtn2);
        foodBtn[2].onClick.AddListener(foodBtn3);
        foodBtn[3].onClick.AddListener(foodBtn4);

    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 150f))
        {
                //eat the food
                if (hit.transform.name == "food0")
                {
                    foods[0].SetActive(false);
                }
                else if (hit.transform.name == "food1")
                {
                    foods[1].SetActive(false);
                }
                else if (hit.transform.name == "food2")
                {
                    foods[2].SetActive(false);
                }
                else if (hit.transform.name == "food3")
                {
                    foods[3].SetActive(false);
                }

            }

        }

    }

 


    //select food
    public void foodBtn1()
    {
        foods[0].gameObject.SetActive(true);
    }
    public void foodBtn2()
    {
        foods[1].gameObject.SetActive(true);
    }
    public void foodBtn3()
    {
        foods[2].gameObject.SetActive(true);
    }
    public void foodBtn4()
    {
        foods[3].gameObject.SetActive(true);
    }


   
    //show Screen

    void OnTriggerEnter(Collider other)
    {

    if (other.gameObject.tag == "FoodScreen")
    {
        FoodMenuScreen.SetActive(true);
    }
    else 
    {
     FoodMenuScreen.SetActive(false);
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




