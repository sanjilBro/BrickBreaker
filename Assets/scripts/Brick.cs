using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    
    public int points = 1;

            // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

        void OnCollisionEnter2D(Collision2D collision2D)
        {
            if(collision2D.gameObject.CompareTag("ball"))
            {
            FindObjectOfType<AudioManager>().PlayImpactSound(0);
            Destroy(this.gameObject);
            }
        }
}
     