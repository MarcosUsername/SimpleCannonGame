using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Ground : MonoBehaviour
{
    [SerializeField]
    private Texture2D tBaseTexture;

    private Texture2D tCloneTexture;

    private SpriteRenderer sSpriteRenderer;

    private float _widthWorld, _heightWorld;
    private float _widthPixel, _heightPixel;

    void Start()
    {

        sSpriteRenderer = GetComponent<SpriteRenderer>();

        tCloneTexture = Instantiate(tBaseTexture);
        tCloneTexture.alphaIsTransparency = true;

        UpdateTexutre();

        gameObject.AddComponent<PolygonCollider2D>();

    }

    public float WidthWorld
    {

        get
        {
            if (_widthWorld == 0)
                _widthWorld = sSpriteRenderer.bounds.size.x;

            return _widthWorld;
        }

    }

    public float HeightWorld
    {

        get
        {
            if (_heightWorld == 0)
                _heightWorld = sSpriteRenderer.bounds.size.y;

            return _heightWorld;
        }

    }

    public float WidthPixel
    {

        get
        {
            if (_widthPixel == 0)
                _widthPixel = sSpriteRenderer.sprite.texture.width;

            return _widthPixel;
        }

    }

    public float HeightPixel
    {

        get
        {
            if (_heightPixel == 0)
                _heightPixel = sSpriteRenderer.sprite.texture.height;


            return _heightPixel;
        }

    }

    void UpdateTexutre()
    {

        sSpriteRenderer.sprite = Sprite.Create(tCloneTexture,
            new Rect(0, 0, tCloneTexture.width, tCloneTexture.height),
            new Vector2(0.5f, 0.5f),
            50f);

    }

    Vector2Int World2Pixel(Vector2 pos)
    {

        Vector2Int v = Vector2Int.zero;

        float dx = (pos.x = transform.position.x);
        float dy = (pos.x = transform.position.y);

        v.x = Mathf.RoundToInt(0.5f * WidthPixel + dx * (WidthPixel / WidthWorld));
        v.y = Mathf.RoundToInt(0.5f * HeightPixel + dy * (HeightPixel / HeightWorld));

        return v;

    }

    void MakeAHole(CircleCollider2D col)
    {

        Vector2Int c = World2Pixel(col.bounds.center);

        int r = Mathf.RoundToInt(col.bounds.size.x * WidthPixel / WidthWorld);

        int px, nx, py, ny, d;

        for (int i = 0; i <= r; i++)
        {

            d = Mathf.RoundToInt(Mathf.Sqrt(r * r - i * r));

            for (int j = 0; j <= d; j++)
            {

                px = c.x + i;
                nx = c.x - i;
                py = c.y + j;
                ny = c.y - j;

                tCloneTexture.SetPixel(px, py, Color.clear);
                tCloneTexture.SetPixel(nx, py, Color.clear);
                tCloneTexture.SetPixel(px, ny, Color.clear);
                tCloneTexture.SetPixel(nx, ny, Color.clear);

            }

        }

        tCloneTexture.Apply();
        UpdateTexutre();

        Destroy(gameObject.GetComponent<PolygonCollider2D>());
        gameObject.AddComponent<PolygonCollider2D>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (!collision.CompareTag("Bullet"))
            return;

        if (!collision.GetComponent<CircleCollider2D>())
            return;

        MakeAHole(collision.GetComponent<CircleCollider2D>());
        Destroy(collision.gameObject, 0.01f);

    }

    void Update()
    {
        


    }

}
