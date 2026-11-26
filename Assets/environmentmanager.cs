using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class environmentmanager : MonoBehaviour
{

    public GameObject[] paredes;
    public Pared[] pared;

    // Start is called before the first frame update
    void Start()
    {
        paredes = GameObject.FindGameObjectsWithTag("Pared");
        pared = FindObjectsOfType<Pared>();
        Mostrarprecios();
        DesactivarParedes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    void Mostrarprecios(){
        for (int i = 0; i < pared.Length; i++){
            pared[i].precio = UnityEngine.Random.Range(0, 100);
        }
    }

    void DesactivarParedes(){
        for (int i = 0; i < paredes.Length; i++){
            paredes[i].SetActive(false);
        }
    }
    
}
