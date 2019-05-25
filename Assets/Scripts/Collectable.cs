namespace h1ddengames.twodrpg.statistics
{
    using UnityEngine;
    
    [RequireComponent(typeof(BoxCollider2D), typeof(Animator))]
    public class Collectable : MonoBehaviour {
        [SerializeField] private float respawnTime = 4f;
        [SerializeField] private BoxCollider2D boxCollider;
        [SerializeField] private Animator animator; 

        private void OnEnable() {
            if(boxCollider == null) {
                boxCollider = gameObject.GetComponent<BoxCollider2D>();
            } else if(animator == null) {
                animator = gameObject.GetComponent<Animator>();
            }    
        }

        private void OnTriggerEnter2D(Collider2D other) {
            if(other.gameObject.tag.Equals("Player")) {
                // Immediately set to false or the player can get a huge jump boost from landing on the collider.
                // Even if the collider is set to IsTrigger.
                boxCollider.enabled = false;
                animator.SetBool("IsCollected", true);
                var clipInfo = animator.GetCurrentAnimatorClipInfo(0);
                Invoke("FinishAnimation", clipInfo[0].clip.length);
            }    
        }

        private void FinishAnimation() {
            animator.SetBool("IsCollected", false);
            gameObject.SetActive(false);
            if(respawnTime != 0) {
                Invoke("Respawn", respawnTime);
            }
        }

        private void Respawn() {
            boxCollider.enabled = true;
            gameObject.SetActive(true);
        }
    }
}