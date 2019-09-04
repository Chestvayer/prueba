using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCursor : MonoBehaviour
{
    public int Tamaño = 32;
    public Texture2D cursorNormal;
    Texture2D cursorActivo;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        CambiarCursor("normal");

    }

    public void CambiarCursor(string tipoCursor)
    {
        if (tipoCursor == "normal")
        {
            cursorActivo = cursorNormal;
        }
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, Tamaño, Tamaño), cursorActivo);
    }
}
