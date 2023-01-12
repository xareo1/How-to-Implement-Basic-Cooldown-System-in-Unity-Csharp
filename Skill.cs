using UnityEngine;

public class Skill : MonoBehaviour
{
    public float cooldownTime = 5f; // The cooldown time for the skill
    private float remainingCooldown = 0f; // The remaining cooldown time
    private bool onCooldown = false; // Flag to check if the skill is on cooldown

    public void UseSkill()
    {
        // Check if the skill is on cooldown
        if (onCooldown)
        {
            // If the skill is on cooldown, display a message or do nothing
            Debug.Log("Skill is on cooldown. Please wait.");
            return;
        }

        // Perform the skill's action here

        // Set the remaining cooldown and turn on the cooldown flag
        remainingCooldown = cooldownTime;
        onCooldown = true;
    }

    private void Update()
    {
        // Check if the skill is on cooldown
        if (onCooldown)
        {
            // Decrement the remaining cooldown time
            remainingCooldown -= Time.deltaTime;

            // Check if the remaining cooldown time is less than or equal to 0
            if (remainingCooldown <= 0)
            {
                // If the remaining cooldown time is less than or equal to 0, turn off the cooldown flag
                onCooldown = false;
            }
        }
    }
}
