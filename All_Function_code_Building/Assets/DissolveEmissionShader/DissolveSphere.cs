using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveSphere : MonoBehaviour {

    Material mat;
    Logo Logo;

    private void Start() {
        mat = GetComponent<Renderer>().material;
        //mat.SetFloat("_DissolveAmount", Mathf.Sin(Time.time) / 2 + 0.5f);

    }


     void Update() {

      
        mat.SetFloat("_DissolveAmount", Mathf.Sin(Time.time) / 2 + 0.5f);

    }



   
}