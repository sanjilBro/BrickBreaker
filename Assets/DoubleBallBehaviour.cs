using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleBallBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject ball;

    

    void OnTriggerEnter2D(Collider2D collision2D)
    {
        if(collision2D.gameObject.CompareTag("paddle"))
        {
            Instantiate(ball, (Vector2)FindObjectOfType<Ball>().transform.position + (Vector2.down *2f), Quaternion.identity);
            Destroy(this.gameObject);
        }
    
    }
}
