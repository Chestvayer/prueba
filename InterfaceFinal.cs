using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InterfaceFinal : MonoBehaviour
{
    public Text textThrow;
    public Text textDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textThrow.text = "Number of Stone: " + GameManager.CurrentNumberStoneThrow;
        textDestroyed.text = "Destroyed: " + GameManager.CurrentNumberDestroyStone;

    }
    public void Click()
    {
        Application.LoadLevel("Awake");
    }
}
