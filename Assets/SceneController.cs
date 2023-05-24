using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject power_Double;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPowerUp());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnPowerUp(){
        yield return new WaitForSeconds(5f);
        float xrand = Random.Range(-paddle.screenSizeX,paddle.screenSizeX);
        Vector2 spawnPos = new Vector2(xrand,paddle.screenSizeY);
        Instantiate(power_Double,spawnPos,Quaternion.identity);
        StartCoroutine(SpawnPowerUp());
    }
}
