using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartaController : MonoBehaviour
{
    public bool selected;
    // Start is called before the first frame update
    void Start()
    {
        selected = false;
    }

    public void Select(){
        if(selected){
            selected = false;
        }else{
            selected = true;
        }
    }
    void Update()
    {
        if(selected){
            transform.localPosition = Vector2.up;
        }else{
            transform.localPosition = Vector2.zero;
        }
    }
}
