using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawRectangle : MonoBehaviour
{
    public Vector2 size = new Vector2(50, 50);

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector2 center = transform.position;
        float width = size.x / 3f;
        for(int i = 0; i < 3; i++)
        {
            
            Gizmos.DrawWireCube(center, size);
        }
        
    }
}
