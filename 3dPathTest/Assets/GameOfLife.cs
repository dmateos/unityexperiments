using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOfLife : MonoBehaviour {
    public GameObject Cube;
    private int[,] _stateMap;
    private GameObject[,] _cubeMap;
    private const int _cubeCount = 100;
    private const int _cubeSpacing = 1;

    void Start() {
        _stateMap = new int[_cubeCount, _cubeCount];
        _cubeMap = new GameObject[_cubeCount, _cubeCount];

        for (int i = 0; i < _cubeCount; i++) {
            for (int y = 0; y < _cubeCount; y++) {
                _stateMap[i, y] = Random.Range(0, 2);
                _cubeMap[i, y] = Instantiate(Cube, new Vector3(i * _cubeSpacing, y * _cubeSpacing, 0), Quaternion.identity);
            }
        }
    }

    void Update() {
        ComputeLife();

        for (int i = 0; i < _cubeCount; i++) {
            for (int y = 0; y < _cubeCount; y++) {
                if (_stateMap[i, y] == 0) {
                    _cubeMap[i, y].SetActive(false);
                } else {
                    _cubeMap[i, y].SetActive(true);
                }
            }
        }
    }

    void ComputeLife() {
        for (int i = 0; i < _cubeCount; i++) {
            for (int y = 0; y < _cubeCount; y++) {
                _stateMap[i, y] = Random.Range(0, 2);
            }
        }
    }

    int GetNeighbourState(int x, int y, string direction) {
        switch (direction) {
            case "north":
                return _stateMap[x, y--];
            case "east":
                return _stateMap[x++, y];
            case "south":
                return _stateMap[x, y++];
            case "west":
                return _stateMap[x--, y];
        }
        return 0;
    }
}
