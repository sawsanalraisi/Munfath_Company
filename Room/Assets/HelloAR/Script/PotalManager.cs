using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PotalManager : MonoBehaviour
{

    public GameObject MainCamera;
    public GameObject Sponza;
    private Material[] SponzaMaterials;
    // Start is called before the first frame update
    void Start()
    {
        SponzaMaterials = Sponza.GetComponent<Renderer>().sharedMaterials;
    }


     void OnTriggerStay(Collider collider)
    {

        Vector3 camPositionInPortalSpace = transform.InverseTransformPoint(MainCamera.transform.position);

        if(camPositionInPortalSpace.y<0.5f)
        {
            for(int i=0;i<SponzaMaterials.Length;i++)
            {
                SponzaMaterials[i].SetInt("_stencilComp",(int)CompareFunction.Always);
            }

        }
        else
        {
            for (int i = 0; i < SponzaMaterials.Length; i++)
            {
                SponzaMaterials[i].SetInt("_stencilComp", (int)CompareFunction.Equal);
            }


        }

    }














}
