using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOfLife : MonoBehaviour {
    private int[,] WorldMap;
    private GameObject[,] CubeMap;
    public GameObject Cube;

    private const int cubes = 100;
    private const int cube_space = 1;

    void Start() {
        WorldMap = new int[cubes, cubes];
        CubeMap = new GameObject[cubes, cubes];

        for (int i = 0; i < cubes; i++) {
            for (int y = 0; y < cubes; y++) {
                WorldMap[i, y] = Random.Range(0, 2);
                CubeMap[i, y] = Instantiate(Cube, new Vector3(i * cube_space, y * cube_space, 0), Quaternion.identity);
            }
        }
    }

    void Update() {
        for (int i = 0; i < cubes; i++) {
            for (int y = 0; y < cubes; y++) {
                if (WorldMap[i, y] == 0) {
                    CubeMap[i, y].SetActive(false);
                } else {
                    CubeMap[i, y].SetActive(true);
                }
            }
        }
    }
}
