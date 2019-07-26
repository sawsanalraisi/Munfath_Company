using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManger 
{
    private static DataManger instance;

    public bool IsAllowToOpenDoor = false;

    public int FoodId=0;

    public static DataManger Instance
    {
        get
        {
            if (instance == null)
                instance = new DataManger();

            return instance;

        }


    }


}
