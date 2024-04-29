namespace AnodeHeart;

public class DialogueMover : MonoBehaviour
{
    public void LateUpdate()
    {
        if (DialogueController.Main.InDialogue || DialogueController.IsInDialogue || DialogueController.controllers.Any(a => a.InDialogue))
        {
            transform.localPosition = transform.localPosition with {y = -15};
        }
    }
}