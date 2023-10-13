using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Line : MonoBehaviour
{
    [SerializeField] private LineRenderer _lineRenderer;

    [SerializeField] private EdgeCollider2D _edgeCollider;

    private readonly List<Vector2> _points = new List<Vector2>();

    void Start()
    {
        _edgeCollider.transform.position -= transform.position;
    }

    public void setposition(Vector2 pos)
    {
        if (!candraw(pos)) return;

        _points.Add(pos);

        _lineRenderer.positionCount++;
        _lineRenderer.SetPosition(_lineRenderer.positionCount-1,pos);

        _edgeCollider.points = _points.ToArray();
    }

    private bool candraw(Vector2 pos)
    {
        if (_lineRenderer.positionCount == 0) return true;

        return Vector2.Distance(_lineRenderer.GetPosition(_lineRenderer.positionCount - 1), pos) > Draw_manager.resolution;
    }
}
