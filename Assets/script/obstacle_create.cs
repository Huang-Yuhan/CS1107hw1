using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_create : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject[] boxarray;
    const int box_max_size=10;
    int prex=0;
    Vector3 GenerateBoxPositon()
    {
        prex-=16;
        return new Vector3(prex,2,Random.Range(-8f,8f));
    }
    public void restart()
    {
        prex=0;
        foreach(GameObject obj in boxarray)
        {
            obj.transform.position=GenerateBoxPositon();
        }
    }
    void Start()
    {
        GameObject[] tmp=new GameObject[5];
        tmp[0]=Resources.Load("prefabs/obstacle1") as GameObject;
        tmp[1]=Resources.Load("prefabs/Obstacle1 1") as GameObject;
        tmp[2]=Resources.Load("prefabs/Obstacle2") as GameObject;
        tmp[3]=Resources.Load("prefabs/Obstacle3") as GameObject;
        tmp[4]=Resources.Load("prefabs/Obstacle4") as GameObject;
        for(int i=1;i<=box_max_size;i++)
        {
            //boxarray.Add(tmp);
            GameObject.Instantiate(tmp[i%5],GenerateBoxPositon(),Quaternion.identity);
            prex-=16;
        }
        boxarray=GameObject.FindGameObjectsWithTag("Obstacle");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position);
        foreach(GameObject obj in boxarray)
        {
            if(obj.transform.position.x>transform.position.x+8)
            {
                //Debug.Log("position1");
                //Debug.Log(obj.transform.position);
                obj.transform.position=GenerateBoxPositon();
                //Debug.Log("position2");
               // Debug.Log(obj.transform.position);
            }
        }
    }

}
