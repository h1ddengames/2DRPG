namespace h1ddengames.twodrpg.gameplay
{
    using UnityEngine;
    
    [RequireComponent(typeof(Animator))]
    public class Collectable : MonoBehaviour {
        [SerializeField] private float respawnTime = 4f;
        [SerializeField] private BoxCollider2D boxCollider;
        [SerializeField] private Animator animator; 
        AnimatorClipInfo[] clipInfo;

        private void OnEnable() {
            Setup();
        }

        [ContextMenu("Setup This Collectable Object")]
        public void Setup() {
            if(boxCollider == null) {
                // The boxCollider MUST be on the same gameobject as this script.
                // If it is on a child gameobject then even with isTrigger enabled, 
                // the character will still interact physically with it.
                boxCollider = gameObject.GetComponent<BoxCollider2D>();
                
                if(boxCollider == null ) {
                    // If the gameobject has no boxCollider on it already,
                    // then add the boxCollider to the same gameobject as this script.
                    boxCollider = gameObject.AddComponent<BoxCollider2D>();
                }

                // Collider must have isTrigger enabled for script based animation changing.
                boxCollider.isTrigger = true;
            } 
            
            if(animator == null) {
                // Animator will always be on the same gameobject as this script.
                animator = gameObject.GetComponent<Animator>();
            } 

            if(animator.runtimeAnimatorController == null) {
                Debug.LogWarning("Item: " + name + " is missing a runtime animation controller. Assign it or make one.");
            }
        }

        private void OnTriggerEnter2D(Collider2D other) {
            if(other.gameObject.tag.Equals("Player")) {
                // Immediately set to false or the player can get a huge jump boost from landing on the collider.
                // Even if the collider is set to IsTrigger.
                boxCollider.enabled = false;
                animator.SetBool("IsCollected", true);
                clipInfo = animator.GetCurrentAnimatorClipInfo(0);
                // 0.8f is about the time it takes to play the item_feedback animation.
                if(clipInfo[0].clip.length > 0.8f) {
                    Invoke("FinishAnimation", 0.8f);   
                } else {
                    Invoke("FinishAnimation", clipInfo[0].clip.length);   
                }     
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