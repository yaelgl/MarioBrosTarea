using System;
using Unity.VisualScripting;
using UnityEngine;

public class ElementoMoneda : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        void OnTriggerEnter2D(Collider2D collision )
        {
            if (collision.CompareTag("Player"))
            {

                // Exlosion 
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                gameObject.GetComponent<SpriteRenderer>().enabled=false;
                Destroy(gameObject, 0.3f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
