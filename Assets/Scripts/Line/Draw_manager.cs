using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw_manager : MonoBehaviour
{
    private Camera _camera;
    [SerializeField] private Line lineprefab;

    public const float resolution = 0.01f;

    private Line currentline;


    void Start()
    {
        _camera = Camera.main;
    }


    void Update()
    {
        Vector2 mousepos = _camera.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) currentline = Instantiate(lineprefab, mousepos, Quaternion.identity);

        if (Input.GetMouseButton(0)) currentline.setposition(mousepos);
    }
}
