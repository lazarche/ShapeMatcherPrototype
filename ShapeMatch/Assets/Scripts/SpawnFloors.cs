using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloors : MonoBehaviour
{
    int minL = 10, maxL = 20;
    int lenght;
    public GameObject floor;
    public GameObject[] cuttouts;

    // Start is called before the first frame update
    void Start()
    {
        
        lenght = Random.Range(minL, maxL);

        for(int i = 0; i < lenght; i++) {
            GameObject temp = Instantiate(floor, new Vector3(0, -0.4f, i*10f), Quaternion.identity);


            if(i%2 == 0){
                Instantiate(cuttouts[Random.Range(0, cuttouts.Length)], new Vector3(0, 0, i*10f), Quaternion.Euler(0,180,0));
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
