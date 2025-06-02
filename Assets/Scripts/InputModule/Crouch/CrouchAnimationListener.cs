using UnityEngine;

public class CrouchAnimationListener : MonoBehaviour
{
    [SerializeField] private AnimationDriver animationDriver;

    private void OnEnable()
    {
        EventBus.Subscribe<PlayerCrouchEvent>(OnCrouch);
        EventBus.Subscribe<PlayerUncrouchEvent>(OnUncrouch);
    }

    private void OnDisable()
    {
        EventBus.Unsubscribe<PlayerCrouchEvent>(OnCrouch);
        EventBus.Unsubscribe<PlayerUncrouchEvent>(OnUncrouch);
    }

    private void OnCrouch(PlayerCrouchEvent evt)
    {
        animationDriver.SetBool("IsCrouching", true);
    }

    private void OnUncrouch(PlayerUncrouchEvent evt)
    {
        animationDriver.SetBool("IsCrouching", false);
    }

}
