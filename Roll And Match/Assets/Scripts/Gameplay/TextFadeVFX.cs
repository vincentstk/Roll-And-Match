using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Zenject;
using TMPro;

public class TextFadeVFX : MonoBehaviour
{
    [Inject] UIPooler _UIPooler;
    public TextMeshProUGUI txt;
    private const string NOTI = "Noti";
    public void StartVFX(string noti, int index)
    {
        txt.rectTransform.anchoredPosition = new Vector2(0f, -200f - index * 20);
        txt.SetText(noti);
        txt.DOFade(1f, 0f);
        txt.rectTransform.DOAnchorPosY(txt.rectTransform.anchoredPosition.y + 100, 0.5f);
        txt.DOFade(0f, 1.5f).OnComplete(OnFaded);
    }
    private void OnFaded()
    {
        _UIPooler.ReturnToPoolWithOldParent(NOTI, gameObject, true);
    }
}
