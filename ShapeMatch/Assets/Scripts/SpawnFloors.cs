using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloors : MonoBehaviour
{
    int minL = 3, maxL = 4;
    int lenght;
    public GameObject[] chunks;

    public GameObject endChunk;

    // Start is called before the first frame update
    void Start()
    {
        
        lenght = Random.Range(minL, maxL);
        Instantiate(chunks[0], new Vector3(0, -0.5f, 0), Quaternion.identity);
        int draza = 0;
        for (int i = 1; i < lenght; i++) {
            GameObject temp = Instantiate(chunks[Random.Range(0, chunks.Length)], new Vector3(0, -0.5f, i*60f), Quaternion.identity);
            draza = i;
        }
        draza++;
        GameObject d = Instantiate(endChunk, new Vector3(0, -0.5f, draza*60f), Quaternion.identity);
        this.GetComponent<GameM>().startDist = endChunk.transform.position.z;
        this.GetComponent<GameM>().endObj = d;
    }

}
