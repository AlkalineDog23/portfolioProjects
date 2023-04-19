#pragma once
#include<iostream>
#include<string>
#include "Enemy.h"


using namespace std;

//Constructor for enemy
Enemy::Enemy() {
	eAttack = 0;
	eHealth = 0;
	isAlive = false;
	name = "";
}



//Risen Dead enemy Function
void Enemy::risenDead() {
	eAttack = 5;
	eHealth = 10;
	isAlive = true;
	name = "Risen Dead";
	eGold = 20;
}

//Dire Bat enemy Function
void Enemy::direBat() {
	eAttack = 7;
	eHealth = 10;
	isAlive = true;
	name = "Dire Bat";
	eGold = 40;
}
//Fallen enemy Function
void Enemy::fallen() {
	eAttack = 6;
	eHealth = 15;
	isAlive = true;
	name = "Fallen";
	eGold = 60;
}

//Moon Clan 
void Enemy::moonClan() {
	eAttack = 12;
	eHealth = 20;
	isAlive = true;
	name = "Moon Clan Member";
	eGold = 100;
}

//Soul Eater enemy Function
void Enemy::soulEater() {
	eAttack = 17;
	eHealth = 30;
	isAlive = true;
	name = "Soul Eater";
	eGold = 200;
}

//Warden enemy Function
void Enemy::warden() {
	eAttack = 20;
	eHealth = 25;
	isAlive = true;
	name = "Warden";
	eGold = 300;
}

//Summoner enemy Function
void Enemy::summoner() {
	eAttack = 25;
	eHealth = 40;
	isAlive = true;
	name = "Summoner";
	eGold = 300;
}

//Frozen Horror enemy Function
void Enemy::frozenHorror() {
	eAttack = 20;
	eHealth = 40;
	isAlive = true;
	name = "Frozen Horror";
	eGold = 150;
}

//Final Boss enemy Function
void Enemy::lordOfDestruction() {
	eAttack = 35;
	eHealth = 70;
	isAlive = true;
	name = "Lord of Destruction";
	eGold = 500;
}

//Deletes enemy inventory
void Enemy::delEInv() {
	for (int i = 0; i < eInv.size(); ++i) {
		eInv.pop_back();
	}
}

//Returns enemy attack
int Enemy::getAtk() {

	return eAttack;
}

//Returns enemy health
int Enemy::getHealth() {
	return eHealth;
}

//Sets enemy health
void Enemy::setHealth(int toSet) {
	eHealth = toSet;
}

//Returns enemy name
string Enemy::getName() {
	return name;
}

//Enemy hit Scene
void Enemy::eHit(int sub) {
	cout << name << " hits you dealing " << eAttack - sub << " damage" << endl;

}
