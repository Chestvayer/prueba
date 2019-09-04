using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceAwake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.CurrentNumberDestroyStone = 0;
        GameManager.CurrentNumberStoneThrow = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void click()
    {
        Application.LoadLevel("stone game");
    }
}
