#pragma once
#include<string>
#include"Map.h"
#include"Room.h"

using namespace std;

class Player : public Map
{
public:
	Player(); 
	~Player();
	int getPlayHealth();
	void setPlayHealth(int toSet);
	void viewPlayerInv();
	void setPlayHit(int dam);
	int playerAttack(string weapon);
	void playerHit(int playAttk);
	bool isAlive = true;
	int playerGold = 0;
	int hit = 1;
	bool playerShield = false;
	bool playerArmor = false;
	bool playerHelm = false;
	int helmBuff = 0;
	int shieldBuff = 0;
	int armorBuff = 0;
	int getBuff();
	Room* playerPos;
	vector<string>playInv; //Player inventory
	bool xxDamage = false;
private:
	int playerHealth = 100; //Player health
};
