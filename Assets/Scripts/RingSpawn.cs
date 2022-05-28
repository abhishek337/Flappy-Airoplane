using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpawn : MonoBehaviour
{
    public float maxTime = 1;
    private float Timer = 0;
    public GameObject Ring;
    public float height;


    // Start is called before the first frame update
    void Start()
    {
        GameObject newRing = Instantiate(Ring);
        newRing.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer > maxTime)
        {
            GameObject newRing = Instantiate(Ring);
            newRing.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newRing, 10);
            Timer = 0;
        }

        if(PlayerManager.isGameOver == true)
        {
            gameObject.SetActive(false);
        }

        Timer += Time.deltaTime;     
    }
}
