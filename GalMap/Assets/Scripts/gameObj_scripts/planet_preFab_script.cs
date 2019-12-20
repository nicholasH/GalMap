using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet_preFab_script : MonoBehaviour
{
    public Material selectedColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)){
            // Whatever you want it to do.
            Debug.Log(this.name);
            this.GetComponent<SpriteRenderer>().material = selectedColor;
        }
    }
}
