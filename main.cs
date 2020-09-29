using System;
using System.Collections.Generic;

class MainClass {

	//---Create a guest book---
	//ask the guest for their first name
	//ask the guest for their last name
	//ask the guest for a meassage they want to tell the host
	//ask if there are anymore guests coming
	//print out the guest information

	public static List<GuestModel> guests = new List<GuestModel>();
	public static string moreGuestsComing = "";

  public static void Main (string[] args) {
    
		do {

			GetGuestInformation();

		} while (moreGuestsComing.ToLower() == "yes");

		DisplayGuestInfo();

		Console.ReadLine();
  }

	public static void DisplayGuestInfo() {
		foreach (GuestModel guest in guests) {
			Console.WriteLine(guest.GuestInfo);
		}
	}

	public static void GetGuestInformation() {
		GuestModel guest = new GuestModel();

		guest.FirstName = AskGuestForInformation("What is your first name: ");
		guest.LastName =AskGuestForInformation("What is your last name: ");
		guest.MessageToHost = AskGuestForInformation("What message would you like to tell the host: ");
		moreGuestsComing = AskGuestForInformation("Are more guests coming (yes/no): ");

		guests.Add(guest);

		Console.Clear();
	}

	public static string AskGuestForInformation(string message) {
		string output = "";

		Console.Write(message);
		output = Console.ReadLine();

		return output;
	}
}