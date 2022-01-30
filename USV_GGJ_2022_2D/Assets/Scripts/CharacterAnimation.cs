using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]

public class CharacterAnimation : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
      animator = GetComponent<Animator>();
      spriteRenderer = GetComponent<SpriteRenderer>();
    }

 }
