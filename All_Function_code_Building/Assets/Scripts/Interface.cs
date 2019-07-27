using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interface : MonoBehaviour
{

    public Button SkipBtn;
    public Button StartBtn;

    public Toggle Tog1;
    public Toggle Tog2;
    public Toggle Tog3;

    public Image Img1;
    public Image Img2;
    public Image Img3;


    // Start is called before the first frame update
    void Start()
    {
        SkipBtn.onClick.AddListener(SkipFun);
        StartBtn.onClick.AddListener(StartFun);

    }

    // Update is called once per frame
    void Update()
    {

        if(Tog1.isOn)
        {
            Img1.gameObject.SetActive(true);
            Img2.gameObject.SetActive(false);
            Img3.gameObject.SetActive(false);
        }
        else if (Tog2.isOn)
        {
            Img1.gameObject.SetActive(false);
            Img2.gameObject.SetActive(true);
            Img3.gameObject.SetActive(false);

        }
        else if (Tog3.isOn)
        {
            Img1.gameObject.SetActive(false);
            Img2.gameObject.SetActive(false);
            Img3.gameObject.SetActive(true);
        }




    }

    public void SkipFun()
    {
        StartBtn.gameObject.SetActive(true);
    }

    public void StartFun()
    {
        SceneManager.LoadScene("Functions");
    }
}
