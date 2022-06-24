using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello world");
        for(int x = 0; x < 100; x++) {
            for(int z = 0; z < 100; z++) {
                Instantiate(cube, new Vector3(x, Mathf.PerlinNoise((float)x/50, (float)z/50)*100-100, z), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
