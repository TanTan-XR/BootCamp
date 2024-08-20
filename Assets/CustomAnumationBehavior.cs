using UnityEngine;

public class CustomAnimationBehavior : StateMachineBehaviour
{
    // This method is called when the state is first entered
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Insert behavior when the animation starts
        Debug.Log("Animation State Entered: " + stateInfo.fullPathHash);
        // Example: Detach animation by disabling
        animator.enabled = false;
    }

    // This method is called once per frame while in the state
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Insert behavior that needs to happen every frame during the animation
    }

    // This method is called when exiting the state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Insert behavior when the animation ends
        Debug.Log("Animation State Exited: " + stateInfo.fullPathHash);
    }
}

