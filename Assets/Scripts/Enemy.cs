using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Renderer rend;
    private Color originalColor;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }
    public virtual void OnMouseEnter()
    {
        HoverAction();
    }

    public virtual void OnMouseExit()
    {
        ResetHover();
    }

    public virtual void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LeftClickAction();
        }

        if (Input.GetMouseButtonDown(1))
        {
            RightClickAction();
        }
    }

    public virtual void HoverAction()
    {

        rend.material.color = originalColor * 1.5f;
        Debug.Log("Hráč najel myší na nepřítele.");
    }

    public virtual void ResetHover()
    {
        rend.material.color = originalColor;
    }

    public virtual void LeftClickAction()
    {
        Debug.Log("Hráč klikl LEVÝM na nepřítele.");
    }

    public virtual void RightClickAction()
    {
        Debug.Log("Hráč klikl PRAVÝM na nepřítele.");
    }
}

