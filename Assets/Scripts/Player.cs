using UnityEngine;
public class Player : MonoBehaviour

{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;
    public float gravity = -18f; 
    public float strength = 7f;
    private Vector3 velocityVector;


    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);        
    }
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }

        spriteRenderer.sprite = sprites[spriteIndex];
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            velocityVector = new Vector3(0f, 1f, 0f) * strength;
            Debug.Log("Player go up");
        }

        velocityVector.y += gravity * Time.deltaTime;
        transform.position += velocityVector * Time.deltaTime;


    }
}   
