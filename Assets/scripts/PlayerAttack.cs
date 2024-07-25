using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;



public class PlayerAttack : MonoBehaviour
{
    private Animator animator;
    public float atackrange = 1f;
    public float attackdamage = 5f;
    public LayerMask enemyLayers;
    public float attackAnimationDuration = 0.01f;
    private bool isAttacking = false;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Запускаем анимацию атаки только если не происходит атака в данный момент
        if (Input.GetMouseButtonDown(0) && !isAttacking)
        {
            StartCoroutine(PlayAttackAnimation());
        }
    }

    private IEnumerator PlayAttackAnimation()
    {
        isAttacking = true; // Устанавливаем флаг атаки

        // Включаем анимацию атаки
        animator.SetBool("Atack", true);

        // Ждем длительность анимации
        yield return new WaitForSeconds(attackAnimationDuration);

        // Отключаем анимацию атаки
        animator.SetBool("Atack", false);

        isAttacking = false; // Сбрасываем флаг атаки
    }
}