using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCreate1 : MonoBehaviour
{
    public GameObject[] TileCollition;
    public List<Transform> TileCollitionTrans;
    public GameObject[] prefab;
    Animator animator;
    int CreateName;
    bool Collision1,Collision2;
    public bool a = false;
    // Start is called before the first frame update
    void Start()
    {
        Collision1 = false;
        Collision2 = false;
        animator = GetComponent<Animator>();
        animator.Play("Tile Animation");
    }

    // Update is called once per frame
    private void Update()
    {
        TileChildren();
        TileCollitionInPut();
    }

    public void TileCollitionInPut()
    {
        if(a == true)
        {
            if(Collision1 != true) 
            {
                TileCollitionTrans.Add(TileCollition[0].transform);
            }
            if(Collision2 != true) 
            {
                TileCollitionTrans.Add(TileCollition[1].transform);

            }
            a = false;TileCreate();
        }
    }

    public void TileCreate()
    {
        for(int i = 0; i < 3; i++) 
        {
            if(TileCollitionTrans[i] != null)
            {
                Quaternion randomRotation = Quaternion.Euler(0f, 0f, 0f);//第三个为Z轴
                Instantiate(prefab[CreateName],TileCollitionTrans[i].position,randomRotation);
            }
        }
    }

    private void TileChildren()
    {
        Collision1 = TileCollition[0].GetComponent<TileChildrenCollision>().Collision;
        Collision2 = TileCollition[1].GetComponent<TileChildrenCollision>().Collision;
        //Collision3 = TileCollition[2].GetComponent<TileChildrenCollision>().Collision;
        //Collision4 = TileCollition[3].GetComponent<TileChildrenCollision>().Collision;
        Debug.Log(Collision1);
    }
}
