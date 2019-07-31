using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class AudioScript : MonoBehaviour
{

    public static AudioScript Instance;

    public AudioSource myAudio;

    public AudioClip Logo;
    public AudioClip Interface;
    public AudioClip start_Surface;
    public AudioClip CreateBuilding;

    
    public AudioClip ScanUser;
    
    // not found
    public AudioClip OpenDoor;
    public AudioClip CloseDoor;
    public AudioClip RobotMoveSound;
    public AudioClip RobotWelcome;
    public AudioClip ScanHealthUser;
    public AudioClip ShowReoprt;

    public AudioClip MakeFood;
    public AudioClip EatFood;
    public AudioClip ClearMachine;
    public AudioClip PeopleSound;

    void Awake()

    {

        if (Instance == null)
        {
            Instance = this;
        }
        else
            Destroy(this);
        DontDestroyOnLoad(gameObject);


    }



    public void PlaySound(string soundName)
    {
        switch (soundName)
        {
            case "Logo":
                myAudio.clip = Logo;
                break;

            case "Interface":
                myAudio.clip = Interface;
                break;

            case "start_Surface":
                myAudio.clip = start_Surface;
                break;

            case "CreateBuilding":
                myAudio.clip = CreateBuilding;
                break;

            case "ScanUser":
                myAudio.clip = ScanUser;
                break;

            case "OpenDoor":
                myAudio.clip = OpenDoor;
                break;

            case "CloseDoor":
                myAudio.clip = CloseDoor;
                break;

            case "RobotMoveSound":
                myAudio.clip = RobotMoveSound;
                break;

            case "RobotWelcome":
                myAudio.clip = RobotWelcome;
                break;

            case "ScanHealthUser":
                myAudio.clip = ScanHealthUser;
                break;

            case "ShowReoprt":
                myAudio.clip = ShowReoprt;
                break;

            case "MakeFood":
                myAudio.clip = MakeFood;
                break;

            case "EatFood":
                myAudio.clip = EatFood;
                break;

            case "ClearMachine":
                myAudio.clip = ClearMachine;
                break;
               
               case "PeopleSound":
               myAudio.clip = PeopleSound;
               break;
        }

        myAudio.Play();
    }

}
