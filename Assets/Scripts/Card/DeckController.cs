using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckController : MonoBehaviour
{
    public GameObject Carta;
    public int tamanho;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < tamanho; i++)
        {
            Instantiate(Carta, this.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
