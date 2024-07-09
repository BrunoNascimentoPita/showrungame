using UnityEngine;
using UnityEngine.EventSystems;

public class CursorChanger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Texture2D cursorTexture;
    public Vector2 hotSpot = Vector2.zero;
    private Texture2D defaultCursorTexture;
    private Vector2 defaultHotSpot;

    private void Start()
    {
        // Salvar a textura e o ponto ativo do cursor padrão
        defaultCursorTexture = null;
        defaultHotSpot = Vector2.zero;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Mudar o cursor quando o ponteiro entra no botão
        Cursor.SetCursor(cursorTexture, hotSpot, CursorMode.Auto);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Restaurar o cursor padrão quando o ponteiro sai do botão
        Cursor.SetCursor(defaultCursorTexture, defaultHotSpot, CursorMode.Auto);
    }
}
