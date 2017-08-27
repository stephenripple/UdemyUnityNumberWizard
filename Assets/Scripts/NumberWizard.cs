using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {	
	static int minRange = 1;
	static int maxRange = 1000;
	static int userSelection = maxRange / 2;
	static int attempts = 0;

	// Use this for initialization
	void Start () {
		print ("** Number Wizard! **");
		print ("Pick a number in your head from " + minRange.ToString() + " and " + maxRange.ToString());
		print ("Is the number higher (up arrow key) or lower (down arrow key) than " + userSelection.ToString() + " press Enter/Return if we guessed the number correctly");
		Guess();
	}
	
	// Update is called once per frame
	void Update () {
		PromptUser();
	}
	
	bool PromptUser()
	{
		//bool areWeCorrect = false;
		//while(!areWeCorrect)
		//{
			if (Input.GetKeyDown(KeyCode.DownArrow))
			{
				print("Down arrow pressed!");
				maxRange = userSelection;
				attempts++;
				CalculateSelection();
				Guess();
			}
			else if (Input.GetKeyDown(KeyCode.UpArrow))
			{
				print("Up arrow pressed!");
				minRange = userSelection;
				attempts++;
				CalculateSelection();
				Guess();
			}
			else if (Input.GetKeyDown(KeyCode.Return))
			{
				print("You win the internet!");
				return true;
			}
			
		//}
		return false;
	}
	
	void Guess()
	{
		print ("Is your number " + userSelection + "?");
	}
	
	void CalculateSelection()
	{
		userSelection = ((maxRange - minRange) / 2) + minRange;
	}
}
