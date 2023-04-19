#pragma once
#include<iostream>
#include"Players.h"
#include"Map.h"
#include<string>

using namespace std;

//Function prototypes
void fightScene(Player& userPlay);
void mapReset(Map& dMap);

int main() {
	Map dMap;
	string playerChoice;
	string itemToPick;
	//Create Player Class
	Player character;	
	bool itemFound = false;
	string go;


	//Intro
	cout << "Welcome Adventurer" << endl;
	cout << "SCENE:" << endl;
	cout << "You are a new hero who has just arrived in the world of Sanctum your mission is to vanguish evil throughout Sanctum, you will be faced with difficult enemies and monsters" << endl;
	cout << "The people of this realm are counting on you good luck\n" << endl;
	
	cout << "\nGame Controls: \n";
	cout << "To take,drop,use or buy items you must type the item name just as it appears in the game" << endl;
	
	cout << "type view to view inventory" << endl;
	cout << "type attack to attack with items in inventory" << endl;
	cout << "type look to view area surroundings" << endl;
	cout << "Type take to take items" << endl;
	cout << "Type drop to drop items" << endl;
	cout << "Type use to use items in inventory" << endl;
	cout << "Type shop to enter shop mode when in Camp" << endl;
	cout << "Type Exit to exit" << endl;

	cout << "\nShop Menu:\n";
	cout << "Type view to view items in shop" << endl;
	cout << "Type buy to buy items from shop" << endl;
	cout << "Type Exit to exit shop" << endl;

	cout << "\nWhen you start you will Spawn in Camp and from there Choose where to go. \nYou can type N or North to go North \nYou can type S or South to go South \nYou can type E or East to go East \nYou can type W or West to go West" << endl;

	cout << "\nType something then hit enter to continue" << endl;
	
	cin >> go;

	//Create shop items for map
	dMap.mStart->shop->addShopInv("Scimitar", 250);
	dMap.mStart->shop->addShopInv("MedKit", 250);
	dMap.mStart->shop->addShopInv("Mace", 400);
	dMap.mStart->shop->addShopInv("Sword", 150);

	
	do {
		if (character.isAlive == true) {


			//When game is finished run outro
			if (character.playerPos->retRoomName() == "\nYou have reached the Throne Of Destruction " && character.playerPos->enemy->isAlive == false) {

				cout << "Congratulations hero, you have explored the world of sanctuary and defeated the forces of evil" << endl;
				cout << "The people of these lands will forever be grateful to you" << endl;
				cout << "You have now become a Champion of Sanctuary" << endl;
				cout << "\nThanks for Playing a Traaash Productions Game" << endl;
				cout << "\nCREDITS\n" << endl;
				cout << "Producer: Stephen 'Hunter' Swetman" << endl;
				cout << "Lead Developer: Stephen 'Hunter' Swetman" << endl;
				cout << "Lead Desinger: Stephen 'Hunter' Swetman" << endl;
				break;

			}

			//Get room and location
			character.playerPos->getRName();
			character.playerPos->getRDesc();
		
			//Get player choice
			cout << "\nWhat should I do?" << endl;
			cin >> playerChoice;


			//If player goes East
			if (playerChoice == "E" || playerChoice == "East" || playerChoice == "east" || playerChoice == "e") {
				if (character.playerPos->pEast != 0) {
					if (character.playerPos->pEast->locked == false) { //Check for locked doors
						character.playerPos = character.playerPos->pEast;
						cout << endl;
					}
					else {
						cout << "This room is locked" << endl;
					}
				}

				else {
					cout << "\nCant go here" << endl;

				}

			}

			//If player goes west
			else if (playerChoice == "W" || playerChoice == "West" || playerChoice == "west" || playerChoice == "w") {
				if (character.playerPos->pWest != 0) {
					if (character.playerPos->pWest->locked == false) { //Check for locked doors
						character.playerPos = character.playerPos->pWest;
						cout << endl;

					}
					else {
						cout << "This way is locked" << endl;
					}
				}
				else {
					cout << "\nCant go here" << endl;

				}

			}

			//If player goes North
			else if (playerChoice == "N" || playerChoice == "North" || playerChoice == "north" || playerChoice == "n") {
				if (character.playerPos->pNorth != 0) {
					if (character.playerPos->pNorth->locked == false) { //Check for locked doors
						character.playerPos = character.playerPos->pNorth;
						cout << endl;
					}
					else {
						cout << "This way is locked" << endl;
					}
				}

				else {
					cout << "\nCant go here" << endl;

				}

			}

			//If user goes South
			else if (playerChoice == "S" || playerChoice == "South" || playerChoice == "south" || playerChoice == "s") {
				if (character.playerPos->pSouth != 0) {
					if (character.playerPos->pSouth->locked == false) { //Check for locked doors
						character.playerPos = character.playerPos->pSouth;
						cout << endl;

					}
					else {
						cout << "This way is locked" << endl;
					}
				}

				else {
					cout << "\nCant go here" << endl;

				}

			}
			//If player tries to go down
			else if (playerChoice == "d" || playerChoice == "down" || playerChoice == "D" || playerChoice == "Down") {
				if (character.playerPos->pDown != 0) {
					if (character.playerPos->pDown->locked == false) { //Check for locked doors
						character.playerPos = character.playerPos->pDown;
						cout << endl;
					}
					else {
						cout << "This way is locked" << endl;
					}
				}

				else {
					cout << "\nThere is nothing to climb down to" << endl;

				}

			}


			//If player tries to go up
			else if (playerChoice == "u" || playerChoice == "Up" || playerChoice == "U" || playerChoice == "up") {
				if (character.playerPos->pUp != 0) {
					if (character.playerPos->pUp->locked == false) { //Check for locked doors
						character.playerPos = character.playerPos->pUp;
						cout << endl;
					}
					else {
						cout << "This way is locked" << endl;
					}
				}

				else {
					cout << "\nThere is nothing to climb up to" << endl;

				}

			}
			//Call to look function to see whats in the room
			else if (playerChoice == "look" || playerChoice == "Look") {
				character.playerPos->look();
			}


			//Take from room inv add to player inv
			else if (playerChoice == "take" || playerChoice == "Take") {
			int price = 0;
			bool shopFound = false;
				cout << "Enter item to take" << endl;
				cin >> itemToPick;

				//Look to see if item user entered to pick up is in room inv
				if (character.playInv.size() < 4) {
					
						for (int i = 0; i < character.playerPos->rInventory.size(); ++i) {
							if (itemToPick == character.playerPos->rInventory[i]) {

								cout << "Item taken" << endl;
								character.playerPos->delRoomInv(i); //Remove from room inv
								character.playInv.push_back(itemToPick); //Add to player inv
								itemFound = true;
								break;
							}

						}
				}
				else {
					cout << "I am overburdened, I should drop something before trying to pick that up" << endl;
					
				}
				
				//If item is not found
				if (!(itemFound)) {
					cout << "This item does not exist" << endl;
				}
				else {
					itemFound = false;

				}
			}


			//remove from player inv add to room inv
			else if (playerChoice == "drop" || playerChoice == "Drop") {
				cout << "Enter item to drop" << endl;
				cin >> itemToPick;

				//Check to see if item user entered is in player inv
				for (int i = 0; i < character.playInv.size(); ++i) {
					if (itemToPick == character.playInv[i]) {
						cout << "Item dropped" << endl;
						character.playerPos->addRoomInv(character.playInv[i]);  //Add item to room inv
						character.playInv.erase(character.playInv.begin() + i); //Delete from player inv
						itemFound = true;
						break;
					}

				}
				//If item is not found
				if (!(itemFound)) {
					cout << "Item not found in your inventory" << endl;
				}
				else {
					itemFound = false;
				}
			}

			//View player Stats
			else if (playerChoice == "view" || playerChoice == "View") {
				cout << endl;
				cout << "Player Health:" << endl;
				cout << character.getPlayHealth() << endl;
				cout << "Player Gold:" << endl;
				cout << character.playerGold << endl;
				cout << "Player Inventory:" << endl;

				//If player inventory is empty
				if (character.playInv.size() != 0) {
					character.viewPlayerInv();
				}
				else {
					cout << "There is nothing in your inventory" << endl;
				}
			}


			//Player attack with function call to fightscene
			else  if (playerChoice == "attack" || playerChoice == "Attack") {
				fightScene(character);
			}


			//If user wants to use item in inventory
			else if (playerChoice == "use" || playerChoice == "Use") {
				cout << "Select item to use from inventory" << endl;
				cin >> itemToPick;

				//Check to see if item is in player inventory
				for (int i = 0; i < character.playInv.size(); ++i) {
					if (itemToPick == character.playInv[i]) {
						itemFound = true;

						//If MedKit :: Restore player health
						if (itemToPick == "MedKit") {
							if (character.getPlayHealth() < 100) {
								character.setPlayHealth(character.getPlayHealth() + 10);
								if (character.getPlayHealth() > 100) {
									character.setPlayHealth(100);
								}
								//Remove MedKit from inventory and show new player health
								character.playInv.erase(character.playInv.begin() + i);
								cout << "Gained + 10 health, new health level is " << character.getPlayHealth() << endl;
							}
			
							//If player does not need to replenish any health
							else {
								cout << "You do not need to replenish any health" << endl;
							}
							break;
						}


						//If Key :: unlock door that is locked
						else if (itemToPick == "key" || itemToPick == "Key") {

							//if door that is locked is down from room that player is currently in
							if (character.playerPos->pDown != 0 && character.playerPos->pDown->locked == true) {
								character.playerPos->pDown->locked = false;
								character.playInv.erase(character.playInv.begin() + i);
							}

							//if door that is locked is up from room that player is currently in
							else if (character.playerPos->pUp != 0 && character.playerPos->pUp->locked == true) {
								character.playerPos->pUp->locked = false;
								character.playInv.erase(character.playInv.begin() + i);
							}
							//if door that is locked is North from room that player is currently in
							else if (character.playerPos->pNorth != 0 && character.playerPos->pNorth->locked == true) {
								character.playerPos->pNorth->locked = false;
								character.playInv.erase(character.playInv.begin() + i);
							}

							//if door that is locked is East from room that player is currently in
							else if (character.playerPos->pEast != 0 && character.playerPos->pEast->locked == true) {
								character.playerPos->pEast->locked = false;
								character.playInv.erase(character.playInv.begin() + i);
							}

							//if door that is locked is South from room that player is currently in
							else if (character.playerPos->pSouth != 0 && character.playerPos->pSouth->locked == true) {
								character.playerPos->pSouth->locked = false;
								character.playInv.erase(character.playInv.begin() + i);
							}

							//if door that is locked is West from room that player is currently in
							else if (character.playerPos->pWest != 0 && character.playerPos->pWest->locked == true) {
								character.playerPos->pWest->locked = false;
								character.playInv.erase(character.playInv.begin() + i);
							}

							//If there is no doors to unlock
							else {
								cout << "There is nothing to unlock" << endl;
								break;
							}

							//If door was successfully unlocked
							cout << "Key used" << endl;
							break;
						}

						//If Scroll :: Increase attack rating
						else if (itemToPick == "Scroll" or itemToPick == "scroll") {
							character.setPlayHit(2); //call to set player attack rating function
							character.playInv.erase(character.playInv.begin() + i); //Remove scroll from player inventory
							cout << "I have grown stronger" << endl;
							break;
						}

						//If Amulet :: Fully Replenish player Health
						else if (itemToPick == "Amulet" || itemToPick == "amulet") {
							character.setPlayHealth(100); //Call to set player health function to fully restore health
							character.playInv.erase(character.playInv.begin() + i); //Remove Amulet from player Inventory
							cout << "You were granted full health" << endl;
							break;
						}

						else if (itemToPick == "Shield" || itemToPick == "shield") {
							character.playerShield = true; //Set shield flag to true 
							character.playInv.erase(character.playInv.begin() + i); //Remove shield from player inventory
								cout << "You were granted a increase in defense" << endl;
								break;
						}

						else if (itemToPick == "Armor" || itemToPick == "armor") {
							character.playerArmor = true; //Set Armor flag to true 
							character.playInv.erase(character.playInv.begin() + i); //Remove shield from player inventory
							cout << "You were granted a increase in defense" << endl;
							break;
						}

						else if (itemToPick == "Helm" || itemToPick == "helm") {
							character.playerHelm = true; //Set helm flag to true 
							character.playInv.erase(character.playInv.begin() + i); //Remove shield from player inventory
							cout << "You were granted a increase in defense" << endl;
							break;
						}
						//If item in inventory is not usable in this manner
						else {
							cout << "Cannot use this item" << endl;
						}
					}
				}
				//If item is not found inventory
				if (!(itemFound)) {
					cout << "Item not found in your inventory" << endl;
				}
				else {
					itemFound = false;
				}

			}


			//If player is in Camp and player enters shop
			else if (playerChoice == "Shop" || playerChoice == "shop") {
				string shopChoice = "";
				int count = 0;

				//Check to make sure user is in Camp
				if (character.playerPos->shop != 0) {
					
					//Start shop encounter
						cout << "Welcome to my shop hero, someone like you should be able to afford these prices" << endl;
						while (shopChoice != "Exit" && shopChoice != "exit") {
						cout << "Type view to view shop wares" << endl;
						cout << "Type buy to buy items" << endl;
						cout << "Type exit to exit shop" << endl;
						cin >> shopChoice;

						//View items in shop
						if (shopChoice == "view" || shopChoice == "View") {
							dMap.mStart->shop->viewShopInv(); //Function call to view items in shop inventory
						}

						//Buy shop items
						else if (shopChoice == "Buy" || shopChoice == "buy") {
							cout << "What item would you like to buy?" << endl;
							cin >> shopChoice;

							//Check to make sure item is indeed in shop inventory
							for (int i = 0; i < dMap.mStart->shop->shopInv.size(); ++i) {
								if (dMap.mStart->shop->shopInv[i] == shopChoice) {
									itemFound = true;
									count = i;
									break;
								}
							}
							//If item is user entered is not in shop inventory
							if (!(itemFound)) {
								cout << "I do not have that item in my shop!" << endl;
							}

							else {
								itemFound = false;

								//Remove gold needed from player gold count
								if (character.playerGold >= dMap.mStart->shop->shopPrice[count]) {
									cout <<  shopChoice << " Purchased" << endl;
									character.playInv.push_back(shopChoice); //Add purchased item into player inventory
									
									//Add items to keep from being destroyed when bought
									character.playerGold -= dMap.mStart->shop->shopPrice[count];

								}
								//If player does not have sufficient funds to purchase item
								else {
									cout << "You don't have the money? Are you kidding me? Get Out!" << endl;
								}
							}
						}
						//If user wants to exit shop
						else if (shopChoice == "Exit" || shopChoice == "exit") {
							cout << "Good day to you" << endl;
							break;
						}
						//If user enters incorrect commands
						else {
							cout << "If you are going to talk gibberish go away, savy?" << endl;
						}
					}

				}
				//If player is not in Camp
			else {
				cout << "\nThe only Shop is in the camp" << endl;
			}
}
			//User can exit Game
			else {
				if (playerChoice == "Exit" || playerChoice == "exit") {
					break;
				}
				//If user enters incorrect command outside the shop
				else {
					cout << "Not a valid choice" << endl;
				}
			}

			//If enemy is alive and enemy hit is triggered
			if (character.playerPos->inBattle) {
				if (character.playerPos->enemy->isAlive) {
					cout << "A enemy is attacking you" << endl;
					character.playerPos->enemy->eHit(character.getBuff()); //Trigger enemy hit
					character.setPlayHealth(character.getPlayHealth() - (character.playerPos->enemy->getAtk() - character.getBuff())); //Subract enemy hit from player health
					if (character.getPlayHealth() > 0) {
						cout << "\nHealth left: " << character.getPlayHealth() << endl;
					}
					//If player has died
					else {
						cout << "Oh no you have died" << endl;
						character.isAlive = false;
					}
				}
			}


		}

		//If player is dead
		else {
		character.setPlayHit(1); //Reset player attack rating
		character.setPlayHealth(100); //Reset player health
		character.playerPos = dMap.mStart; //Reset player location
		character.playerArmor = false;		//Reset Armor buff
		character.playerShield = false;		//Reset shield buff
		character.playerHelm = false;		//Reset helm buff

		//Remove all items from player inventory
		for (int i = character.playInv.size() - 1; i >= 0; -- i) {
			character.playInv.pop_back();
		}

		//Start player death scene
		cout << "Your inventory has been lost to the demons, but you have received Angel of Death's Gift: 200 gold" << endl;
		cout << "See what the merchant has to offer" << endl;
		character.isAlive = true; //Revive player
		character.playerGold += 200; //Add Angels of Death gift to player gold
		mapReset(dMap); //Function call to remove all rooms from Map
		Map newMap; //Create new Map
		dMap = newMap; //Set Map equal to new Map to reinstatiate all rooms

		//Create shop inventory
		dMap.mStart->shop->addShopInv("Scimitar", 250);
		dMap.mStart->shop->addShopInv("MedKit", 250);
		dMap.mStart->shop->addShopInv("Mace", 400);
		dMap.mStart->shop->addShopInv("Sword", 150);

		}

	}
		
		while (playerChoice != "Exit" || playerChoice != "exit");



	return 0;
}
//Call Map destructor
void mapReset(Map& dmap) {
	dmap.~Map();
	

}






//Function for player and enemy fight scene
void fightScene(Player& userPlay) {
	int playAtk = 0;
	int playHealth = 0;
	int charAtk = 0;
	int charHealth = 0;
	string itemToPick;
	bool found = false;

	//Check if enemy is alive
	if (userPlay.playerPos->enemy->isAlive) {
		while (userPlay.playerPos->enemy->isAlive) {
			cout << "Attack with what?" << endl;
			cin >> itemToPick;  //Get player input for weapon choice
			if (itemToPick == "back") { //If player chooses to back out of attack Mode
				break; 
			}
			//Check if player input is found in player inventory
			for (int i = 0; i < userPlay.playInv.size(); ++i) {
				if (itemToPick == userPlay.playInv[i]) {
					found = true;
				}
			}

			//If item is found and can be attacked with
			if (found) {
				if (itemToPick == "Sword") {
					playAtk = userPlay.playerAttack(itemToPick);  //Get player attack added with Sword

					userPlay.playerHit(playAtk); //set playerAttack 
					userPlay.playerPos->enemy->eHit(userPlay.getBuff()); //Enter enemy hit sequence
					userPlay.setPlayHealth(userPlay.getPlayHealth() - (userPlay.playerPos->enemy->getAtk() - userPlay.getBuff()));	//Set player health subtracted from enemy hit
					userPlay.playerPos->enemy->setHealth(userPlay.playerPos->enemy->getHealth() - playAtk);		//Set enemy health subtracted from player damage
					cout << "\nHealth left: " << userPlay.getPlayHealth() << endl; //Show new player Health
					found = false;	//Set found back to false

				}
				else if (itemToPick == "BattleAxe") {
					playAtk = userPlay.playerAttack(itemToPick);
					//With BattleAxe
					userPlay.playerHit(playAtk);
					userPlay.playerPos->enemy->eHit(userPlay.getBuff());
					userPlay.setPlayHealth(userPlay.getPlayHealth() - (userPlay.playerPos->enemy->getAtk() - userPlay.getBuff()));	//Set player health subtracted from enemy hit
					userPlay.playerPos->enemy->setHealth(userPlay.playerPos->enemy->getHealth() - playAtk);
					cout << "\nHealth left: " << userPlay.getPlayHealth() << endl;
					found = false;
				
				}
				else if (itemToPick == "Spear") {
					playAtk = userPlay.playerAttack(itemToPick);
					//With Spear
					userPlay.playerHit(playAtk);
					userPlay.playerPos->enemy->eHit(userPlay.getBuff());
					userPlay.setPlayHealth(userPlay.getPlayHealth() - (userPlay.playerPos->enemy->getAtk() - userPlay.getBuff()));	//Set player health subtracted from enemy hit
					userPlay.playerPos->enemy->setHealth(userPlay.playerPos->enemy->getHealth() - playAtk);
					cout << "\nHealth left: " << userPlay.getPlayHealth() << endl;
					found = false;

				}
				else if (itemToPick == "Scimitar") {
					playAtk = userPlay.playerAttack(itemToPick);
					//With Scimitar
					userPlay.playerHit(playAtk);
					userPlay.playerPos->enemy->eHit(userPlay.getBuff());
					userPlay.setPlayHealth(userPlay.getPlayHealth() - (userPlay.playerPos->enemy->getAtk() - userPlay.getBuff()));	//Set player health subtracted from enemy hit
					userPlay.playerPos->enemy->setHealth(userPlay.playerPos->enemy->getHealth() - playAtk);
					cout << "\nHealth left: " << userPlay.getPlayHealth() << endl;
					found = false;

				}

				else if (itemToPick == "Mace") {
					playAtk = userPlay.playerAttack(itemToPick);
					//With Mace
					userPlay.playerHit(playAtk);
					userPlay.playerPos->enemy->eHit(userPlay.getBuff());
					userPlay.setPlayHealth(userPlay.getPlayHealth() - (userPlay.playerPos->enemy->getAtk() - userPlay.getBuff()));	//Set player health subtracted from enemy hit
					userPlay.playerPos->enemy->setHealth(userPlay.playerPos->enemy->getHealth() - playAtk);
					cout << "\nHealth left: " << userPlay.getPlayHealth() << endl;
					found = false;

				}
				//If user chooses item in inventory that cannot be attacked with
				else {
					cout << "Cannot attack with this Item" << endl;
					found = false;
				}

				//If enemy in room is dead
				if (userPlay.playerPos->enemy->getHealth() <= 0) {
					cout << "You have killed " << userPlay.playerPos->enemy->getName() << endl;
					userPlay.playerPos->inBattle = false; //Set battle mode to false
					userPlay.playerPos->enemy->isAlive = false;		//Set enemy to dead

					//Empty items from enemy inventory into Room inventory
					for (int i = 0; i < userPlay.playerPos->enemy->eInv.size(); ++i) {
						userPlay.playerPos->rInventory.push_back(userPlay.playerPos->enemy->eInv[i]);
					}

					userPlay.playerPos->enemy->delEInv(); //Function call to delete enemy inventory
					userPlay.playerGold += userPlay.playerPos->enemy->eGold; //Add gold to player gold
					userPlay.playerPos->enemy->eGold = 0; //Set Enemy gold to 0
					if (userPlay.playerPos->enemy2->isAlive == true) { //Check for second enemies
						userPlay.playerPos->enemy = userPlay.playerPos->enemy2;
						break;
					}
				}
				
				//Check to see if player has died
				 if (userPlay.getPlayHealth() <= 0) {
					cout << "\nOh No You Have Died " << endl;
					userPlay.isAlive = false;
					break;
				}


			}
			//If item player entered to attack with was not found in inventory
			else {
				cout << "Item not found in inventory" << endl;
				cout << "Type back to disengage" << endl;
			}
		}
		
	}

	//If enemy in room is not alive
	else {
		cout << "There is nothing to attack" << endl;
	}
}
