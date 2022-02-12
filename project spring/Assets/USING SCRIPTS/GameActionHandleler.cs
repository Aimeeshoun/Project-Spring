using UnityEngine;
using UnityEngine.Events;

public class GameActionHandleler : MonoBehaviour
{
    public GameAction2 gameAction;
   public UnityEvent handlerEvent;
    public float holdTime = 3f;
    private void Start()
    {
        gameAction.action += ActionHandler;
    }
    private void ActionHandler()
    {
        Invoke(nameof(OnActionHandler), holdTime);
    }
    private void OnActionHandler()
    {
        handlerEvent.Invoke();
    }

}