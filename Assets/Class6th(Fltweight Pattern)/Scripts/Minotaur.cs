using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minotaur : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] AnimatorStateInfo animatorStateInfo;

    private Coroutine coroutine;

    private void Awake()
    {
        animator = GetComponent<Animator>();

        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
    }

    private void Start()
    {
        coroutine = StartCoroutine(Paranoia());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(coroutine != null)
            {
                StopCoroutine(coroutine);
            }

            coroutine = StartCoroutine(Paranoia());
        }
    }
    private IEnumerator Smash()
    {
        animator.SetTrigger("Smash");

        AnimatorClipInfo[] clipInfos = animator.GetCurrentAnimatorClipInfo(0);

        yield return CorutineCache.GetCachedWait(AnimatorClipInfo[0].clip.Length);
    }

    private IEnumerator Damnation() 
    {
        animator.SetTrigger("Damnation");

        AnimatorClipInfo[] clipInfos = animator.GetCurrentAnimatorClipInfo(0);

        yield return CorutineCache.GetCachedWait(AnimatorClipInfo[0].clip.Length);
    }
    
    private IEnumerator Paranoia()
    {
        animator.SetTrigger("Paranoia");

        

        AnimatorClipInfo[] clipInfos = animator.GetCurrentAnimatorClipInfo(0);

        yield return CorutineCache.GetCachedWait(AnimatorClipInfo[0].clip.Length);
    }
}
