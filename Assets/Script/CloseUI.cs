using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUI : MonoBehaviour
{
    public GameObject growUI;
    public GameObject directionUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseGrowUI()//�ر�GrowChooseUI
    {
        growUI.SetActive(false);
    }

    public void CloseDirectionUI()
    {
        directionUI.SetActive(false);
    }
}
