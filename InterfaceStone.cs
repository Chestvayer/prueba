using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceStone : MonoBehaviour
{
    public Text textThrow;
    public Text textDestroyed;
    public Text vida;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textThrow.text = "Number of Stone: " + GameManager.CurrentNumberStoneThrow;
        textThrow.text = "Vida:" + GameManager.CurrentVida;
        textDestroyed.text = "Destroyed: " + GameManager.CurrentNumberDestroyStone;


    }
}
