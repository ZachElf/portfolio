using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class GameImageZoom : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private RectTransform rectTransform;
    private Vector3 originalPosition, originalScale;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originalPosition = rectTransform.localPosition;
        originalScale = rectTransform.localScale;

        // The Image wil be the last in the hierarchy, so it will overlap everything below it in the scene
        transform.SetAsLastSibling();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        rectTransform.localScale = new Vector3(1, 1, 0);
        rectTransform.localPosition = new Vector3(0, 0, 0);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        rectTransform.localPosition = originalPosition;
        rectTransform.localScale = originalScale;
    }
}
