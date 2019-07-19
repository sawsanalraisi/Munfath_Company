using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDoorOpenAndClose : MonoBehaviour
{

    Animator animator;
    bool doorOpen;

    private void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
    }


    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
            doorOpen = true;
            Doors("Open");
        }
    }

  


    void OnTriggerExit(Collider col)
    {

        if (doorOpen)
        {
            doorOpen = false;
            Doors("Close");
        }
    }

    void Doors(string direction)
    {
        animator.SetTrigger(direction);
    }

    /* 
      // open and Close Door
      public GameObject AutoDoor;
      public GameObject AutoDoorLeft;
      public GameObject AutoDoorRight;

      Animator LeftDoorAnim;
      Animator rightDoorAnim;
      public bool AutoDoorOpen = false;

      // Start is called before the first frame update
      void Start()
      {
          LeftDoorAnim = AutoDoorLeft.GetComponent<Animator>();
          rightDoorAnim = AutoDoorRight.GetComponent<Animator>();
      }


      void OnTriggerEnter(Collider other)
      {

          if (other.gameObject.tag == "Player")
          {
              slideDoor(true);

          }
      }


      void OnTriggerExit(Collider other)
      {

              if (other.gameObject.tag == "player")
              {
                  slideDoor(false);
              }

      }

      void slideDoor(bool state)
      {
          rightDoorAnim.SetBool("slide", state);
          LeftDoorAnim.SetBool("slide", state);

      }

      */

}
