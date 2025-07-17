using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;

public class UIAnimations : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private float startPosY;
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (gameObject.name.Contains("Play") || gameObject.name.Contains("Exit"))
            UIHoverScale(1.2f);
        else if (!gameObject.name.Contains("Settings"))
            UIHoverMove(10f);
        else
            UIHoverRotate();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (gameObject.name.Contains("Play") || gameObject.name.Contains("Exit"))
            UIHoverScale(1f);
        else if (!gameObject.name.Contains("Settings"))
            UIHoverMove(-(transform.position.y - startPosY));
    }

    private void Start()
    {
        startPosY = transform.position.y;
    }

    private void UIHoverMove(float distance)
    {
        transform.DOMoveY(transform.position.y + distance, 0.5f);
    }

    private void UIHoverRotate()
    {
        transform.DORotate(new Vector3(0, 0, 360f), 2.5f, RotateMode.WorldAxisAdd);
    }

    private void UIHoverScale(float size)
    {
        transform.DOScale(size, 0.2f);
    }
}