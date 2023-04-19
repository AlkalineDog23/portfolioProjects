#pragma once
#include<iostream>
#include<string>
#include<vector>
using namespace std;

class Enemy
{
public:
	Enemy();
	~Enemy();
	void risenDead(); 
	void direBat();
	void fallen();
	void moonClan();
	void soulEater();
	void warden();
	void summoner();
	void frozenHorror();
	void lordOfDestruction();
	bool isAlive;
	int getHealth();
	int getAtk();
	void eHit(int sub);
	void setHealth(int toSet);
	string getName();
	vector<string>eInv;
	void delEInv();
	int eGold = 0;


private:
	int eHealth;
	int eAttack;
	string name;



};