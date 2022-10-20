using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchDirection : MonoBehaviour
{
    public GameObject directionUI;
    public Camera m_Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BranchUI();
    }

    public void BranchUI()//��������������ʱ������λ�ó���������������UI
    {
        if(Input.GetMouseButtonDown(0))
        {
            //directionUI.SetActive(true);
            Ray ray = m_Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.DrawLine(ray.origin, hit.point);
                GameObject gameobj = hit.collider.gameObject;
                if ((gameobj.tag == "Branch2") || (gameobj.tag == "Branch3") || (gameobj.tag == "Branch4"))
                {
                    directionUI.transform.position = Input.mousePosition;
                    directionUI.SetActive(true);
                }
            }
        }
    }
}
