using UnityEngine;

public class Zombie : Enemy
{

    public override void RightClickAction()
    {
        Destroy(gameObject);
    }

    public override void LeftClickAction() 
    {
        Debug.Log ("Mozky!!");
    }

}
