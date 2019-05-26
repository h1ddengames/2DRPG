namespace h1ddengames.twodrpg.gameplay
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    public class Ouch : MonoBehaviour
    {
        [SerializeField] private float invincibilityTime = 2f;
        [SerializeField] private BoxCollider2D boxCollider;
         

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
        }

        private void OnTriggerEnter2D(Collider2D other) {
            if(other.gameObject.tag.Equals("Player")) {
                // Immediately set to false or the player can get a huge jump boost from landing on the collider.
                // Even if the collider is set to IsTrigger.
                boxCollider.enabled = false;

                var animator = other.GetComponent<Animator>();
                animator.SetBool("IsHurt", true);
                var clipInfo = animator.GetCurrentAnimatorClipInfo(0);
                // 0.8f is about the time it takes to play the item_feedback animation.
                if(clipInfo[0].clip.length > 0.8f) {
                    StartCoroutine(WaitThenFinishAnimation(animator, 0.8f));
                } else {
                    StartCoroutine(WaitThenFinishAnimation(animator, clipInfo[0].clip.length));
                }     
            }    
        }

        IEnumerator WaitThenFinishAnimation(Animator animator, float delayTime) {
            yield return new WaitForSeconds(delayTime);
            animator.SetBool("IsHurt", false);
            if(invincibilityTime != 0) {
                Invoke("RespawnOuch", invincibilityTime);
            }
        }

        private void RespawnOuch() {
            boxCollider.enabled = true;
        }
    }
}