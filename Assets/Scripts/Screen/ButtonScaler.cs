using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ButtonScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float finalScale = 1.2f;
    public float scaleDuration = .1f;

    private Vector3 defaultScale;

    private Tween _currentTween;

    private void Awake()
    {
        defaultScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //transform.localScale = Vector3.one * 1.2f;
        _currentTween = transform.DOScale(defaultScale * finalScale, scaleDuration);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _currentTween.Kill();
        transform.localScale = defaultScale;
    }
}
