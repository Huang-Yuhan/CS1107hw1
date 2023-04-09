using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class hit_triiger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        GameObject gamecontroller=GameObject.FindGameObjectWithTag("GameController");
        gamecontroller.GetComponent<game_controll>().GameLose();
    }
}
