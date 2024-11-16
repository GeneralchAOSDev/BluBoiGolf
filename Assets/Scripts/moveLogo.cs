using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core;

public class moveLogo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Sequence doTweenSeq = DOTween.Sequence();

        doTweenSeq.Append(transform.DOMoveX(0.04f, 0.5f).SetEase(Ease.InOutSine));
        doTweenSeq.Insert(1f, transform.DOScale(new Vector3(6, 6, 3), 2.5f).SetEase(Ease.OutElastic));
        doTweenSeq.Insert(2f, transform.DOScale(new Vector3(3, 1, 2), 1.5f).SetEase(Ease.OutElastic));
        doTweenSeq.Insert(2f, transform.DOScale(new Vector3(5, 7, 8), 1.5f).SetEase(Ease.OutElastic));
        doTweenSeq.SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
