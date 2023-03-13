using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreator : MonoBehaviour
{
    public LineRenderer LineRenderer;

    public List<GameObject> LineDoubles;

    private void Start()
    {
        LineRenderer = GetComponent<LineRenderer>();
        
        LineRenderer.SetPosition(0, LineDoubles[0].transform.position);
        LineRenderer.SetPosition(1,LineDoubles[1].transform.position);
    }
}
