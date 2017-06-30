using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    enum Tiles
    {
        Amber,
        Emerald,
        Prism,
        Ruby,
        Sapphire
    }

    public GameObject amber;
    public GameObject emerald;
    public GameObject prism;
    public GameObject ruby;
    public GameObject sapphire;
    GameObject[] clones = new GameObject[40];
    int hej;
    
    private int[] tiles = new int[40];
    

    // Use this for initialization
    void Start()
    {
        //GetDiamondType(5, 3);
        PutDiomondsInPlace();
        Debug.Log(clones[17].transform.position.x.ToString());
        //GetDiamondType(Random.Range(1, 5), 5, 1.5f, 0);
    }

    void PutDiomondsInPlace()
    {
        float x = 0;
        float y = 0;
        int moveX = 0;
        for (int i = 0; i < 40; i++)
        {
            GetDiamondType(Random.Range(1, 6), i, x, y);
            y += -1.2F;
            moveX++;
            if(moveX > 7)
            {
                x += 1.2F;
                y = 0;
                moveX = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetDiamondType(int type, int index, float x, float y)
    {
        // Amber Instance
        if(type == 1)
        {
            clones[index] = Instantiate(amber, new Vector2(x, y), Quaternion.Euler(0, 0, 0)) as GameObject;
        }

        // Emerald Instance
        if (type == 2)
        {
            clones[index] = Instantiate(emerald, new Vector2(x, y), Quaternion.Euler(0, 0, 0)) as GameObject;
        }

        // Prism Instance
        if (type == 3)
        {
            clones[index] = Instantiate(prism, new Vector2(x, y), Quaternion.Euler(0, 0, 0)) as GameObject;
        }

        // Ruby Instance
        if (type == 4)
        {
            clones[index] = Instantiate(ruby, new Vector2(x, y), Quaternion.Euler(0, 0, 0)) as GameObject;
        }

        // Sapphire Instance
        if (type == 5)
        {
            clones[index] = Instantiate(sapphire, new Vector2(x, y), Quaternion.Euler(0, 0, 0)) as GameObject;
        }
    }


}
