#pragma once
#include<iostream>
#include<vector>
#include "Room.h"

using namespace std;

Room::Room(string rN, string rD) 
{
	
	rName = rN;
	rDesc = rD;

}
//Gets room name
void Room::getRName() {
	cout << rName;
}

//Gets room description
void Room::getRDesc() {
	cout << rDesc;
}

//Look around
void Room::look() {

		//Checks room inventory is empty
	if (rInventory.size() > 0) {

		//Loop through room inventory
		for (int i = 0; i < rInventory.size(); ++i) {
			if (rInventory.size() == 1) {
				cout << "You see a ";
				cout << rInventory[i] << " ";
			}
			else if (rInventory.size() > 1) {
				if (i == 0) {
					cout << "You see a ";
				}

				cout << rInventory[i] << " ";
				if (i != + rInventory.size() - 1) {
					cout << "and a ";
					}
				}
			}
		}
	//if there is nothing in room inventory
	else {
		cout << "You See Nothing special" << endl;
	}
	cout << endl;

	//If enemy is alive
	if (enemy->isAlive) {
		inBattle = true;	//Trigger enemy attack and battle mode
}


}

//Deletes Item from room inventory
void Room::delRoomInv(int pos) {
	rInventory.erase(rInventory.begin() + pos);
}

//Add item to room inventory
void Room::addRoomInv(string item) {
	rInventory.push_back(item);
}

//Returns room name
string Room::retRoomName() {
	return rName;

}

//Room Destructor
Room::~Room() {

}