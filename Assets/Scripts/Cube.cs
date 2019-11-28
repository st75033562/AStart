
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public delegate void VoidDelegate(int x, int y);
    public VoidDelegate FindPath;

    private void OnMouseDown()
    {
        if (FindPath != null)
        {
            FindPath((int)this.transform.localPosition.x, (int)this.transform.localPosition.y);
        }
    }
}