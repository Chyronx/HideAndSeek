using UnityEngine;

public class RenkAyarlama : MonoBehaviour
{

    public GameObject blok;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        blok.GetComponent<Renderer>().material.color = Color.red;   
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            blok.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            blok.GetComponent<Renderer>().material.color = Color.yellow;
        }

       
        
    }
}
