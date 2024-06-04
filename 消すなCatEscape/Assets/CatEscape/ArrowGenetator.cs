using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenetator : MonoBehaviour
{
    public GameObject arrowPrefed;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("GameDirector").GetComponent<GameDirector>().IsGameOver())
        {
            Destroy(this);
            return;
        }
        this.delta += Time.deltaTime;
        if(this.delta>this.span)
        {
            this.delta=0;
            GameObject go=Instantiate(arrowPrefed);
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
