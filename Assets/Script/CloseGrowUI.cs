using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGrowUI : MonoBehaviour
{
    public GameObject closeGrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseUI()//�ر�GrowChooseUI
    {
        closeGrow.SetActive(false);
    }
}
