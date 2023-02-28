using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScaleReducer : MonoBehaviour
{
    public GameObject prefab;
     float waitSeconds;
     float waitSecondsStart;
    float cameraPosX;
     float cameraPosY;
    
    void Update()
    {
        waitSeconds = Random.Range(20,30);
        
    
    }
    
    void Start()
    {
        waitSecondsStart = Random.Range(20,30);
       Invoke("StartSpawningObject",waitSecondsStart);

    }
    void StartSpawningObject(){
 StartCoroutine(SpawnObject());
    }
    
    IEnumerator SpawnObject()
    {
        while (true)
        {
            SpawnRandomObject();
            yield return new WaitForSeconds(waitSeconds);
        }
    }
    

    
    void SpawnRandomObject()
    {
    cameraPosX = Camera.main.transform.position.x + Random.Range(-10,-1);
    cameraPosY = Camera.main.transform.position.y + 50;
    GameObject newPrefab = Instantiate(prefab, new Vector3(cameraPosX, cameraPosY, 0), Quaternion.identity);
    float randomZRotation = Random.Range(-45f, 45f);
    newPrefab.transform.rotation = Quaternion.Euler(0, 0, randomZRotation);

   
    }
 
}
