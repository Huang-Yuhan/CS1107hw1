using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_moving : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizonInput;
    public float verticalInput;
    float speed=20.0f;

    Vector3 forward=new Vector3(-1,0,0);
    Vector3 right =new Vector3(0,0,1);

    bool IsOK()
    {
        if(transform.position.y<0)return false;
        return true;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(IsOK()==false)
        {
            GameObject gamecl=GameObject.FindGameObjectWithTag("GameController");
            gamecl.GetComponent<game_controll>().GameLose();
        }
        //Debug.Log(transform.position);
        horizonInput=Input.GetAxis("Horizontal");
        verticalInput=Input.GetAxis("Vertical");
        transform.Translate(right*speed*Time.deltaTime*horizonInput);
        transform.Translate(forward*speed*Time.deltaTime*verticalInput);
    }
}
