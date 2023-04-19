#pragma once
#include<iostream>
#include<string>
#include<vector>
#include "Enemy.h"
#include"Shop.h"
using namespace std;

class Room
{
public:
	Room(string rName,string rDesc);
	void getRName();
	void getRDesc();
	void look();
	void delRoomInv(int pos);
	void addRoomInv(string item);
	string retRoomName();
	
	~Room();
	
	vector<string>rInventory; //Room inventory

	Room* pNorth;
	Room* pSouth;
	Room* pEast;
	Room* pWest;
	Room* pDown;
	Room* pUp;
	Enemy* enemy = new Enemy;
	Enemy* enemy2 = new Enemy;
	Enemy* enemy3 = new Enemy;
	Shop* shop = 0;
	bool inBattle = false;
	bool locked = false;

private:
	string rName;
	string rDesc;
};







