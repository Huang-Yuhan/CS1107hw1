using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class game_controll : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI text;
    public GameObject Player;
    
    bool IsNeedRestart;
    void Start()
    {
       // GameLose();
    }

    // Update is called once per frame
    void Update()
    {
        if(IsNeedRestart)
        {
            if(Input.GetKeyDown(KeyCode.R))GameRestart();
        }   
    }
    void GameRestart()
    {
        IsNeedRestart=false;
        text.text="";
        Player.transform.position=new Vector3(0,1,0);
        Player.GetComponent<obstacle_create>().restart();
    }
    public void GameLose()
    {
        text.text="you lose\n Press R to restart";
        IsNeedRestart=true;
    }
}
