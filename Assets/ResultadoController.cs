using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultadoController : MonoBehaviour
{
    public TMP_Text Placar;
    public TMP_Text Oponente;
    // Start is called before the first frame update
    void Start()
    {
        Placar.text = "x";
        Oponente.text = "" + "vs.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
