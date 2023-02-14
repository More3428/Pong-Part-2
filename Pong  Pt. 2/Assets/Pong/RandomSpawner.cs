using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomspawn = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
            Instantiate(prefab, randomspawn, Quaternion.identity); 
        }
    }
}
