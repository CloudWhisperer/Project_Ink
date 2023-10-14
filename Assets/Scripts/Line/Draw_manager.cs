using UnityEngine;

public class Draw_manager : MonoBehaviour
{
    private Camera _camera;
    [SerializeField] private Line lineprefab;

    [SerializeField] private AudioSource draw;

    private Pause pausescript;

    public const float resolution = 0.01f;

    private Line currentline;


    void Start()
    {
        _camera = Camera.main;
        pausescript = GameObject.FindObjectOfType<Pause>();
    }


    void Update()
    {
        if (pausescript.is_paused == false)
        {
            Vector2 mousepos = _camera.ScreenToWorldPoint(Input.mousePosition);

            if (Input.GetMouseButtonDown(0))
            {
                currentline = Instantiate(lineprefab, mousepos, Quaternion.identity);
                drawsfx();
            }

            if (Input.GetMouseButtonUp(0)) { drawsfxno(); }

            if (Input.GetMouseButton(0)) currentline.setposition(mousepos);

        }
    }

    public void drawsfx()
    {
        draw.Play();
    }

    public void drawsfxno()
    {
        draw.Stop();
    }
}
