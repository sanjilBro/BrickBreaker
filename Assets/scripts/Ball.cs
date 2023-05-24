using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public event System.Action OnBrickCollision;
    [SerializeField] private new Rigidbody2D rigidbody;
    public float speed =250f;
     private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(SetRandomTrajectory),1f);
    }


    private void SetRandomTrajectory()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-1f , 1f);
        force.y = -1f;
        this.rigidbody.AddForce(force*this.speed);
    }

    
    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if(collision2D.gameObject.CompareTag("brick"))
        {
            OnBrickCollision?.Invoke();
        }
    }
    
}
