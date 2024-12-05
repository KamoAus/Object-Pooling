using UnityEngine;

public class RandomiseColour : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    private Color color;

    private void Start()
    {
        color = new Color(Random.Range(1, 255) / 255f, Random.Range(1, 255) / 255f, Random.Range(1, 255) / 255f);
    }

    private void Update()
    {
        spriteRenderer.color = color;
    }
}
