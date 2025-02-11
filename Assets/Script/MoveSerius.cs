using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveSerius : MonoBehaviour
{
    public int MoveSpeed;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
        animator.SetInteger("State", 1);
    }
}